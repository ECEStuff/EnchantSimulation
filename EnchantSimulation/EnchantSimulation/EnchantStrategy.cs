using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace EnchantSimulation
{
    public class EnchantStrategy
    {
        public struct Trial
        {
            public bool Successful;
            public int UsedEnchantCards;
            public int UsedHyperEnchantCards;
            public int Attempts;            
            public int Used15Boosters;
            public int UsedEProts;
            public int UsedHProts;
            public int UsedBooks;
            public int UsedItems; // for weapon/armor raging
            public int UsedSpCards;
        }

        public class TrialSignature : IComparable
        {
            public int UsedEnchantCards;
            public int UsedHyperEnchantCards;
            public int Attempts;            
            public int Used15Boosters;
            public int UsedEProts;
            public int UsedHProts;
            public int UsedBooks;
            public int Frequency;
            public int UsedItems;
            public int UsedSpCards;

            public int CompareTo(object obj)
            {
                if (obj == null) return 1;

                TrialSignature other = obj as TrialSignature;
                if (other == null)
                {
                    throw new ArgumentException("Object is not a TrialSignature!");
                }
                else
                {
                    int x = this.UsedEnchantCards.CompareTo(other.UsedEnchantCards);
                    if (x == 0)
                        x = this.UsedHyperEnchantCards.CompareTo(other.UsedHyperEnchantCards);
                    if (x == 0)
                        x = this.UsedHProts.CompareTo(other.UsedHProts);
                    if (x == 0)
                        x = this.UsedEProts.CompareTo(other.UsedEProts);
                    if (x == 0)
                        x = this.Used15Boosters.CompareTo(other.Used15Boosters);
                    if (x == 0)
                        x = this.UsedBooks.CompareTo(other.UsedBooks);
                    if (x == 0)
                        x = this.UsedItems.CompareTo(other.UsedItems);
                    if (x == 0)
                        x = this.UsedSpCards.CompareTo(other.UsedSpCards);
                    return x;
                }                    
            }
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int StartingLevel = 0;
        public int TargetLevel = 12;
        public int Simulations = 100000;
        public int MaxSimulationLength = 1000000;
        public EnchantLevel.ItemType ItemType =  EnchantLevel.ItemType.WeaponArmor;
        public List<EnchantLevel> Levels;

        private List<Trial> Trials;
        private List<TrialSignature> Statistics;

        private Trial Test(Random r, double lv1Prob)
        {
            int i = 0, level = StartingLevel, boost15count = 0, eprotcount = 0, hprotcount = 0, cardcount = 0, bookcount = 0, itemcount = 1, spcardcount = 0, hypercardcount = 0;

            for (; i < MaxSimulationLength; i++)
            {
                EnchantLevel el = Levels[level];

                if (el.Use15Booster)
                    boost15count++;

                if (el.UseEProt)
                    eprotcount++;

                if (el.UseHProt)
                    hprotcount++;
                

                // Assume e10+ = hypers only. CHANGED: Check if the item is going to level 1 legend first. If it is, books are used. If not, cards are used.

                double prob;

                if (level == 0 && (ItemType == EnchantLevel.ItemType.LegendArmor || ItemType == EnchantLevel.ItemType.LegendWeapon))
                {
                    bookcount++;
                    prob = lv1Prob;
                }

                else 
                {
                    if (el.UseSpCard && (ItemType == EnchantLevel.ItemType.WeaponArmor)) // if mixed enchants are used; special cards are energy/shield cards and speed cards
                    {
                        spcardcount++;
                    }

                    else { // normal enchant cards
                        if (level < 10)
                            cardcount++;
                        else
                            hypercardcount++;
                    }

                    prob = el.GetDerivedProbability(level, ItemType);
                }               

                if (r.NextDouble() < prob)
                {
                    // success, increment
                    level++;

                    if (level == TargetLevel)
                        break;
                }
                else
                {
                    // Can't use eprots on legend items
                    if (ItemType == EnchantLevel.ItemType.LegendArmor || ItemType == EnchantLevel.ItemType.LegendWeapon)
                    {
                        level = 0;
                        itemcount++;
                    }
                    else
                    {
                        if (el.UseEProt)
                        {
                            // failure, reset 5
                            level = 5;
                        }
                        else if (el.UseHProt)
                        {
                            // Reset to level 10 for hprots
                            level = 10;
                        }

                        else { 
                            level = 0;
                            itemcount++;
                        }
                    }
                }
            }

            return new Trial { Attempts = i + 1, Successful = (level == TargetLevel), UsedEnchantCards = cardcount,UsedHyperEnchantCards = hypercardcount,
                                Used15Boosters = boost15count, UsedEProts = eprotcount, UsedHProts = hprotcount, UsedBooks = bookcount, UsedItems = itemcount, UsedSpCards = spcardcount };
        }

        private List<Trial> RunSimulation(double lv1Prob)
        {
            List<Trial> ret = new List<Trial>();
            Random r = new Random();

            for (int i = 0; i < Simulations; i++)
            {
                ret.Add(Test(r, lv1Prob));
            }

            return ret;
        }

        public static double CalculateCost(double cards, double cardcost, double hypercards, double hypercardcost, double boost15, double boost15cost,
                                    double eprot, double eprotcost, double hprot, double hprotcost, double book, double bookcost, double item, double itemcost, double spcards, double spcardcost)
        {
            return (cards * cardcost) + (hypercards * hypercardcost) + (boost15 * boost15cost) +
                    (eprot * eprotcost) + (hprot * hprotcost) + (book * bookcost) + (item * itemcost) + (spcards * spcardcost);
        }

        public void CalculateFrequencies(double lv1Prob)
        {
            Trials = RunSimulation(lv1Prob);

            Statistics = Trials.GroupBy(x => new { x.Attempts, x.UsedEnchantCards, x.UsedHyperEnchantCards, x.Used15Boosters, x.UsedEProts, x.UsedHProts, x.UsedBooks, x.UsedItems, x.UsedSpCards })
                            .Select(x => new TrialSignature { Attempts = x.Key.Attempts, UsedEnchantCards = x.Key.UsedEnchantCards,UsedHyperEnchantCards = x.Key.UsedHyperEnchantCards,
                                                                Used15Boosters = x.Key.Used15Boosters,
                                                                UsedEProts = x.Key.UsedEProts, UsedHProts = x.Key.UsedHProts, UsedBooks = x.Key.UsedBooks, UsedItems = x.Key.UsedItems, UsedSpCards = x.Key.UsedSpCards, Frequency = x.Count() })
                            .OrderBy(x => x).ToList();
        }

        public string GenerateReport(double cardcost, double hypercardcost, double boost15cost, double eprotcost, double hprotcost, double bookcost, double itemcost, double spcardcost)
        {            
            double avgec = Trials.Average(x => x.UsedEnchantCards);
            double avghc = Trials.Average(x => x.UsedHyperEnchantCards);
            double avg15 = Trials.Average(x => x.Used15Boosters);
            double avge = Trials.Average(x => x.UsedEProts);
            double avgh = Trials.Average(x => x.UsedHProts);
            double avgb = Trials.Average(x => x.UsedBooks);
            double avgi = Trials.Average(x => x.UsedItems);
            double avgsc = Trials.Average(x => x.UsedSpCards);

            double pct5 = -1, pct50 = -1, pct95 = -1, avgCost = -1;
            string formatted_pct5, formatted_pct50, formatted_pct95, formatted_avgCost;
            int cumulativeFrequency = 0;

            foreach(TrialSignature stat in Statistics)
            {
                cumulativeFrequency += stat.Frequency;

                if(cumulativeFrequency >= Math.Ceiling(Trials.Count * 0.05) && pct5 == -1)
                {
                    pct5 = CalculateCost(stat.UsedEnchantCards, cardcost, stat.UsedHyperEnchantCards, hypercardcost, stat.Used15Boosters, boost15cost, stat.UsedEProts, eprotcost, stat.UsedHProts, hprotcost, stat.UsedBooks, bookcost, stat.UsedItems, itemcost, stat.UsedSpCards, spcardcost);
                }
                else if(cumulativeFrequency >= Math.Ceiling(Trials.Count * 0.5) && pct50 == -1)
                {
                    pct50 = CalculateCost(stat.UsedEnchantCards, cardcost, stat.UsedHyperEnchantCards, hypercardcost, stat.Used15Boosters, boost15cost, stat.UsedEProts, eprotcost, stat.UsedHProts, hprotcost, stat.UsedBooks, bookcost, stat.UsedItems, itemcost, stat.UsedSpCards, spcardcost);
                }
                else if (cumulativeFrequency >= Math.Ceiling(Trials.Count * 0.95) && pct95 == -1)
                {
                    pct95 = CalculateCost(stat.UsedEnchantCards, cardcost, stat.UsedHyperEnchantCards, hypercardcost, stat.Used15Boosters, boost15cost, stat.UsedEProts, eprotcost, stat.UsedHProts, hprotcost, stat.UsedBooks, bookcost, stat.UsedItems, itemcost, stat.UsedSpCards, spcardcost);
                }
            }

            avgCost = CalculateCost(avgec, cardcost, avghc, hypercardcost, avg15, boost15cost, avge, eprotcost, avgh, hprotcost, avgb, bookcost, avgi, itemcost, avgsc, spcardcost);

            formatted_pct5 = pct5.ToString("N");
            formatted_pct50 = pct50.ToString("N");
            formatted_pct95 = pct95.ToString("N");
            formatted_avgCost = avgCost.ToString("N");

            return string.Format(@"Average Enchant Cards used = {0}, Average Special Enchant Cards used = {1}, Average Hyper Enchant Cards used = {2},
Average 15% used = {3}, Average E-prots used = {4}, 
Average H-prots used = {5},
Average Books used = {6}, Average base items used = {7}

Estimated average cost = {8}
5th percentile = {9}, 50th percentile = {10},
95th percentile = {11}", avgec, avgsc, avghc, avg15, avge, avgh, avgb, avgi, formatted_avgCost, formatted_pct5, formatted_pct50, formatted_pct95);
        }
    }
}

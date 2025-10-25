using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnchantSimulation
{
    public class EnchantLevel
    {
        private static readonly Dictionary<int, double> LegendArmorProbabilities = new Dictionary<int, double>
        {
            {0, 1 }, // placeholder; actual percentage should be user parameter
            {1, 0.5 },
            {2, 0.4 },
            {3, 0.3 },
            {4, 0.2 },
            {5, 0.1 },
            {6, 0.05 }
        };

        private static readonly Dictionary<int, double> LegendWeaponProbabilities = new Dictionary<int, double>
        {
            {0, 1 }, // placeholder; actual percentage should be user parameter
            {1, 0.9 },
            {2, 0.8 },
            {3, 0.7 },
            {4, 0.6 },
            {5, 0.5 },
            {6, 0.4 },
            {7, 0.3 },
            {8, 0.2 },
            {9, 0.1 },
            {10, 0.1 },
            {11, 0.05 },
            {12, 0.05 },
            {13, 0.05 },
            {14, 0.01 }
        };
        private static readonly Dictionary<int, double> WeaponArmorProbabilities = new Dictionary<int, double>
        {
            {0, 1 },
            {1, 1 },
            {2, 1 },
            {3, 1 },
            {4, 1 },
            {5, 0.9 },
            {6, 0.8 },
            {7, 0.7 },
            {8, 0.6 },
            {9, 0.5 },
            {10, 0.2 }, 
            {11, 0.1 }, 
        };

        public int Level { get; set; }
        public bool UseSpCard { get; set;  }
        public bool Use15Booster { get; set; }
        public bool UseEProt { get; set; }
        public bool UseHProt { get; set; }

        public enum ItemType { WeaponArmor, LegendArmor, LegendWeapon};

        public double GetDerivedProbability(int level, ItemType itemType)
        {
            if(itemType == ItemType.WeaponArmor) // weapon and armor
            {
                return WeaponArmorProbabilities[level] * (Use15Booster ? 1.15 : 1);
            }
            else if (itemType == ItemType.LegendArmor) // legend armor; enchant probabilities cannot be modified
            {
                return LegendArmorProbabilities[level];
            }
            
            else // legend weapon
            {
                return LegendWeaponProbabilities[level];
            }
        }        
    }    
}

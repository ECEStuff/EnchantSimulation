using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnchantSimulation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private readonly List<EnchantStrategy> Strategies = new List<EnchantStrategy>()
        {
            new EnchantStrategy
            {
                Name = "e10 Frugal",
                Description = "e10, using enchant cards only",
                StartingLevel = 0,
                TargetLevel = 10,
                Levels = new List<EnchantLevel>
                {
                    new EnchantLevel() {Level = 1, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 2, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 3, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 4, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 5, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 6, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 7, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 8, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 9, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 10, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                }
            },
            new EnchantStrategy
            {
                Name = "e11 Frugal",
                Description = "e11, using enchant cards only",
                StartingLevel = 0,
                TargetLevel = 11,
                Levels = new List<EnchantLevel>
                {
                    new EnchantLevel() {Level = 1, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 2, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 3, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 4, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 5, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 6, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 7, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 8, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 9, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 10, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 11, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                }
            },
            new EnchantStrategy {
                Name = "Standard e10",
                Description = "e10 using Eprots only.",
                StartingLevel = 0,
                TargetLevel = 10,
                Levels = new List<EnchantLevel>
                {
                    new EnchantLevel() {Level = 1, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 2, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 3, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 4, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 5, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 6, Use15Booster = false, UseEProt = true, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 7, Use15Booster = false, UseEProt = true, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 8, Use15Booster = false, UseEProt = true, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 9, Use15Booster = false, UseEProt = true, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 10, Use15Booster = false, UseEProt = true, UseHProt = false, UseSpCard = false},
                }
            },
            new EnchantStrategy {
                Name = "Standard e11",
                Description = "e11 using Eprots only.",
                StartingLevel = 0,
                TargetLevel = 11,
                Levels = new List<EnchantLevel>
                {
                    new EnchantLevel() {Level = 1, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 2, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 3, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 4, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 5, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 6, Use15Booster = false, UseEProt = true, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 7, Use15Booster = false, UseEProt = true, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 8, Use15Booster = false, UseEProt = true, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 9, Use15Booster = false, UseEProt = true, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 10, Use15Booster = false, UseEProt = true, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 11, Use15Booster = false, UseEProt = true, UseHProt = false, UseSpCard = false},
                }
            },
            new EnchantStrategy
            {
                Name = "Standard e12",
                Description = "e12, using Eprots only",
                StartingLevel = 0,
                TargetLevel = 12,
                Levels = new List<EnchantLevel>
                {
                    new EnchantLevel() {Level = 1, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 2, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 3, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 4, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 5, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 6, Use15Booster = false, UseEProt = true, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 7, Use15Booster = false, UseEProt = true, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 8, Use15Booster = false, UseEProt = true, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 9, Use15Booster = false, UseEProt = true, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 10, Use15Booster = false, UseEProt = true, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 11, Use15Booster = false, UseEProt = true, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 12, Use15Booster = false, UseEProt = true, UseHProt = false, UseSpCard = false},
                }
            },
            new EnchantStrategy
            {
                Name = "S-5 Legend Armor",
                Description = "S-5 (level 5) legend armor. Note: does not include mineral cost; use enchant card cost for Metamorphose Mixtures.",
                StartingLevel = 0,
                TargetLevel = 5,
                ItemType = EnchantLevel.ItemType.LegendArmor,
                Levels = new List<EnchantLevel>
                {
                    new EnchantLevel() {Level = 1, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 2, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 3, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 4, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 5, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                }
            },
            new EnchantStrategy
            {
                Name = "Belpegore Legend Weapon",
                Description = "Belpegore (level 7) legend weapon; use enchant card cost for Soul of Laplaces.",
                StartingLevel = 0,
                TargetLevel = 7,
                ItemType = EnchantLevel.ItemType.LegendWeapon,
                Levels = new List<EnchantLevel>
                {
                    new EnchantLevel() {Level = 1, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 2, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 3, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 4, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 5, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 6, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 7, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                }
            },
            new EnchantStrategy
            {
                Name = "Custom",
                Description = "Define your own enchant strategy.",
                StartingLevel = 0,
                TargetLevel = 11,
                Levels = new List<EnchantLevel>
                {
                    new EnchantLevel() {Level = 1, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 2, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 3, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 4, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 5, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 6, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 7, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 8, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 9, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 10, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 11, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                    new EnchantLevel() {Level = 12, Use15Booster = false, UseEProt = false, UseHProt = false, UseSpCard = false},
                }
            }
        };

        private void MainForm_Load(object sender, EventArgs e)
        {
            //lvStrategy.Items.Add(new ListViewItem(new[] { "1", "Truth", "False" }));     
            //dgvStrategy.DataSource = e12Frugal.Levels;                
            cbStrategy.DataSource = Strategies;
            cbStrategy.SelectedIndex = 0;
        }

        private void cbStrategy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex >= 0)
            {
                EnchantStrategy selected = (cbStrategy.SelectedItem as EnchantStrategy);
                lblStrategyDescription.Text = selected.Description;
                dgvStrategy.DataSource = selected.Levels;
                dgvStrategy.ReadOnly = !(selected.Name == "Custom");
                txtTargetLevel.Text = Convert.ToString(selected.TargetLevel);
                txtTargetLevel.Enabled = (selected.Name == "Custom");
                txtSimulations.Text = Convert.ToString(selected.Simulations);
                txtSimulations.Enabled = (selected.Name == "Custom");
                txtStartingLevel.Text = Convert.ToString(selected.StartingLevel);
                txtStartingLevel.Enabled = (selected.Name == "Custom");

                rbLegArmor.Checked = (selected.ItemType == EnchantLevel.ItemType.LegendArmor);
                rbWeaponArmor.Checked = (selected.ItemType == EnchantLevel.ItemType.WeaponArmor);
                rbLegWeapon.Checked = (selected.ItemType == EnchantLevel.ItemType.LegendWeapon);
            }
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            if (cbStrategy.SelectedIndex >= 0)
            {
                EnchantStrategy selected = (cbStrategy.SelectedItem as EnchantStrategy);
                bool valid = true;
                string message = string.Empty;

                int slevel = 0, tlevel = 0, sims = 0;
                double ccost = 0, hccost = 0, b15cost = 0, epcost = 0, hpcost = 0, bookcost = 0, lv1Prob = 0, itemcost = 0, spcardcost = 0;

                if (!int.TryParse(txtStartingLevel.Text, out slevel))
                {
                    valid = false;
                    message += "Starting Level must be a number." + Environment.NewLine;
                }
                if (!int.TryParse(txtTargetLevel.Text, out tlevel))
                {
                    valid = false;
                    message += "Target Level must be a number." + Environment.NewLine;
                }
                if(!int.TryParse(txtSimulations.Text, out sims))
                {
                    valid = false;
                    message += "Simulations must be a number." + Environment.NewLine;
                }
                if (!double.TryParse(txtEnchantCardCost.Text, out ccost))
                {
                    valid = false;
                    message += "Enchant Card Cost must be a number." + Environment.NewLine;
                }
                if (!double.TryParse(txtHyperEnchantCardCost.Text, out hccost))
                {
                    valid = false;
                    message += "Hyper Enchant Card Cost must be a number." + Environment.NewLine;
                }
                if (!double.TryParse(txt15BoosterCost.Text, out b15cost))
                {
                    valid = false;
                    message += "15% Booster Cost must be a number." + Environment.NewLine;
                }
                if (!double.TryParse(txtEProtCost.Text, out epcost))
                {
                    valid = false;
                    message += "Enchant Protect Cost must be a number." + Environment.NewLine;
                }
                if (!double.TryParse(txtHProtCost.Text, out hpcost))
                {
                    valid = false;
                    message += "Hyper Protect Cost must be a number." + Environment.NewLine;
                }
                if (!double.TryParse(txtBookCost.Text, out bookcost))
                {
                    valid = false;
                    message += "Book Cost must be a number." + Environment.NewLine;
                }
                if (!double.TryParse(txtItemCost.Text, out itemcost))
                {
                    valid = false;
                    message += "Item Cost must be a number." + Environment.NewLine;
                }
                if (!double.TryParse(txtL1Prob.Text, out lv1Prob))
                {               
                    valid = false;
                    message += "Level 1 legend probability must be a number." + Environment.NewLine;
                }

                if (!double.TryParse(txtSpCardCost.Text, out spcardcost))
                {
                    valid = false;
                    message += "Special Enchant Card Cost must be a number." + Environment.NewLine;
                }

                if (lv1Prob < 0 || lv1Prob > 1)
                {
                    valid = false;
                    message += "Level 1 legend probability must be between 0 and 1 inclusive." + Environment.NewLine;
                }

                if (valid)
                {
                    selected.StartingLevel = slevel;
                    selected.TargetLevel = tlevel;
                    selected.Simulations = sims;
                    
                    if (rbLegArmor.Checked)
                    {
                        selected.ItemType = EnchantLevel.ItemType.LegendArmor;
                    }

                    else if (rbLegWeapon.Checked) 
                    {
                        selected.ItemType = EnchantLevel.ItemType.LegendWeapon;
                    }

                    else
                    {
                        selected.ItemType = EnchantLevel.ItemType.WeaponArmor;
                    }
                    
                    //selected.ItemType = (rbLegArmor.Checked ? EnchantLevel.ItemType.LegendArmor : EnchantLevel.ItemType.WeaponArmor);

                    selected.CalculateFrequencies(lv1Prob);

                    MessageBox.Show(selected.GenerateReport(ccost, hccost, b15cost, epcost, hpcost, bookcost, itemcost, spcardcost), "Results");
                }
                
            }
        }
    }
}

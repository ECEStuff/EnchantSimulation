namespace EnchantSimulation
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvStrategy = new System.Windows.Forms.DataGridView();
            this.lblStrategy = new System.Windows.Forms.Label();
            this.txtEnchantCardCost = new System.Windows.Forms.TextBox();
            this.lblEnchantCardCost = new System.Windows.Forms.Label();
            this.lbl15BoosterCost = new System.Windows.Forms.Label();
            this.txt15BoosterCost = new System.Windows.Forms.TextBox();
            this.lblCostInstructions = new System.Windows.Forms.Label();
            this.lblHProtCost = new System.Windows.Forms.Label();
            this.txtHProtCost = new System.Windows.Forms.TextBox();
            this.lblEProtCost = new System.Windows.Forms.Label();
            this.txtEProtCost = new System.Windows.Forms.TextBox();
            this.cbStrategy = new System.Windows.Forms.ComboBox();
            this.lblStrategyDescription = new System.Windows.Forms.Label();
            this.lblTargetLevel = new System.Windows.Forms.Label();
            this.txtTargetLevel = new System.Windows.Forms.TextBox();
            this.lblSimulations = new System.Windows.Forms.Label();
            this.txtSimulations = new System.Windows.Forms.TextBox();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.lblStartingLevel = new System.Windows.Forms.Label();
            this.txtStartingLevel = new System.Windows.Forms.TextBox();
            this.equipmentTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.rbLegWeapon = new System.Windows.Forms.RadioButton();
            this.rbLegArmor = new System.Windows.Forms.RadioButton();
            this.rbWeaponArmor = new System.Windows.Forms.RadioButton();
            this.lblBookCost = new System.Windows.Forms.Label();
            this.txtBookCost = new System.Windows.Forms.TextBox();
            this.lbL1Prob = new System.Windows.Forms.Label();
            this.txtL1Prob = new System.Windows.Forms.TextBox();
            this.lblItemCost = new System.Windows.Forms.Label();
            this.txtItemCost = new System.Windows.Forms.TextBox();
            this.txtSpCardCost = new System.Windows.Forms.TextBox();
            this.lblSpCardCost = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Use15Booster = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UseEProt = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UseHProt = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UseSpCard = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblHypCardCost = new System.Windows.Forms.Label();
            this.txtHyperEnchantCardCost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStrategy)).BeginInit();
            this.equipmentTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStrategy
            // 
            this.dgvStrategy.AllowUserToAddRows = false;
            this.dgvStrategy.AllowUserToDeleteRows = false;
            this.dgvStrategy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStrategy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Level,
            this.Use15Booster,
            this.UseEProt,
            this.UseHProt,
            this.UseSpCard});
            this.dgvStrategy.Location = new System.Drawing.Point(15, 124);
            this.dgvStrategy.MultiSelect = false;
            this.dgvStrategy.Name = "dgvStrategy";
            this.dgvStrategy.ReadOnly = true;
            this.dgvStrategy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStrategy.Size = new System.Drawing.Size(400, 294);
            this.dgvStrategy.TabIndex = 1;
            // 
            // lblStrategy
            // 
            this.lblStrategy.AutoSize = true;
            this.lblStrategy.Location = new System.Drawing.Point(9, 9);
            this.lblStrategy.Name = "lblStrategy";
            this.lblStrategy.Size = new System.Drawing.Size(49, 13);
            this.lblStrategy.TabIndex = 2;
            this.lblStrategy.Text = "Strategy:";
            // 
            // txtEnchantCardCost
            // 
            this.txtEnchantCardCost.Location = new System.Drawing.Point(600, 150);
            this.txtEnchantCardCost.Name = "txtEnchantCardCost";
            this.txtEnchantCardCost.Size = new System.Drawing.Size(100, 20);
            this.txtEnchantCardCost.TabIndex = 3;
            this.txtEnchantCardCost.Text = "200000";
            // 
            // lblEnchantCardCost
            // 
            this.lblEnchantCardCost.AutoSize = true;
            this.lblEnchantCardCost.Location = new System.Drawing.Point(451, 153);
            this.lblEnchantCardCost.Name = "lblEnchantCardCost";
            this.lblEnchantCardCost.Size = new System.Drawing.Size(96, 13);
            this.lblEnchantCardCost.TabIndex = 4;
            this.lblEnchantCardCost.Text = "Enchant Card Cost";
            // 
            // lbl15BoosterCost
            // 
            this.lbl15BoosterCost.AutoSize = true;
            this.lbl15BoosterCost.Location = new System.Drawing.Point(451, 230);
            this.lbl15BoosterCost.Name = "lbl15BoosterCost";
            this.lbl15BoosterCost.Size = new System.Drawing.Size(90, 13);
            this.lbl15BoosterCost.TabIndex = 8;
            this.lbl15BoosterCost.Text = "15% Booster Cost";
            // 
            // txt15BoosterCost
            // 
            this.txt15BoosterCost.Location = new System.Drawing.Point(600, 227);
            this.txt15BoosterCost.Name = "txt15BoosterCost";
            this.txt15BoosterCost.Size = new System.Drawing.Size(100, 20);
            this.txt15BoosterCost.TabIndex = 7;
            this.txt15BoosterCost.Text = "35000000";
            // 
            // lblCostInstructions
            // 
            this.lblCostInstructions.AutoSize = true;
            this.lblCostInstructions.Location = new System.Drawing.Point(451, 124);
            this.lblCostInstructions.Name = "lblCostInstructions";
            this.lblCostInstructions.Size = new System.Drawing.Size(363, 13);
            this.lblCostInstructions.TabIndex = 11;
            this.lblCostInstructions.Text = "Costs can be in WP, SPI, Credits, or $, as long as consistent units are used.";
            // 
            // lblHProtCost
            // 
            this.lblHProtCost.AutoSize = true;
            this.lblHProtCost.Location = new System.Drawing.Point(451, 286);
            this.lblHProtCost.Name = "lblHProtCost";
            this.lblHProtCost.Size = new System.Drawing.Size(96, 13);
            this.lblHProtCost.TabIndex = 15;
            this.lblHProtCost.Text = "Hyper Protect Cost";
            // 
            // txtHProtCost
            // 
            this.txtHProtCost.Location = new System.Drawing.Point(600, 283);
            this.txtHProtCost.Name = "txtHProtCost";
            this.txtHProtCost.Size = new System.Drawing.Size(100, 20);
            this.txtHProtCost.TabIndex = 14;
            this.txtHProtCost.Text = "250000000";
            // 
            // lblEProtCost
            // 
            this.lblEProtCost.AutoSize = true;
            this.lblEProtCost.Location = new System.Drawing.Point(451, 260);
            this.lblEProtCost.Name = "lblEProtCost";
            this.lblEProtCost.Size = new System.Drawing.Size(108, 13);
            this.lblEProtCost.TabIndex = 13;
            this.lblEProtCost.Text = "Enchant Protect Cost";
            // 
            // txtEProtCost
            // 
            this.txtEProtCost.Location = new System.Drawing.Point(600, 257);
            this.txtEProtCost.Name = "txtEProtCost";
            this.txtEProtCost.Size = new System.Drawing.Size(100, 20);
            this.txtEProtCost.TabIndex = 12;
            this.txtEProtCost.Text = "500000";
            // 
            // cbStrategy
            // 
            this.cbStrategy.DisplayMember = "Name";
            this.cbStrategy.FormattingEnabled = true;
            this.cbStrategy.Location = new System.Drawing.Point(64, 6);
            this.cbStrategy.Name = "cbStrategy";
            this.cbStrategy.Size = new System.Drawing.Size(121, 21);
            this.cbStrategy.TabIndex = 16;
            this.cbStrategy.SelectedIndexChanged += new System.EventHandler(this.cbStrategy_SelectedIndexChanged);
            // 
            // lblStrategyDescription
            // 
            this.lblStrategyDescription.AutoSize = true;
            this.lblStrategyDescription.Location = new System.Drawing.Point(191, 9);
            this.lblStrategyDescription.Name = "lblStrategyDescription";
            this.lblStrategyDescription.Size = new System.Drawing.Size(32, 13);
            this.lblStrategyDescription.TabIndex = 17;
            this.lblStrategyDescription.Text = "Desc";
            // 
            // lblTargetLevel
            // 
            this.lblTargetLevel.AutoSize = true;
            this.lblTargetLevel.Location = new System.Drawing.Point(133, 46);
            this.lblTargetLevel.Name = "lblTargetLevel";
            this.lblTargetLevel.Size = new System.Drawing.Size(70, 13);
            this.lblTargetLevel.TabIndex = 18;
            this.lblTargetLevel.Text = "Target Level:";
            // 
            // txtTargetLevel
            // 
            this.txtTargetLevel.Enabled = false;
            this.txtTargetLevel.Location = new System.Drawing.Point(209, 43);
            this.txtTargetLevel.MaxLength = 2;
            this.txtTargetLevel.Name = "txtTargetLevel";
            this.txtTargetLevel.Size = new System.Drawing.Size(29, 20);
            this.txtTargetLevel.TabIndex = 19;
            // 
            // lblSimulations
            // 
            this.lblSimulations.AutoSize = true;
            this.lblSimulations.Location = new System.Drawing.Point(244, 46);
            this.lblSimulations.Name = "lblSimulations";
            this.lblSimulations.Size = new System.Drawing.Size(63, 13);
            this.lblSimulations.TabIndex = 20;
            this.lblSimulations.Text = "Simulations:";
            // 
            // txtSimulations
            // 
            this.txtSimulations.Location = new System.Drawing.Point(313, 43);
            this.txtSimulations.MaxLength = 10;
            this.txtSimulations.Name = "txtSimulations";
            this.txtSimulations.Size = new System.Drawing.Size(57, 20);
            this.txtSimulations.TabIndex = 21;
            // 
            // btnSimulate
            // 
            this.btnSimulate.Location = new System.Drawing.Point(584, 404);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(75, 23);
            this.btnSimulate.TabIndex = 22;
            this.btnSimulate.Text = "Simulate!";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // lblStartingLevel
            // 
            this.lblStartingLevel.AutoSize = true;
            this.lblStartingLevel.Location = new System.Drawing.Point(12, 46);
            this.lblStartingLevel.Name = "lblStartingLevel";
            this.lblStartingLevel.Size = new System.Drawing.Size(75, 13);
            this.lblStartingLevel.TabIndex = 23;
            this.lblStartingLevel.Text = "Starting Level:";
            // 
            // txtStartingLevel
            // 
            this.txtStartingLevel.Enabled = false;
            this.txtStartingLevel.Location = new System.Drawing.Point(98, 43);
            this.txtStartingLevel.MaxLength = 2;
            this.txtStartingLevel.Name = "txtStartingLevel";
            this.txtStartingLevel.Size = new System.Drawing.Size(29, 20);
            this.txtStartingLevel.TabIndex = 24;
            // 
            // equipmentTypeGroupBox
            // 
            this.equipmentTypeGroupBox.Controls.Add(this.rbLegWeapon);
            this.equipmentTypeGroupBox.Controls.Add(this.rbLegArmor);
            this.equipmentTypeGroupBox.Controls.Add(this.rbWeaponArmor);
            this.equipmentTypeGroupBox.Location = new System.Drawing.Point(12, 69);
            this.equipmentTypeGroupBox.Name = "equipmentTypeGroupBox";
            this.equipmentTypeGroupBox.Size = new System.Drawing.Size(403, 45);
            this.equipmentTypeGroupBox.TabIndex = 25;
            this.equipmentTypeGroupBox.TabStop = false;
            this.equipmentTypeGroupBox.Text = "Equipment Type";
            // 
            // rbLegWeapon
            // 
            this.rbLegWeapon.AutoSize = true;
            this.rbLegWeapon.Location = new System.Drawing.Point(268, 19);
            this.rbLegWeapon.Name = "rbLegWeapon";
            this.rbLegWeapon.Size = new System.Drawing.Size(105, 17);
            this.rbLegWeapon.TabIndex = 2;
            this.rbLegWeapon.TabStop = true;
            this.rbLegWeapon.Text = "Legend Weapon";
            this.rbLegWeapon.UseVisualStyleBackColor = true;
            // 
            // rbLegArmor
            // 
            this.rbLegArmor.AutoSize = true;
            this.rbLegArmor.Location = new System.Drawing.Point(141, 19);
            this.rbLegArmor.Name = "rbLegArmor";
            this.rbLegArmor.Size = new System.Drawing.Size(91, 17);
            this.rbLegArmor.TabIndex = 1;
            this.rbLegArmor.TabStop = true;
            this.rbLegArmor.Text = "Legend Armor";
            this.rbLegArmor.UseVisualStyleBackColor = true;
            // 
            // rbWeaponArmor
            // 
            this.rbWeaponArmor.AutoSize = true;
            this.rbWeaponArmor.Checked = true;
            this.rbWeaponArmor.Location = new System.Drawing.Point(19, 19);
            this.rbWeaponArmor.Name = "rbWeaponArmor";
            this.rbWeaponArmor.Size = new System.Drawing.Size(98, 17);
            this.rbWeaponArmor.TabIndex = 0;
            this.rbWeaponArmor.TabStop = true;
            this.rbWeaponArmor.Text = "Weapon/Armor";
            this.rbWeaponArmor.UseVisualStyleBackColor = true;
            // 
            // lblBookCost
            // 
            this.lblBookCost.AutoSize = true;
            this.lblBookCost.Location = new System.Drawing.Point(451, 312);
            this.lblBookCost.Name = "lblBookCost";
            this.lblBookCost.Size = new System.Drawing.Size(101, 13);
            this.lblBookCost.TabIndex = 26;
            this.lblBookCost.Text = "Bible/Scripture Cost";
            // 
            // txtBookCost
            // 
            this.txtBookCost.Location = new System.Drawing.Point(600, 309);
            this.txtBookCost.Name = "txtBookCost";
            this.txtBookCost.Size = new System.Drawing.Size(100, 20);
            this.txtBookCost.TabIndex = 27;
            this.txtBookCost.Text = "15000000";
            // 
            // lbL1Prob
            // 
            this.lbL1Prob.AutoSize = true;
            this.lbL1Prob.Location = new System.Drawing.Point(451, 338);
            this.lbL1Prob.Name = "lbL1Prob";
            this.lbL1Prob.Size = new System.Drawing.Size(115, 13);
            this.lbL1Prob.TabIndex = 30;
            this.lbL1Prob.Text = "Lv1 Legend Probability";
            // 
            // txtL1Prob
            // 
            this.txtL1Prob.Location = new System.Drawing.Point(600, 335);
            this.txtL1Prob.Name = "txtL1Prob";
            this.txtL1Prob.Size = new System.Drawing.Size(100, 20);
            this.txtL1Prob.TabIndex = 31;
            this.txtL1Prob.Text = "1";
            // 
            // lblItemCost
            // 
            this.lblItemCost.AutoSize = true;
            this.lblItemCost.Location = new System.Drawing.Point(451, 364);
            this.lblItemCost.Name = "lblItemCost";
            this.lblItemCost.Size = new System.Drawing.Size(51, 13);
            this.lblItemCost.TabIndex = 32;
            this.lblItemCost.Text = "Item Cost";
            // 
            // txtItemCost
            // 
            this.txtItemCost.Location = new System.Drawing.Point(600, 361);
            this.txtItemCost.Name = "txtItemCost";
            this.txtItemCost.Size = new System.Drawing.Size(100, 20);
            this.txtItemCost.TabIndex = 33;
            this.txtItemCost.Text = "0";
            // 
            // txtSpCardCost
            // 
            this.txtSpCardCost.Location = new System.Drawing.Point(600, 200);
            this.txtSpCardCost.Name = "txtSpCardCost";
            this.txtSpCardCost.Size = new System.Drawing.Size(100, 20);
            this.txtSpCardCost.TabIndex = 34;
            this.txtSpCardCost.Text = "12000000";
            // 
            // lblSpCardCost
            // 
            this.lblSpCardCost.AutoSize = true;
            this.lblSpCardCost.Location = new System.Drawing.Point(451, 203);
            this.lblSpCardCost.Name = "lblSpCardCost";
            this.lblSpCardCost.Size = new System.Drawing.Size(134, 13);
            this.lblSpCardCost.TabIndex = 35;
            this.lblSpCardCost.Text = "Special Enchant Card Cost";
            // 
            // Level
            // 
            this.Level.DataPropertyName = "Level";
            this.Level.HeaderText = "Level";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.Width = 50;
            // 
            // Use15Booster
            // 
            this.Use15Booster.DataPropertyName = "Use15Booster";
            this.Use15Booster.HeaderText = "15% Booster?";
            this.Use15Booster.Name = "Use15Booster";
            this.Use15Booster.ReadOnly = true;
            this.Use15Booster.Width = 80;
            // 
            // UseEProt
            // 
            this.UseEProt.DataPropertyName = "UseEProt";
            this.UseEProt.HeaderText = "E-Prot?";
            this.UseEProt.Name = "UseEProt";
            this.UseEProt.ReadOnly = true;
            this.UseEProt.Width = 50;
            // 
            // UseHProt
            // 
            this.UseHProt.DataPropertyName = "UseHProt";
            this.UseHProt.HeaderText = "H-Prot?";
            this.UseHProt.Name = "UseHProt";
            this.UseHProt.ReadOnly = true;
            this.UseHProt.Width = 50;
            // 
            // UseSpCard
            // 
            this.UseSpCard.DataPropertyName = "UseSpCard";
            this.UseSpCard.HeaderText = "Special Card?";
            this.UseSpCard.Name = "UseSpCard";
            this.UseSpCard.ReadOnly = true;
            this.UseSpCard.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UseSpCard.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblHypCardCost
            // 
            this.lblHypCardCost.AutoSize = true;
            this.lblHypCardCost.Location = new System.Drawing.Point(451, 179);
            this.lblHypCardCost.Name = "lblHypCardCost";
            this.lblHypCardCost.Size = new System.Drawing.Size(127, 13);
            this.lblHypCardCost.TabIndex = 37;
            this.lblHypCardCost.Text = "Hyper Enchant Card Cost";
            // 
            // txtHyperEnchantCardCost
            // 
            this.txtHyperEnchantCardCost.Location = new System.Drawing.Point(600, 176);
            this.txtHyperEnchantCardCost.Name = "txtHyperEnchantCardCost";
            this.txtHyperEnchantCardCost.Size = new System.Drawing.Size(100, 20);
            this.txtHyperEnchantCardCost.TabIndex = 36;
            this.txtHyperEnchantCardCost.Text = "2000";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 581);
            this.Controls.Add(this.lblHypCardCost);
            this.Controls.Add(this.txtHyperEnchantCardCost);
            this.Controls.Add(this.lblSpCardCost);
            this.Controls.Add(this.txtSpCardCost);
            this.Controls.Add(this.txtItemCost);
            this.Controls.Add(this.lblItemCost);
            this.Controls.Add(this.txtL1Prob);
            this.Controls.Add(this.lbL1Prob);
            this.Controls.Add(this.txtBookCost);
            this.Controls.Add(this.lblBookCost);
            this.Controls.Add(this.equipmentTypeGroupBox);
            this.Controls.Add(this.txtStartingLevel);
            this.Controls.Add(this.lblStartingLevel);
            this.Controls.Add(this.btnSimulate);
            this.Controls.Add(this.txtSimulations);
            this.Controls.Add(this.lblSimulations);
            this.Controls.Add(this.txtTargetLevel);
            this.Controls.Add(this.lblTargetLevel);
            this.Controls.Add(this.lblStrategyDescription);
            this.Controls.Add(this.cbStrategy);
            this.Controls.Add(this.lblHProtCost);
            this.Controls.Add(this.txtHProtCost);
            this.Controls.Add(this.lblEProtCost);
            this.Controls.Add(this.txtEProtCost);
            this.Controls.Add(this.lblCostInstructions);
            this.Controls.Add(this.lbl15BoosterCost);
            this.Controls.Add(this.txt15BoosterCost);
            this.Controls.Add(this.lblEnchantCardCost);
            this.Controls.Add(this.txtEnchantCardCost);
            this.Controls.Add(this.lblStrategy);
            this.Controls.Add(this.dgvStrategy);
            this.Name = "MainForm";
            this.Text = "Enchant Simulation";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStrategy)).EndInit();
            this.equipmentTypeGroupBox.ResumeLayout(false);
            this.equipmentTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStrategy;
        private System.Windows.Forms.Label lblStrategy;
        private System.Windows.Forms.TextBox txtEnchantCardCost;
        private System.Windows.Forms.Label lblEnchantCardCost;
        private System.Windows.Forms.Label lbl15BoosterCost;
        private System.Windows.Forms.TextBox txt15BoosterCost;
        private System.Windows.Forms.Label lblCostInstructions;
        private System.Windows.Forms.Label lblHProtCost;
        private System.Windows.Forms.TextBox txtHProtCost;
        private System.Windows.Forms.Label lblEProtCost;
        private System.Windows.Forms.TextBox txtEProtCost;
        private System.Windows.Forms.ComboBox cbStrategy;
        private System.Windows.Forms.Label lblStrategyDescription;
        private System.Windows.Forms.Label lblTargetLevel;
        private System.Windows.Forms.TextBox txtTargetLevel;
        private System.Windows.Forms.Label lblSimulations;
        private System.Windows.Forms.TextBox txtSimulations;
        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.Label lblStartingLevel;
        private System.Windows.Forms.TextBox txtStartingLevel;
        private System.Windows.Forms.GroupBox equipmentTypeGroupBox;
        private System.Windows.Forms.RadioButton rbLegArmor;
        private System.Windows.Forms.RadioButton rbWeaponArmor;
        private System.Windows.Forms.RadioButton rbLegWeapon;
        private System.Windows.Forms.Label lblBookCost;
        private System.Windows.Forms.TextBox txtBookCost;
        private System.Windows.Forms.Label lbL1Prob;
        private System.Windows.Forms.TextBox txtL1Prob;
        private System.Windows.Forms.Label lblItemCost;
        private System.Windows.Forms.TextBox txtItemCost;
        private System.Windows.Forms.TextBox txtSpCardCost;
        private System.Windows.Forms.Label lblSpCardCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Use15Booster;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UseEProt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UseHProt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UseSpCard;
        private System.Windows.Forms.Label lblHypCardCost;
        private System.Windows.Forms.TextBox txtHyperEnchantCardCost;
    }
}
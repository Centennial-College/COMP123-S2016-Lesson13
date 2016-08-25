namespace COMP123_S2016_Lesson13
{
    partial class GeneratorForm
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
            this.AbilityGroupBox = new System.Windows.Forms.GroupBox();
            this.ChaTextBox = new System.Windows.Forms.TextBox();
            this.ChaLabel = new System.Windows.Forms.Label();
            this.WisTextBox = new System.Windows.Forms.TextBox();
            this.WisLabel = new System.Windows.Forms.Label();
            this.IntTextBox = new System.Windows.Forms.TextBox();
            this.IntLabel = new System.Windows.Forms.Label();
            this.ConTextBox = new System.Windows.Forms.TextBox();
            this.ConLabel = new System.Windows.Forms.Label();
            this.DexTextBox = new System.Windows.Forms.TextBox();
            this.DexLabel = new System.Windows.Forms.Label();
            this.StrTextBox = new System.Windows.Forms.TextBox();
            this.StrLabel = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.SwapGroupBox = new System.Windows.Forms.GroupBox();
            this.FirstAbilityComboBox = new System.Windows.Forms.ComboBox();
            this.FirstAbilityLabel = new System.Windows.Forms.Label();
            this.SecondAbilityLabel = new System.Windows.Forms.Label();
            this.SecondAbilityComboBox = new System.Windows.Forms.ComboBox();
            this.SwapButton = new System.Windows.Forms.Button();
            this.AbilityGroupBox.SuspendLayout();
            this.SwapGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AbilityGroupBox
            // 
            this.AbilityGroupBox.Controls.Add(this.ChaTextBox);
            this.AbilityGroupBox.Controls.Add(this.ChaLabel);
            this.AbilityGroupBox.Controls.Add(this.WisTextBox);
            this.AbilityGroupBox.Controls.Add(this.WisLabel);
            this.AbilityGroupBox.Controls.Add(this.IntTextBox);
            this.AbilityGroupBox.Controls.Add(this.IntLabel);
            this.AbilityGroupBox.Controls.Add(this.ConTextBox);
            this.AbilityGroupBox.Controls.Add(this.ConLabel);
            this.AbilityGroupBox.Controls.Add(this.DexTextBox);
            this.AbilityGroupBox.Controls.Add(this.DexLabel);
            this.AbilityGroupBox.Controls.Add(this.StrTextBox);
            this.AbilityGroupBox.Controls.Add(this.StrLabel);
            this.AbilityGroupBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbilityGroupBox.Location = new System.Drawing.Point(12, 12);
            this.AbilityGroupBox.Name = "AbilityGroupBox";
            this.AbilityGroupBox.Size = new System.Drawing.Size(133, 386);
            this.AbilityGroupBox.TabIndex = 0;
            this.AbilityGroupBox.TabStop = false;
            this.AbilityGroupBox.Text = "Abilities";
            // 
            // ChaTextBox
            // 
            this.ChaTextBox.BackColor = System.Drawing.Color.White;
            this.ChaTextBox.Location = new System.Drawing.Point(6, 348);
            this.ChaTextBox.Name = "ChaTextBox";
            this.ChaTextBox.ReadOnly = true;
            this.ChaTextBox.Size = new System.Drawing.Size(75, 26);
            this.ChaTextBox.TabIndex = 11;
            this.ChaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChaLabel
            // 
            this.ChaLabel.AutoSize = true;
            this.ChaLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChaLabel.Location = new System.Drawing.Point(6, 322);
            this.ChaLabel.Name = "ChaLabel";
            this.ChaLabel.Size = new System.Drawing.Size(82, 18);
            this.ChaLabel.TabIndex = 10;
            this.ChaLabel.Text = "Charisma";
            // 
            // WisTextBox
            // 
            this.WisTextBox.BackColor = System.Drawing.Color.White;
            this.WisTextBox.Location = new System.Drawing.Point(6, 288);
            this.WisTextBox.Name = "WisTextBox";
            this.WisTextBox.ReadOnly = true;
            this.WisTextBox.Size = new System.Drawing.Size(75, 26);
            this.WisTextBox.TabIndex = 9;
            this.WisTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WisLabel
            // 
            this.WisLabel.AutoSize = true;
            this.WisLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WisLabel.Location = new System.Drawing.Point(6, 262);
            this.WisLabel.Name = "WisLabel";
            this.WisLabel.Size = new System.Drawing.Size(69, 18);
            this.WisLabel.TabIndex = 8;
            this.WisLabel.Text = "Wisdom";
            // 
            // IntTextBox
            // 
            this.IntTextBox.BackColor = System.Drawing.Color.White;
            this.IntTextBox.Location = new System.Drawing.Point(6, 228);
            this.IntTextBox.Name = "IntTextBox";
            this.IntTextBox.ReadOnly = true;
            this.IntTextBox.Size = new System.Drawing.Size(75, 26);
            this.IntTextBox.TabIndex = 7;
            this.IntTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IntLabel
            // 
            this.IntLabel.AutoSize = true;
            this.IntLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntLabel.Location = new System.Drawing.Point(6, 202);
            this.IntLabel.Name = "IntLabel";
            this.IntLabel.Size = new System.Drawing.Size(102, 18);
            this.IntLabel.TabIndex = 6;
            this.IntLabel.Text = "Intelligence";
            // 
            // ConTextBox
            // 
            this.ConTextBox.BackColor = System.Drawing.Color.White;
            this.ConTextBox.Location = new System.Drawing.Point(6, 168);
            this.ConTextBox.Name = "ConTextBox";
            this.ConTextBox.ReadOnly = true;
            this.ConTextBox.Size = new System.Drawing.Size(75, 26);
            this.ConTextBox.TabIndex = 5;
            this.ConTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConLabel
            // 
            this.ConLabel.AutoSize = true;
            this.ConLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConLabel.Location = new System.Drawing.Point(6, 142);
            this.ConLabel.Name = "ConLabel";
            this.ConLabel.Size = new System.Drawing.Size(109, 18);
            this.ConLabel.TabIndex = 4;
            this.ConLabel.Text = "Constitution";
            // 
            // DexTextBox
            // 
            this.DexTextBox.BackColor = System.Drawing.Color.White;
            this.DexTextBox.Location = new System.Drawing.Point(6, 108);
            this.DexTextBox.Name = "DexTextBox";
            this.DexTextBox.ReadOnly = true;
            this.DexTextBox.Size = new System.Drawing.Size(75, 26);
            this.DexTextBox.TabIndex = 3;
            this.DexTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DexLabel
            // 
            this.DexLabel.AutoSize = true;
            this.DexLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DexLabel.Location = new System.Drawing.Point(6, 82);
            this.DexLabel.Name = "DexLabel";
            this.DexLabel.Size = new System.Drawing.Size(83, 18);
            this.DexLabel.TabIndex = 2;
            this.DexLabel.Text = "Dexterity";
            // 
            // StrTextBox
            // 
            this.StrTextBox.BackColor = System.Drawing.Color.White;
            this.StrTextBox.Location = new System.Drawing.Point(6, 48);
            this.StrTextBox.Name = "StrTextBox";
            this.StrTextBox.ReadOnly = true;
            this.StrTextBox.Size = new System.Drawing.Size(75, 26);
            this.StrTextBox.TabIndex = 1;
            this.StrTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StrLabel
            // 
            this.StrLabel.AutoSize = true;
            this.StrLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrLabel.Location = new System.Drawing.Point(6, 22);
            this.StrLabel.Name = "StrLabel";
            this.StrLabel.Size = new System.Drawing.Size(78, 18);
            this.StrLabel.TabIndex = 0;
            this.StrLabel.Text = "Strength";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateButton.Location = new System.Drawing.Point(318, 353);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(105, 37);
            this.GenerateButton.TabIndex = 1;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // SwapGroupBox
            // 
            this.SwapGroupBox.Controls.Add(this.SwapButton);
            this.SwapGroupBox.Controls.Add(this.SecondAbilityLabel);
            this.SwapGroupBox.Controls.Add(this.SecondAbilityComboBox);
            this.SwapGroupBox.Controls.Add(this.FirstAbilityLabel);
            this.SwapGroupBox.Controls.Add(this.FirstAbilityComboBox);
            this.SwapGroupBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwapGroupBox.Location = new System.Drawing.Point(151, 12);
            this.SwapGroupBox.Name = "SwapGroupBox";
            this.SwapGroupBox.Size = new System.Drawing.Size(272, 160);
            this.SwapGroupBox.TabIndex = 2;
            this.SwapGroupBox.TabStop = false;
            this.SwapGroupBox.Text = "Swap Abilities";
            // 
            // FirstAbilityComboBox
            // 
            this.FirstAbilityComboBox.BackColor = System.Drawing.Color.White;
            this.FirstAbilityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FirstAbilityComboBox.FormattingEnabled = true;
            this.FirstAbilityComboBox.Items.AddRange(new object[] {
            "Strength",
            "Dexterity",
            "Consitution",
            "Intelligence",
            "Wisdom",
            "Charisma"});
            this.FirstAbilityComboBox.Location = new System.Drawing.Point(6, 58);
            this.FirstAbilityComboBox.MaxDropDownItems = 6;
            this.FirstAbilityComboBox.Name = "FirstAbilityComboBox";
            this.FirstAbilityComboBox.Size = new System.Drawing.Size(121, 26);
            this.FirstAbilityComboBox.TabIndex = 0;
            this.FirstAbilityComboBox.SelectedIndexChanged += new System.EventHandler(this.FirstAbilityComboBox_SelectedIndexChanged);
            // 
            // FirstAbilityLabel
            // 
            this.FirstAbilityLabel.AutoSize = true;
            this.FirstAbilityLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstAbilityLabel.Location = new System.Drawing.Point(6, 22);
            this.FirstAbilityLabel.Name = "FirstAbilityLabel";
            this.FirstAbilityLabel.Size = new System.Drawing.Size(97, 18);
            this.FirstAbilityLabel.TabIndex = 3;
            this.FirstAbilityLabel.Text = "First Ability";
            // 
            // SecondAbilityLabel
            // 
            this.SecondAbilityLabel.AutoSize = true;
            this.SecondAbilityLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondAbilityLabel.Location = new System.Drawing.Point(138, 22);
            this.SecondAbilityLabel.Name = "SecondAbilityLabel";
            this.SecondAbilityLabel.Size = new System.Drawing.Size(122, 18);
            this.SecondAbilityLabel.TabIndex = 5;
            this.SecondAbilityLabel.Text = "Second Ability";
            // 
            // SecondAbilityComboBox
            // 
            this.SecondAbilityComboBox.BackColor = System.Drawing.Color.White;
            this.SecondAbilityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecondAbilityComboBox.FormattingEnabled = true;
            this.SecondAbilityComboBox.Items.AddRange(new object[] {
            "Strength",
            "Dexterity",
            "Consitution",
            "Intelligence",
            "Wisdom",
            "Charisma"});
            this.SecondAbilityComboBox.Location = new System.Drawing.Point(138, 58);
            this.SecondAbilityComboBox.MaxDropDownItems = 6;
            this.SecondAbilityComboBox.Name = "SecondAbilityComboBox";
            this.SecondAbilityComboBox.Size = new System.Drawing.Size(121, 26);
            this.SecondAbilityComboBox.TabIndex = 4;
            this.SecondAbilityComboBox.SelectedIndexChanged += new System.EventHandler(this.SecondAbilityComboBox_SelectedIndexChanged);
            // 
            // SwapButton
            // 
            this.SwapButton.Location = new System.Drawing.Point(155, 102);
            this.SwapButton.Name = "SwapButton";
            this.SwapButton.Size = new System.Drawing.Size(105, 37);
            this.SwapButton.TabIndex = 6;
            this.SwapButton.Text = "Swap";
            this.SwapButton.UseVisualStyleBackColor = true;
            this.SwapButton.Click += new System.EventHandler(this.SwapButton_Click);
            // 
            // GeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(438, 406);
            this.Controls.Add(this.SwapGroupBox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.AbilityGroupBox);
            this.Name = "GeneratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generator";
            this.Load += new System.EventHandler(this.GeneratorForm_Load);
            this.AbilityGroupBox.ResumeLayout(false);
            this.AbilityGroupBox.PerformLayout();
            this.SwapGroupBox.ResumeLayout(false);
            this.SwapGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AbilityGroupBox;
        private System.Windows.Forms.Label StrLabel;
        private System.Windows.Forms.TextBox StrTextBox;
        private System.Windows.Forms.TextBox ChaTextBox;
        private System.Windows.Forms.Label ChaLabel;
        private System.Windows.Forms.TextBox WisTextBox;
        private System.Windows.Forms.Label WisLabel;
        private System.Windows.Forms.TextBox IntTextBox;
        private System.Windows.Forms.Label IntLabel;
        private System.Windows.Forms.TextBox ConTextBox;
        private System.Windows.Forms.Label ConLabel;
        private System.Windows.Forms.TextBox DexTextBox;
        private System.Windows.Forms.Label DexLabel;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.GroupBox SwapGroupBox;
        private System.Windows.Forms.ComboBox FirstAbilityComboBox;
        private System.Windows.Forms.Label FirstAbilityLabel;
        private System.Windows.Forms.Label SecondAbilityLabel;
        private System.Windows.Forms.ComboBox SecondAbilityComboBox;
        private System.Windows.Forms.Button SwapButton;
    }
}


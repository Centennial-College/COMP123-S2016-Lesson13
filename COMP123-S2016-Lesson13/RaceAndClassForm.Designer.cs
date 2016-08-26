namespace COMP123_S2016_Lesson13
{
    partial class RaceAndClassForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.SelectRaceGroupBox = new System.Windows.Forms.GroupBox();
            this.HalflingRadioButton = new System.Windows.Forms.RadioButton();
            this.DwarfRadioButton = new System.Windows.Forms.RadioButton();
            this.ElfRadioButton = new System.Windows.Forms.RadioButton();
            this.HumanRadioButton = new System.Windows.Forms.RadioButton();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SelectClassGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.BardRadioButton = new System.Windows.Forms.RadioButton();
            this.SelectRaceGroupBox.SuspendLayout();
            this.SelectClassGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(12, 412);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(105, 37);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SelectRaceGroupBox
            // 
            this.SelectRaceGroupBox.Controls.Add(this.HalflingRadioButton);
            this.SelectRaceGroupBox.Controls.Add(this.DwarfRadioButton);
            this.SelectRaceGroupBox.Controls.Add(this.ElfRadioButton);
            this.SelectRaceGroupBox.Controls.Add(this.HumanRadioButton);
            this.SelectRaceGroupBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectRaceGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SelectRaceGroupBox.Name = "SelectRaceGroupBox";
            this.SelectRaceGroupBox.Size = new System.Drawing.Size(272, 160);
            this.SelectRaceGroupBox.TabIndex = 5;
            this.SelectRaceGroupBox.TabStop = false;
            this.SelectRaceGroupBox.Text = "Select Race";
            // 
            // HalflingRadioButton
            // 
            this.HalflingRadioButton.AutoSize = true;
            this.HalflingRadioButton.Location = new System.Drawing.Point(6, 106);
            this.HalflingRadioButton.Name = "HalflingRadioButton";
            this.HalflingRadioButton.Size = new System.Drawing.Size(82, 22);
            this.HalflingRadioButton.TabIndex = 3;
            this.HalflingRadioButton.Text = "Halfing";
            this.HalflingRadioButton.UseVisualStyleBackColor = true;
            this.HalflingRadioButton.CheckedChanged += new System.EventHandler(this.RaceRadioButton_CheckedChanged);
            // 
            // DwarfRadioButton
            // 
            this.DwarfRadioButton.AutoSize = true;
            this.DwarfRadioButton.Location = new System.Drawing.Point(6, 78);
            this.DwarfRadioButton.Name = "DwarfRadioButton";
            this.DwarfRadioButton.Size = new System.Drawing.Size(70, 22);
            this.DwarfRadioButton.TabIndex = 2;
            this.DwarfRadioButton.Text = "Dwarf";
            this.DwarfRadioButton.UseVisualStyleBackColor = true;
            this.DwarfRadioButton.CheckedChanged += new System.EventHandler(this.RaceRadioButton_CheckedChanged);
            // 
            // ElfRadioButton
            // 
            this.ElfRadioButton.AutoSize = true;
            this.ElfRadioButton.Location = new System.Drawing.Point(6, 50);
            this.ElfRadioButton.Name = "ElfRadioButton";
            this.ElfRadioButton.Size = new System.Drawing.Size(45, 22);
            this.ElfRadioButton.TabIndex = 1;
            this.ElfRadioButton.Text = "Elf";
            this.ElfRadioButton.UseVisualStyleBackColor = true;
            this.ElfRadioButton.CheckedChanged += new System.EventHandler(this.RaceRadioButton_CheckedChanged);
            // 
            // HumanRadioButton
            // 
            this.HumanRadioButton.AutoSize = true;
            this.HumanRadioButton.Checked = true;
            this.HumanRadioButton.Location = new System.Drawing.Point(6, 22);
            this.HumanRadioButton.Name = "HumanRadioButton";
            this.HumanRadioButton.Size = new System.Drawing.Size(79, 22);
            this.HumanRadioButton.TabIndex = 0;
            this.HumanRadioButton.TabStop = true;
            this.HumanRadioButton.Text = "Human";
            this.HumanRadioButton.UseVisualStyleBackColor = true;
            this.HumanRadioButton.CheckedChanged += new System.EventHandler(this.RaceRadioButton_CheckedChanged);
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.Location = new System.Drawing.Point(339, 412);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(105, 37);
            this.CreateButton.TabIndex = 6;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // SelectClassGroupBox
            // 
            this.SelectClassGroupBox.Controls.Add(this.radioButton5);
            this.SelectClassGroupBox.Controls.Add(this.radioButton4);
            this.SelectClassGroupBox.Controls.Add(this.radioButton1);
            this.SelectClassGroupBox.Controls.Add(this.radioButton2);
            this.SelectClassGroupBox.Controls.Add(this.radioButton3);
            this.SelectClassGroupBox.Controls.Add(this.BardRadioButton);
            this.SelectClassGroupBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectClassGroupBox.Location = new System.Drawing.Point(12, 195);
            this.SelectClassGroupBox.Name = "SelectClassGroupBox";
            this.SelectClassGroupBox.Size = new System.Drawing.Size(272, 194);
            this.SelectClassGroupBox.TabIndex = 6;
            this.SelectClassGroupBox.TabStop = false;
            this.SelectClassGroupBox.Text = "Select Class";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 134);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(78, 22);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.Text = "Fighter";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.ClassRadioButton_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 162);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(111, 22);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.Text = "Magic-User";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.ClassRadioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 106);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 22);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "Thief";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.ClassRadioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 78);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 22);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Monk";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.ClassRadioButton_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 50);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(70, 22);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.Text = "Cleric";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.ClassRadioButton_CheckedChanged);
            // 
            // BardRadioButton
            // 
            this.BardRadioButton.AutoSize = true;
            this.BardRadioButton.Checked = true;
            this.BardRadioButton.Location = new System.Drawing.Point(6, 22);
            this.BardRadioButton.Name = "BardRadioButton";
            this.BardRadioButton.Size = new System.Drawing.Size(61, 22);
            this.BardRadioButton.TabIndex = 0;
            this.BardRadioButton.TabStop = true;
            this.BardRadioButton.Text = "Bard";
            this.BardRadioButton.UseVisualStyleBackColor = true;
            this.BardRadioButton.CheckedChanged += new System.EventHandler(this.ClassRadioButton_CheckedChanged);
            // 
            // RaceAndClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 461);
            this.Controls.Add(this.SelectClassGroupBox);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.SelectRaceGroupBox);
            this.Controls.Add(this.BackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RaceAndClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Race And Class Selection";
            this.SelectRaceGroupBox.ResumeLayout(false);
            this.SelectRaceGroupBox.PerformLayout();
            this.SelectClassGroupBox.ResumeLayout(false);
            this.SelectClassGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.GroupBox SelectRaceGroupBox;
        private System.Windows.Forms.RadioButton HumanRadioButton;
        private System.Windows.Forms.RadioButton HalflingRadioButton;
        private System.Windows.Forms.RadioButton DwarfRadioButton;
        private System.Windows.Forms.RadioButton ElfRadioButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.GroupBox SelectClassGroupBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton BardRadioButton;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}
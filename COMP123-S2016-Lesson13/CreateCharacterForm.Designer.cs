namespace COMP123_S2016_Lesson13
{
    partial class CreateCharacterForm
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
            this.CharacterDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.FinishButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StrLabel = new System.Windows.Forms.Label();
            this.StrTextBox = new System.Windows.Forms.TextBox();
            this.DexTextBox = new System.Windows.Forms.TextBox();
            this.DexLabel = new System.Windows.Forms.Label();
            this.ConTextBox = new System.Windows.Forms.TextBox();
            this.ConLabel = new System.Windows.Forms.Label();
            this.IntTextBox = new System.Windows.Forms.TextBox();
            this.IntLabel = new System.Windows.Forms.Label();
            this.WisTextBox = new System.Windows.Forms.TextBox();
            this.WisLabel = new System.Windows.Forms.Label();
            this.ChaTextBox = new System.Windows.Forms.TextBox();
            this.ChaLabel = new System.Windows.Forms.Label();
            this.RaceTextBox = new System.Windows.Forms.TextBox();
            this.RaceLabel = new System.Windows.Forms.Label();
            this.ClassTextBox = new System.Windows.Forms.TextBox();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.CharacterDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CharacterDetailsGroupBox
            // 
            this.CharacterDetailsGroupBox.Controls.Add(this.ClassTextBox);
            this.CharacterDetailsGroupBox.Controls.Add(this.ClassLabel);
            this.CharacterDetailsGroupBox.Controls.Add(this.RaceTextBox);
            this.CharacterDetailsGroupBox.Controls.Add(this.RaceLabel);
            this.CharacterDetailsGroupBox.Controls.Add(this.ChaTextBox);
            this.CharacterDetailsGroupBox.Controls.Add(this.ChaLabel);
            this.CharacterDetailsGroupBox.Controls.Add(this.WisTextBox);
            this.CharacterDetailsGroupBox.Controls.Add(this.WisLabel);
            this.CharacterDetailsGroupBox.Controls.Add(this.IntTextBox);
            this.CharacterDetailsGroupBox.Controls.Add(this.IntLabel);
            this.CharacterDetailsGroupBox.Controls.Add(this.ConTextBox);
            this.CharacterDetailsGroupBox.Controls.Add(this.ConLabel);
            this.CharacterDetailsGroupBox.Controls.Add(this.DexTextBox);
            this.CharacterDetailsGroupBox.Controls.Add(this.DexLabel);
            this.CharacterDetailsGroupBox.Controls.Add(this.StrTextBox);
            this.CharacterDetailsGroupBox.Controls.Add(this.StrLabel);
            this.CharacterDetailsGroupBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterDetailsGroupBox.Location = new System.Drawing.Point(79, 90);
            this.CharacterDetailsGroupBox.Name = "CharacterDetailsGroupBox";
            this.CharacterDetailsGroupBox.Size = new System.Drawing.Size(272, 316);
            this.CharacterDetailsGroupBox.TabIndex = 6;
            this.CharacterDetailsGroupBox.TabStop = false;
            this.CharacterDetailsGroupBox.Text = "Character Details";
            // 
            // FinishButton
            // 
            this.FinishButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishButton.Location = new System.Drawing.Point(163, 412);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(105, 37);
            this.FinishButton.TabIndex = 7;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Success!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label2.Location = new System.Drawing.Point(61, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "The character was successfully created.";
            // 
            // StrLabel
            // 
            this.StrLabel.AutoSize = true;
            this.StrLabel.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.StrLabel.Location = new System.Drawing.Point(6, 40);
            this.StrLabel.Name = "StrLabel";
            this.StrLabel.Size = new System.Drawing.Size(68, 16);
            this.StrLabel.TabIndex = 0;
            this.StrLabel.Text = "Strength:";
            // 
            // StrTextBox
            // 
            this.StrTextBox.BackColor = System.Drawing.Color.White;
            this.StrTextBox.Enabled = false;
            this.StrTextBox.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.StrTextBox.Location = new System.Drawing.Point(115, 37);
            this.StrTextBox.Name = "StrTextBox";
            this.StrTextBox.ReadOnly = true;
            this.StrTextBox.Size = new System.Drawing.Size(151, 23);
            this.StrTextBox.TabIndex = 8;
            // 
            // DexTextBox
            // 
            this.DexTextBox.BackColor = System.Drawing.Color.White;
            this.DexTextBox.Enabled = false;
            this.DexTextBox.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.DexTextBox.Location = new System.Drawing.Point(115, 71);
            this.DexTextBox.Name = "DexTextBox";
            this.DexTextBox.ReadOnly = true;
            this.DexTextBox.Size = new System.Drawing.Size(151, 23);
            this.DexTextBox.TabIndex = 10;
            // 
            // DexLabel
            // 
            this.DexLabel.AutoSize = true;
            this.DexLabel.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.DexLabel.Location = new System.Drawing.Point(6, 74);
            this.DexLabel.Name = "DexLabel";
            this.DexLabel.Size = new System.Drawing.Size(73, 16);
            this.DexLabel.TabIndex = 9;
            this.DexLabel.Text = "Dexterity:";
            // 
            // ConTextBox
            // 
            this.ConTextBox.BackColor = System.Drawing.Color.White;
            this.ConTextBox.Enabled = false;
            this.ConTextBox.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.ConTextBox.Location = new System.Drawing.Point(115, 105);
            this.ConTextBox.Name = "ConTextBox";
            this.ConTextBox.ReadOnly = true;
            this.ConTextBox.Size = new System.Drawing.Size(151, 23);
            this.ConTextBox.TabIndex = 12;
            // 
            // ConLabel
            // 
            this.ConLabel.AutoSize = true;
            this.ConLabel.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.ConLabel.Location = new System.Drawing.Point(6, 108);
            this.ConLabel.Name = "ConLabel";
            this.ConLabel.Size = new System.Drawing.Size(92, 16);
            this.ConLabel.TabIndex = 11;
            this.ConLabel.Text = "Constitution:";
            // 
            // IntTextBox
            // 
            this.IntTextBox.BackColor = System.Drawing.Color.White;
            this.IntTextBox.Enabled = false;
            this.IntTextBox.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.IntTextBox.Location = new System.Drawing.Point(115, 139);
            this.IntTextBox.Name = "IntTextBox";
            this.IntTextBox.ReadOnly = true;
            this.IntTextBox.Size = new System.Drawing.Size(151, 23);
            this.IntTextBox.TabIndex = 14;
            // 
            // IntLabel
            // 
            this.IntLabel.AutoSize = true;
            this.IntLabel.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.IntLabel.Location = new System.Drawing.Point(6, 142);
            this.IntLabel.Name = "IntLabel";
            this.IntLabel.Size = new System.Drawing.Size(86, 16);
            this.IntLabel.TabIndex = 13;
            this.IntLabel.Text = "Intelligence:";
            // 
            // WisTextBox
            // 
            this.WisTextBox.BackColor = System.Drawing.Color.White;
            this.WisTextBox.Enabled = false;
            this.WisTextBox.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.WisTextBox.Location = new System.Drawing.Point(115, 173);
            this.WisTextBox.Name = "WisTextBox";
            this.WisTextBox.ReadOnly = true;
            this.WisTextBox.Size = new System.Drawing.Size(151, 23);
            this.WisTextBox.TabIndex = 16;
            // 
            // WisLabel
            // 
            this.WisLabel.AutoSize = true;
            this.WisLabel.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.WisLabel.Location = new System.Drawing.Point(6, 176);
            this.WisLabel.Name = "WisLabel";
            this.WisLabel.Size = new System.Drawing.Size(64, 16);
            this.WisLabel.TabIndex = 15;
            this.WisLabel.Text = "Wisdom:";
            // 
            // ChaTextBox
            // 
            this.ChaTextBox.BackColor = System.Drawing.Color.White;
            this.ChaTextBox.Enabled = false;
            this.ChaTextBox.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.ChaTextBox.Location = new System.Drawing.Point(115, 207);
            this.ChaTextBox.Name = "ChaTextBox";
            this.ChaTextBox.ReadOnly = true;
            this.ChaTextBox.Size = new System.Drawing.Size(151, 23);
            this.ChaTextBox.TabIndex = 18;
            // 
            // ChaLabel
            // 
            this.ChaLabel.AutoSize = true;
            this.ChaLabel.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.ChaLabel.Location = new System.Drawing.Point(6, 210);
            this.ChaLabel.Name = "ChaLabel";
            this.ChaLabel.Size = new System.Drawing.Size(72, 16);
            this.ChaLabel.TabIndex = 17;
            this.ChaLabel.Text = "Charisma:";
            // 
            // RaceTextBox
            // 
            this.RaceTextBox.BackColor = System.Drawing.Color.White;
            this.RaceTextBox.Enabled = false;
            this.RaceTextBox.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.RaceTextBox.Location = new System.Drawing.Point(115, 241);
            this.RaceTextBox.Name = "RaceTextBox";
            this.RaceTextBox.ReadOnly = true;
            this.RaceTextBox.Size = new System.Drawing.Size(151, 23);
            this.RaceTextBox.TabIndex = 20;
            // 
            // RaceLabel
            // 
            this.RaceLabel.AutoSize = true;
            this.RaceLabel.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.RaceLabel.Location = new System.Drawing.Point(6, 244);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(45, 16);
            this.RaceLabel.TabIndex = 19;
            this.RaceLabel.Text = "Race:";
            // 
            // ClassTextBox
            // 
            this.ClassTextBox.BackColor = System.Drawing.Color.White;
            this.ClassTextBox.Enabled = false;
            this.ClassTextBox.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.ClassTextBox.Location = new System.Drawing.Point(115, 275);
            this.ClassTextBox.Name = "ClassTextBox";
            this.ClassTextBox.ReadOnly = true;
            this.ClassTextBox.Size = new System.Drawing.Size(151, 23);
            this.ClassTextBox.TabIndex = 22;
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.ClassLabel.Location = new System.Drawing.Point(6, 278);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(47, 16);
            this.ClassLabel.TabIndex = 21;
            this.ClassLabel.Text = "Class:";
            // 
            // CreateCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 461);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.CharacterDetailsGroupBox);
            this.Name = "CreateCharacterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Creation";
            this.Load += new System.EventHandler(this.CreateCharacterForm_Load);
            this.CharacterDetailsGroupBox.ResumeLayout(false);
            this.CharacterDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CharacterDetailsGroupBox;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label StrLabel;
        private System.Windows.Forms.TextBox ClassTextBox;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.TextBox RaceTextBox;
        private System.Windows.Forms.Label RaceLabel;
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
        private System.Windows.Forms.TextBox StrTextBox;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_Lesson13
{
    public partial class RaceAndClassForm : Form
    {
        public AbilityGeneratorForm PreviousForm { get; set; }

        public RaceAndClassForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.PreviousForm.Show();
            this.Close();
        }

        private void RaceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var character = Program.character;
            RadioButton selectedRace = (RadioButton)sender;
            character.Race = selectedRace.Text;
        }

        private void ClassRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var character = Program.character;
            RadioButton selectedClass = (RadioButton)sender;
            character.Class = selectedClass.Text;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            CreateCharacterForm finalForm = new CreateCharacterForm();
            finalForm.PreviousForm = this;
            finalForm.Show();
            this.Hide();
        }
    }
}

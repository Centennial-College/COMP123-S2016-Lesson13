using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_Lesson13
{
    public partial class CreateCharacterForm : Form
    {
        public RaceAndClassForm PreviousForm { get; set; }

        public CreateCharacterForm()
        {
            InitializeComponent();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateCharacterForm_Load(object sender, EventArgs e)
        {
            var character = Program.character;
            StrTextBox.Text = character.Strength;
            DexTextBox.Text = character.Dexterity;
            ConTextBox.Text = character.Constitution;
            IntTextBox.Text = character.Intelligence;
            WisTextBox.Text = character.Wisdom;
            ChaTextBox.Text = character.Charisma;
            RaceTextBox.Text = character.Race;
            ClassTextBox.Text = character.Class;
        }
    }
}

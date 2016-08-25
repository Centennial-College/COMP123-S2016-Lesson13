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
    public partial class AbilityGeneratorForm : Form
    {
        // private Instance Object
        private Random _ranNumGen;

        private TextBox _firstAbility;
        private TextBox _secondAbility;
        private TextBox _modifiedAbility;

        public AbilityGeneratorForm()
        {
            InitializeComponent();
        }

        /**
         * <summary>
         * Generates a random result using 4d6 method.
         * Roll 4 dices numbered 1-6, drop lowest roll and 
         * return the sum of the other 3 rolls.
         * </summary>
         * 
         * @private
         * @method Roll
         * @returns {Int32}
         */
        private Int32 Roll()
        {
            // create new empty list
            List<Int32> numbers = new List<Int32>();
            int result = 0;

            // use list because can sort and drop lowest value easily
            // 4d6 yields higher results than 3 die, because the average sum will be shifted to the right, higher
            for (int count = 0; count < 4; count++)
            {
                numbers.Add(this._ranNumGen.Next(0, 6) + 1);
            }

            // drop the lowest die
            numbers.Remove(numbers.Min());

            // add the numbers to the result
            //foreach (int number in numbers)
            //{
            //    result += number;
            //}

            // lambda expression equivalent
            result = numbers.Sum(number => number);

            return result;
        }

        private void GenerateAbilities()
        {
            StrTextBox.Text = this.Roll().ToString();
            DexTextBox.Text = this.Roll().ToString();
            ConTextBox.Text = this.Roll().ToString();
            IntTextBox.Text = this.Roll().ToString();
            WisTextBox.Text = this.Roll().ToString();
            ChaTextBox.Text = this.Roll().ToString();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            this.GenerateAbilities();

        }

        private void GeneratorForm_Load(object sender, EventArgs e)
        {
            this._ranNumGen = new Random(); // initialize random number object

            this.GenerateAbilities();
            FirstAbilityComboBox.SelectedIndex = 0;
            SecondAbilityComboBox.SelectedIndex = 0;
            ModAbilityComboBox.SelectedIndex = 0;
        }

        private void SwapButton_Click(object sender, EventArgs e)
        {
            string temporaryAbility;

            temporaryAbility = this._firstAbility.Text;
            this._firstAbility.Text = this._secondAbility.Text;
            this._secondAbility.Text = temporaryAbility;
        }

        private TextBox ChooseAbility(int selectedAbility)
        {
            TextBox textbox = new TextBox();

            switch (selectedAbility)
            {
                case (int)Ability.Strength:
                    textbox = StrTextBox;
                    break;
                case (int)Ability.Dexterity:
                    textbox = DexTextBox;
                    break;
                case (int)Ability.Constitution:
                    textbox = ConTextBox;
                    break;
                case (int)Ability.Intelligence:
                    textbox = IntTextBox;
                    break;
                case (int)Ability.Wisdom:
                    textbox = WisTextBox;
                    break;
                case (int)Ability.Charisma:
                    textbox = ChaTextBox;
                    break;
            }

            return textbox;
        }

        private void FirstAbilityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // make a reference to the first ability selected
            this._firstAbility = ChooseAbility(FirstAbilityComboBox.SelectedIndex);
        }

        private void SecondAbilityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // make a reference to the second ability selected
            this._secondAbility = ChooseAbility(SecondAbilityComboBox.SelectedIndex);
        }

        private void ModAbilityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // make a reference to the modify ability selected
            this._modifiedAbility = ChooseAbility(ModAbilityComboBox.SelectedIndex);
        }

        private void ModButton_Click(object sender, EventArgs e)
        {
            int ScoreToModify = Convert.ToInt32(this._modifiedAbility.Text);
            ScoreToModify++;
            this._modifiedAbility.Text = ScoreToModify.ToString();
            ModAbilitiesGroupBox.Enabled = false;
        }
    }
}

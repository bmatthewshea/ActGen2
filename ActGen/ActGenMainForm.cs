using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActGen
{
    public partial class ActGenMainForm : Form
    {
 
        // Some methods/string manipulation //

        private static string RemoveNumbers(string input)
        {
            return new string(input.Where(c => (c < '0' || c > '9')).ToArray());
        }

        private static string removeUppers(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
                if (!(c >= 'A' && c <= 'Z'))
                {
                    sb.Append(c);
                }
            return sb.ToString();
        }

        private static string removeLowers(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
                if (!(c >= 'a' && c <= 'z'))
                {
                    sb.Append(c);
                }
            return sb.ToString();
        }

        private static string removeCommon(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
                // ( filter these "B 8 0 O o 1 l i" )
                if (!(c == 'B' || c == '8' || c == '0' || c == 'O' || c == 'o' || c == '1' || c == 'l' || c == 'i'))
                {
                    sb.Append(c);
                }
            return sb.ToString();
        }

        private static string addUserDefined(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
                // ( add/check symbols/user-defined - return new sChars)
                if ((c >= '!' || c <= '/') || (c >= ':' || c <= '@') || (c >= '[' || c <= '\'') || (c >= '{' || c <= '~'))
                {
                    sb.Append(c);
                }
            return sb.ToString();
        }

        /// <summary>
        ///         //  http://stackoverflow.com/a/30853291/503621  //
        /// Returns a string with the specified characters removed.
        /// </summary>
        /// <param name="source">The string to filter.</param>
        /// <param name="removeCharacters">The characters to remove.</param>
        /// <returns>A new <see cref="System.String"/> with the specified characters removed.</returns>
        private static string removeUserDefined(string input, IEnumerable<char> removeCharacters)
        {
            if (input == null)            { throw new ArgumentNullException("No input sent"); }
            if (removeCharacters == null) { throw new ArgumentNullException("No remove characters sent"); }
            // First see if we were given a collection that supports ISet
            ISet<char> replaceChars = removeCharacters as ISet<char>;
            if (replaceChars == null)     { replaceChars = new HashSet<char>(removeCharacters); }
            IEnumerable<char> filtered = input.Where(currentChar => !replaceChars.Contains(currentChar));
            return new string(filtered.ToArray());
        }


        //linq - remove duplicate characters from given string
        private static string RemoveDuplicates(string input)
        {
            return new string(input.ToCharArray().Distinct().ToArray());
        }


        private void LoadDefaults()
        {
            //menu items grey out until Generate clicked again.
            saveToolStripMenuItem.Enabled = false;
            copyToolStripMenuItem.Enabled = false;
            findToolStripMenuItem.Enabled = false;
            findNextToolStripMenuItem.Enabled = false;
            clearCurrentListToolStripMenuItem.Enabled = false;
            //
            textBox_amount_to_generate.Text = "16";
            textBox_chars_to_make.Text = "16";
            checkBox_include_dashes.Checked = false;
            textBox_characters_between_dashes.Text = "";
            checkBox_use_numbers.Checked = true;
            radioButton_use_both_case.Checked = true;
            checkBox_avoid_characters.Checked = false;
            textBox_characters_between_dashes.Enabled = false;
            label_characters_between_dashes.Enabled = false;
            textBox_remove_additional_custom_characters.Text = "";
            textBox_include_additional_custom_characters.Text = "";
            checkBoxRNGCrypto.Checked = true;
            button_console_toggle.Enabled = false;
        }

        //FORM START

        public ActGenMainForm()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();    //only exits form
            Application.Exit();
        }

        private void button_console_toggle_Click(object sender, EventArgs e)
        {
            if (!FormToggle.Console.Visible)
            {
                FormToggle.Console.Show();
            } 
            else
            { 
                FormToggle.Console.Hide();
            }
        }

        private void button_load_defaults_Click(object sender, EventArgs e)
        {
            LoadDefaults();
        }

        private void ActGenMainForm_Load(object sender, EventArgs e)
        {
            //Save user settings from project properties on load event (all props are set to user/roaming):
            this.textBox_amount_to_generate.Text                   = Properties.Settings.Default.amount_to_generate;
            this.textBox_chars_to_make.Text                        = Properties.Settings.Default.chars_to_make;
            this.checkBox_use_numbers.Checked                      = Properties.Settings.Default.use_numbers;
            this.checkBox_include_dashes.Checked                   = Properties.Settings.Default.include_dashes;
            this.textBox_characters_between_dashes.Text            = Properties.Settings.Default.characters_between_dashes;
            this.radioButton_use_both_case.Checked                 = Properties.Settings.Default.use_both_case;
            this.radioButton_use_upper.Checked                     = Properties.Settings.Default.use_upper;
            this.radioButton_use_lower.Checked                     = Properties.Settings.Default.use_lower;
            this.radioButtonLettersNone.Checked                    = Properties.Settings.Default.use_no_letters;
            this.checkBox_avoid_characters.Checked                 = Properties.Settings.Default.avoid_characters;
            this.textBox_remove_additional_custom_characters.Text  = Properties.Settings.Default.remove_additional_custom_characters;
            this.textBox_include_additional_custom_characters.Text = Properties.Settings.Default.include_additional_custom_characters;
            this.checkBox_save_on_exit.Checked                     = false;
            this.checkBoxRNGCrypto.Checked                         = Properties.Settings.Default.rngcrypto;
        }

        private void aboutWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActGenAboutForm showAbout = new ActGenAboutForm();
            showAbout.ShowDialog();
        }



        private void button_calculate_Click(object sender, EventArgs e)
        {
            int iAmountOfCodes      = 0;
            int iCharsPerCode       = 0;
            int iDashSpacing        = 0;
            bool bUsenumbers        = checkBox_use_numbers.Checked;
            bool bDashes            = checkBox_include_dashes.Checked;
            bool bcodeType          = checkBoxRNGCrypto.Checked;

            //build our basic characters to use first before any loops:
            //default chars to start with
            var sChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            //
            // Get user OPTIONS and setup final sChars
            //
            
            //Remove numbers from it?
            if (!bUsenumbers) sChars = RemoveNumbers(sChars);
           // else //either one or the other
           //     radioButtonLettersNone.Checked = false;
            
            //Remove commonly confused characters?
            if (checkBox_avoid_characters.Checked) sChars = removeCommon(sChars);

            // Case: Both || Upper || Lower || None ?
            if (radioButton_use_upper.Checked) sChars=removeLowers(sChars);
            if (radioButton_use_lower.Checked) sChars=removeUppers(sChars);
            if (radioButtonLettersNone.Checked)
            {
                sChars = removeLowers(sChars);
                sChars = removeUppers(sChars);
            }
            
            //
            //form validation & set some int's along the way..
            //

            bool canConvertD = int.TryParse(textBox_characters_between_dashes.Text, out iDashSpacing);
            bool canConvertA = int.TryParse(textBox_amount_to_generate.Text, out iAmountOfCodes);
            bool canConvertU = int.TryParse(textBox_chars_to_make.Text, out iCharsPerCode);

            if ((textBox_amount_to_generate.Text == null) || (canConvertA != true))
            {
                //MessageBox.Show("Amount to generate blank or not a number.");
                textBox_amount_to_generate.Focus();
                //textBox_amount_to_generate.ForeColor = Color.Red;
                textBox_amount_to_generate.Select(0, textBox_amount_to_generate.Text.Length);
                return;
            }

            if ((textBox_chars_to_make.Text == null) || (canConvertU != true))
            {
                //MessageBox.Show("Amount of characters blank or not a number.");
                textBox_chars_to_make.Focus();
                textBox_chars_to_make.Select(0, textBox_chars_to_make.Text.Length);
                return;
            }

            if (iAmountOfCodes >= 1000001)
            {
                //MessageBox.Show(" Number cannot be over max..\n or update the source code ;-)");
                textBox_amount_to_generate.Focus();
                textBox_amount_to_generate.Select(0, textBox_amount_to_generate.Text.Length);
                return;
            }
            if (iCharsPerCode >= 65)
            {
                //MessageBox.Show(" Number cannot be over max..\n or update the source code ;-)");
                textBox_chars_to_make.Focus();
                textBox_chars_to_make.Select(0, textBox_chars_to_make.Text.Length);
                return;
            }

            //Check dashes toggle and set
            if ((bDashes) && (iDashSpacing != 0))
            {
                //MessageBox.Show("iDashSpacing = " + iDashSpacing + "\n iCharsPerCode = " + iCharsPerCode);
                if (iDashSpacing >= iCharsPerCode)
                {
                    textBox_characters_between_dashes.Focus();
                    textBox_characters_between_dashes.Select(0, textBox_chars_to_make.Text.Length);
                    return;
                }
             }

            // remove some other characters?
            if (textBox_remove_additional_custom_characters.Text != "")
            {   //pull out spaces
                
                string s = textBox_remove_additional_custom_characters.Text.Replace(" ", "");  //<- remove spaces
                //debug only -> MessageBox.Show("Removing Characters: " + RemoveDuplicates(s));
                sChars = removeUserDefined(sChars, RemoveDuplicates(s));
            }

            //include some additional characters (symbols only)
            if (textBox_include_additional_custom_characters.Text != "")
            {   //pull out spaces
                string s = textBox_include_additional_custom_characters.Text.Replace(" ", "");  //<- remove spaces
                // debug only -> MessageBox.Show("Adding Characters: " + RemoveDuplicates(s) );
                sChars = sChars + addUserDefined( (RemoveDuplicates(s) ));
            }


            //  debug only -> MessageBox.Show("sChars before running codes " + sChars);
            //
            //  See if we have any characters left after filtering. Else we catch exceptions...
            //
            if (sChars == "")
            {
                MessageBox.Show("\"I'm sorry, Dave. I'm afraid I can't do that.\"\n\nAll characters have been filtered.\nPlease try another selection.\n\nDo you have both numbers and letters off?", "ActGen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_amount_to_generate.Select(0, textBox_amount_to_generate.Text.Length);
                return;
            }

            //Seems we are good to go.
            //Re-enable our menu/etc

            button_console_toggle.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
            copyToolStripMenuItem.Enabled = true;
            findToolStripMenuItem.Enabled = true;
            findNextToolStripMenuItem.Enabled = true;
            clearCurrentListToolStripMenuItem.Enabled = true;
            FormToggle.Console.enable_buttons();

            //
            // Validation Passed
            //
            //Let's make some codes!
            //
            Calculations.CreateRandomCodes(iAmountOfCodes, iCharsPerCode, bDashes, iDashSpacing, sChars, bcodeType);



        }

        private void checkBox_include_dashes_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox_include_dashes.Checked)
            {
                textBox_characters_between_dashes.Enabled = true;
                label_characters_between_dashes.Enabled = true;
            }
            else
            {
                textBox_characters_between_dashes.Enabled = false;
                label_characters_between_dashes.Enabled = false;
            }
        }

        private void radioButtonLettersNone_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox_use_numbers.Checked = true;
            // -> will just let it generate zero possible code or print exception message
        }

        private void checkBox_use_numbers_CheckedChanged(object sender, EventArgs e)
        {
            //radioButton_use_both_case.Checked = true;
            // -> will just let it generate zero possible code or print exception message
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileOperations FileOPs = new FileOperations();
            FileOPs.SaveFile("myCodes.txt", FormToggle.Console.textBoxConsole.Text);
        }

        private void clearCurrentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormToggle.Console.Show();
            FormToggle.Console.textBoxConsole.Text = String.Empty;
            FormToggle.Console.clear_list_and_buttons();

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormToggle.textBoxConsole.Focus();
            FormToggle.Console.textBoxConsole.Select(0, FormToggle.Console.textBoxConsole.Text.Length);
            Clipboard.SetText(FormToggle.Console.textBoxConsole.Text);
        }

        private void checkBoxRNGCrypto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRNGCrypto.Checked == false)
            {
                label_amount_to_gen_max.Text = "(Max: 100,000 codes)";
            }
            else
            {
                label_amount_to_gen_max.Text = "(Max: 100,000 codes)";
            }


        }

        private void ActGenMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (this.checkBox_save_on_exit.Checked)
            {
                Properties.Settings.Default.amount_to_generate = this.textBox_amount_to_generate.Text;
                Properties.Settings.Default.chars_to_make = this.textBox_chars_to_make.Text;
                Properties.Settings.Default.use_numbers = this.checkBox_use_numbers.Checked;
                Properties.Settings.Default.include_dashes = this.checkBox_include_dashes.Checked;
                Properties.Settings.Default.characters_between_dashes = this.textBox_characters_between_dashes.Text;
                Properties.Settings.Default.use_both_case = this.radioButton_use_both_case.Checked;
                Properties.Settings.Default.use_upper = this.radioButton_use_upper.Checked;
                Properties.Settings.Default.use_lower = this.radioButton_use_lower.Checked;
                Properties.Settings.Default.use_no_letters = this.radioButtonLettersNone.Checked;
                Properties.Settings.Default.avoid_characters = this.checkBox_avoid_characters.Checked;
                Properties.Settings.Default.remove_additional_custom_characters = this.textBox_remove_additional_custom_characters.Text;
                Properties.Settings.Default.include_additional_custom_characters = this.textBox_include_additional_custom_characters.Text;
                Properties.Settings.Default.save_on_exit = false;
                Properties.Settings.Default.rngcrypto = this.checkBoxRNGCrypto.Checked;
                // Save it all if save on exit is true
                Properties.Settings.Default.Save();
            }
        }
    }
}

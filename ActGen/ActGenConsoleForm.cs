using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ActGen
{
    interface IsingleCode
    {
        string singleCode { get; set; }
        string clearConsole { set; }
    }


    public partial class ActGenConsoleForm : Form, IsingleCode
    {
        public ActGenConsoleForm()
        {
            InitializeComponent();
        }

        private void button_console_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        //my stuff

        public string singleCode
        {
            get { return textBoxConsole.Text; }
            set { textBoxConsole.Text = value; }
        }

        public string clearConsole
        {
            set { textBoxConsole.Text=String.Empty; }
        }

        private void button_console_copy_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxConsole.Text))
            {
                textBoxConsole.Focus();
                textBoxConsole.Select(0, textBoxConsole.Text.Length);
                Clipboard.SetText(textBoxConsole.Text);
            }
        }

        private void button_console_save_Click(object sender, EventArgs e)
        {
            FileOperations FileOPs = new FileOperations();
            FileOPs.SaveFile("myCodes.txt", textBoxConsole.Text);
        }

        public void button_clear_console_Click(object sender, EventArgs e)
        {
            clear_list_and_buttons();
        }

        public void clear_list_and_buttons()
        {
            this.textBoxConsole.Text = String.Empty;
            this.button_console_save.Enabled = false;
            this.button_console_copy.Enabled = false;
            this.button_clear_console.Enabled = false;
        }

        public void enable_buttons()
        {
            this.button_console_save.Enabled = true;
            this.button_console_copy.Enabled = true;
            this.button_clear_console.Enabled = true;
        }

        private void ActGenConsoleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}

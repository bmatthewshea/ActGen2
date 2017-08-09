namespace ActGen
{
    partial class ActGenConsoleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActGenConsoleForm));
            this.button_console_copy = new System.Windows.Forms.Button();
            this.button_console_save = new System.Windows.Forms.Button();
            this.button_console_close = new System.Windows.Forms.Button();
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.button_clear_console = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button_console_copy
            // 
            this.button_console_copy.Location = new System.Drawing.Point(96, 290);
            this.button_console_copy.Name = "button_console_copy";
            this.button_console_copy.Size = new System.Drawing.Size(78, 25);
            this.button_console_copy.TabIndex = 2;
            this.button_console_copy.Text = "Copy";
            this.button_console_copy.UseVisualStyleBackColor = true;
            this.button_console_copy.Click += new System.EventHandler(this.button_console_copy_Click);
            // 
            // button_console_save
            // 
            this.button_console_save.Location = new System.Drawing.Point(12, 290);
            this.button_console_save.Name = "button_console_save";
            this.button_console_save.Size = new System.Drawing.Size(78, 25);
            this.button_console_save.TabIndex = 3;
            this.button_console_save.Text = "Save";
            this.button_console_save.UseVisualStyleBackColor = true;
            this.button_console_save.Click += new System.EventHandler(this.button_console_save_Click);
            // 
            // button_console_close
            // 
            this.button_console_close.Location = new System.Drawing.Point(369, 290);
            this.button_console_close.Name = "button_console_close";
            this.button_console_close.Size = new System.Drawing.Size(78, 25);
            this.button_console_close.TabIndex = 4;
            this.button_console_close.Text = "Close";
            this.button_console_close.UseVisualStyleBackColor = true;
            this.button_console_close.Click += new System.EventHandler(this.button_console_close_Click);
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConsole.Location = new System.Drawing.Point(-2, -2);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.ReadOnly = true;
            this.textBoxConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxConsole.Size = new System.Drawing.Size(461, 265);
            this.textBoxConsole.TabIndex = 5;
            // 
            // button_clear_console
            // 
            this.button_clear_console.Location = new System.Drawing.Point(285, 290);
            this.button_clear_console.Name = "button_clear_console";
            this.button_clear_console.Size = new System.Drawing.Size(78, 25);
            this.button_clear_console.TabIndex = 6;
            this.button_clear_console.Text = "Clear";
            this.button_clear_console.UseVisualStyleBackColor = true;
            this.button_clear_console.Click += new System.EventHandler(this.button_clear_console_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 269);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(435, 15);
            this.progressBar1.TabIndex = 7;
            // 
            // ActGenConsoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(459, 320);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button_clear_console);
            this.Controls.Add(this.textBoxConsole);
            this.Controls.Add(this.button_console_close);
            this.Controls.Add(this.button_console_save);
            this.Controls.Add(this.button_console_copy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ActGenConsoleForm";
            this.Text = "ActGen Console";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActGenConsoleForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_console_copy;
        private System.Windows.Forms.Button button_console_save;
        private System.Windows.Forms.Button button_console_close;
        public System.Windows.Forms.TextBox textBoxConsole;
        private System.Windows.Forms.Button button_clear_console;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
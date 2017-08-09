namespace ActGen
{
    partial class ActGenMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActGenMainForm));
            this.label_amount_to_gen = new System.Windows.Forms.Label();
            this.label_amount_to_gen_max = new System.Windows.Forms.Label();
            this.label_amount_per_code = new System.Windows.Forms.Label();
            this.label_amount_unique_chars_max = new System.Windows.Forms.Label();
            this.label_include_dashes = new System.Windows.Forms.Label();
            this.label_characters_between_dashes = new System.Windows.Forms.Label();
            this.label_use_upper_lower_case = new System.Windows.Forms.Label();
            this.label_avoid_characters = new System.Windows.Forms.Label();
            this.label_remove_additional_custom_characters = new System.Windows.Forms.Label();
            this.label_include_additional_custom_characters = new System.Windows.Forms.Label();
            this.button_load_defaults = new System.Windows.Forms.Button();
            this.button_calculate = new System.Windows.Forms.Button();
            this.button_console_toggle = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCurrentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_delimiter_note = new System.Windows.Forms.Label();
            this.radioButton_use_both_case = new System.Windows.Forms.RadioButton();
            this.radioButton_use_upper = new System.Windows.Forms.RadioButton();
            this.radioButton_use_lower = new System.Windows.Forms.RadioButton();
            this.label_use_numbers = new System.Windows.Forms.Label();
            this.groupBox_used_case = new System.Windows.Forms.GroupBox();
            this.radioButtonLettersNone = new System.Windows.Forms.RadioButton();
            this.checkBoxRNGCrypto = new System.Windows.Forms.CheckBox();
            this.checkBox_use_numbers = new System.Windows.Forms.CheckBox();
            this.checkBox_save_on_exit = new System.Windows.Forms.CheckBox();
            this.textBox_characters_between_dashes = new System.Windows.Forms.TextBox();
            this.textBox_include_additional_custom_characters = new System.Windows.Forms.TextBox();
            this.textBox_remove_additional_custom_characters = new System.Windows.Forms.TextBox();
            this.checkBox_avoid_characters = new System.Windows.Forms.CheckBox();
            this.checkBox_include_dashes = new System.Windows.Forms.CheckBox();
            this.textBox_chars_to_make = new System.Windows.Forms.TextBox();
            this.textBox_amount_to_generate = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox_used_case.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_amount_to_gen
            // 
            this.label_amount_to_gen.AutoSize = true;
            this.label_amount_to_gen.Location = new System.Drawing.Point(36, 42);
            this.label_amount_to_gen.Name = "label_amount_to_gen";
            this.label_amount_to_gen.Size = new System.Drawing.Size(103, 13);
            this.label_amount_to_gen.TabIndex = 0;
            this.label_amount_to_gen.Text = "Amount to generate:";
            // 
            // label_amount_to_gen_max
            // 
            this.label_amount_to_gen_max.AutoSize = true;
            this.label_amount_to_gen_max.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_amount_to_gen_max.Location = new System.Drawing.Point(37, 55);
            this.label_amount_to_gen_max.Name = "label_amount_to_gen_max";
            this.label_amount_to_gen_max.Size = new System.Drawing.Size(107, 13);
            this.label_amount_to_gen_max.TabIndex = 1;
            this.label_amount_to_gen_max.Text = "(Max: 100,000 codes)";
            // 
            // label_amount_per_code
            // 
            this.label_amount_per_code.AutoSize = true;
            this.label_amount_per_code.Location = new System.Drawing.Point(36, 79);
            this.label_amount_per_code.Name = "label_amount_per_code";
            this.label_amount_per_code.Size = new System.Drawing.Size(106, 13);
            this.label_amount_per_code.TabIndex = 2;
            this.label_amount_per_code.Text = "Characters per code:";
            // 
            // label_amount_unique_chars_max
            // 
            this.label_amount_unique_chars_max.AutoSize = true;
            this.label_amount_unique_chars_max.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_amount_unique_chars_max.Location = new System.Drawing.Point(36, 93);
            this.label_amount_unique_chars_max.Name = "label_amount_unique_chars_max";
            this.label_amount_unique_chars_max.Size = new System.Drawing.Size(50, 13);
            this.label_amount_unique_chars_max.TabIndex = 3;
            this.label_amount_unique_chars_max.Text = "(Max: 64)";
            // 
            // label_include_dashes
            // 
            this.label_include_dashes.AutoSize = true;
            this.label_include_dashes.Location = new System.Drawing.Point(36, 156);
            this.label_include_dashes.Name = "label_include_dashes";
            this.label_include_dashes.Size = new System.Drawing.Size(85, 13);
            this.label_include_dashes.TabIndex = 4;
            this.label_include_dashes.Text = "Include dashes?";
            // 
            // label_characters_between_dashes
            // 
            this.label_characters_between_dashes.AutoSize = true;
            this.label_characters_between_dashes.Location = new System.Drawing.Point(179, 143);
            this.label_characters_between_dashes.Name = "label_characters_between_dashes";
            this.label_characters_between_dashes.Size = new System.Drawing.Size(194, 26);
            this.label_characters_between_dashes.TabIndex = 5;
            this.label_characters_between_dashes.Text = "Characters between dashes?\r\n(must be less than Characters per code)";
            // 
            // label_use_upper_lower_case
            // 
            this.label_use_upper_lower_case.AutoSize = true;
            this.label_use_upper_lower_case.Location = new System.Drawing.Point(36, 201);
            this.label_use_upper_lower_case.Name = "label_use_upper_lower_case";
            this.label_use_upper_lower_case.Size = new System.Drawing.Size(73, 13);
            this.label_use_upper_lower_case.TabIndex = 7;
            this.label_use_upper_lower_case.Text = "Letters Usage";
            // 
            // label_avoid_characters
            // 
            this.label_avoid_characters.AutoSize = true;
            this.label_avoid_characters.Location = new System.Drawing.Point(36, 240);
            this.label_avoid_characters.Name = "label_avoid_characters";
            this.label_avoid_characters.Size = new System.Drawing.Size(198, 13);
            this.label_avoid_characters.TabIndex = 8;
            this.label_avoid_characters.Text = "Avoid using characters: B 8 0 O o 1 I i  ?";
            // 
            // label_remove_additional_custom_characters
            // 
            this.label_remove_additional_custom_characters.AutoSize = true;
            this.label_remove_additional_custom_characters.Location = new System.Drawing.Point(36, 280);
            this.label_remove_additional_custom_characters.Name = "label_remove_additional_custom_characters";
            this.label_remove_additional_custom_characters.Size = new System.Drawing.Size(154, 13);
            this.label_remove_additional_custom_characters.TabIndex = 9;
            this.label_remove_additional_custom_characters.Text = "Remove additional characters :";
            // 
            // label_include_additional_custom_characters
            // 
            this.label_include_additional_custom_characters.AutoSize = true;
            this.label_include_additional_custom_characters.Location = new System.Drawing.Point(36, 316);
            this.label_include_additional_custom_characters.Name = "label_include_additional_custom_characters";
            this.label_include_additional_custom_characters.Size = new System.Drawing.Size(149, 13);
            this.label_include_additional_custom_characters.TabIndex = 10;
            this.label_include_additional_custom_characters.Text = "Include additional characters :";
            // 
            // button_load_defaults
            // 
            this.button_load_defaults.Location = new System.Drawing.Point(13, 391);
            this.button_load_defaults.Name = "button_load_defaults";
            this.button_load_defaults.Size = new System.Drawing.Size(94, 29);
            this.button_load_defaults.TabIndex = 22;
            this.button_load_defaults.Text = "Load Defaults";
            this.button_load_defaults.UseVisualStyleBackColor = true;
            this.button_load_defaults.Click += new System.EventHandler(this.button_load_defaults_Click);
            // 
            // button_calculate
            // 
            this.button_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_calculate.Location = new System.Drawing.Point(113, 391);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(94, 29);
            this.button_calculate.TabIndex = 0;
            this.button_calculate.Text = "Generate";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // button_console_toggle
            // 
            this.button_console_toggle.Location = new System.Drawing.Point(213, 391);
            this.button_console_toggle.Name = "button_console_toggle";
            this.button_console_toggle.Size = new System.Drawing.Size(102, 29);
            this.button_console_toggle.TabIndex = 1;
            this.button_console_toggle.Text = "Console";
            this.button_console_toggle.UseVisualStyleBackColor = true;
            this.button_console_toggle.Click += new System.EventHandler(this.button_console_toggle_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(350, 391);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(94, 29);
            this.button_exit.TabIndex = 3;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(455, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.findToolStripMenuItem,
            this.findNextToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.findToolStripMenuItem.Text = "Find";
            // 
            // findNextToolStripMenuItem
            // 
            this.findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
            this.findNextToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.findNextToolStripMenuItem.Text = "Find Next";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearCurrentListToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // clearCurrentListToolStripMenuItem
            // 
            this.clearCurrentListToolStripMenuItem.Name = "clearCurrentListToolStripMenuItem";
            this.clearCurrentListToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.clearCurrentListToolStripMenuItem.Text = "Clear current list";
            this.clearCurrentListToolStripMenuItem.Click += new System.EventHandler(this.clearCurrentListToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutWebsiteToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutWebsiteToolStripMenuItem
            // 
            this.aboutWebsiteToolStripMenuItem.Name = "aboutWebsiteToolStripMenuItem";
            this.aboutWebsiteToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.aboutWebsiteToolStripMenuItem.Text = "About/Website";
            this.aboutWebsiteToolStripMenuItem.Click += new System.EventHandler(this.aboutWebsiteToolStripMenuItem_Click);
            // 
            // label_delimiter_note
            // 
            this.label_delimiter_note.AutoSize = true;
            this.label_delimiter_note.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_delimiter_note.Location = new System.Drawing.Point(275, 339);
            this.label_delimiter_note.Name = "label_delimiter_note";
            this.label_delimiter_note.Size = new System.Drawing.Size(116, 13);
            this.label_delimiter_note.TabIndex = 24;
            this.label_delimiter_note.Text = "SPACES will be removed";
            // 
            // radioButton_use_both_case
            // 
            this.radioButton_use_both_case.AutoSize = true;
            this.radioButton_use_both_case.Checked = global::ActGen.Properties.Settings.Default.use_both_case;
            this.radioButton_use_both_case.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ActGen.Properties.Settings.Default, "use_both_case", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioButton_use_both_case.Location = new System.Drawing.Point(12, 15);
            this.radioButton_use_both_case.Name = "radioButton_use_both_case";
            this.radioButton_use_both_case.Size = new System.Drawing.Size(50, 17);
            this.radioButton_use_both_case.TabIndex = 30;
            this.radioButton_use_both_case.TabStop = true;
            this.radioButton_use_both_case.Text = "Both!";
            this.radioButton_use_both_case.UseVisualStyleBackColor = true;
            // 
            // radioButton_use_upper
            // 
            this.radioButton_use_upper.AutoSize = true;
            this.radioButton_use_upper.Checked = global::ActGen.Properties.Settings.Default.use_upper;
            this.radioButton_use_upper.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ActGen.Properties.Settings.Default, "use_upper", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioButton_use_upper.Location = new System.Drawing.Point(67, 15);
            this.radioButton_use_upper.Name = "radioButton_use_upper";
            this.radioButton_use_upper.Size = new System.Drawing.Size(76, 17);
            this.radioButton_use_upper.TabIndex = 31;
            this.radioButton_use_upper.Text = "Upper only";
            this.radioButton_use_upper.UseVisualStyleBackColor = true;
            // 
            // radioButton_use_lower
            // 
            this.radioButton_use_lower.AutoSize = true;
            this.radioButton_use_lower.Checked = global::ActGen.Properties.Settings.Default.use_lower;
            this.radioButton_use_lower.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ActGen.Properties.Settings.Default, "use_lower", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioButton_use_lower.Location = new System.Drawing.Point(150, 15);
            this.radioButton_use_lower.Name = "radioButton_use_lower";
            this.radioButton_use_lower.Size = new System.Drawing.Size(76, 17);
            this.radioButton_use_lower.TabIndex = 32;
            this.radioButton_use_lower.Text = "Lower only";
            this.radioButton_use_lower.UseVisualStyleBackColor = true;
            // 
            // label_use_numbers
            // 
            this.label_use_numbers.AutoSize = true;
            this.label_use_numbers.Location = new System.Drawing.Point(36, 127);
            this.label_use_numbers.Name = "label_use_numbers";
            this.label_use_numbers.Size = new System.Drawing.Size(75, 13);
            this.label_use_numbers.TabIndex = 6;
            this.label_use_numbers.Text = "Use numbers?";
            // 
            // groupBox_used_case
            // 
            this.groupBox_used_case.Controls.Add(this.radioButtonLettersNone);
            this.groupBox_used_case.Controls.Add(this.radioButton_use_lower);
            this.groupBox_used_case.Controls.Add(this.radioButton_use_upper);
            this.groupBox_used_case.Controls.Add(this.radioButton_use_both_case);
            this.groupBox_used_case.Location = new System.Drawing.Point(115, 188);
            this.groupBox_used_case.Name = "groupBox_used_case";
            this.groupBox_used_case.Size = new System.Drawing.Size(309, 43);
            this.groupBox_used_case.TabIndex = 17;
            this.groupBox_used_case.TabStop = false;
            // 
            // radioButtonLettersNone
            // 
            this.radioButtonLettersNone.AutoSize = true;
            this.radioButtonLettersNone.Checked = global::ActGen.Properties.Settings.Default.use_no_letters;
            this.radioButtonLettersNone.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ActGen.Properties.Settings.Default, "use_no_letters", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioButtonLettersNone.Location = new System.Drawing.Point(250, 15);
            this.radioButtonLettersNone.Name = "radioButtonLettersNone";
            this.radioButtonLettersNone.Size = new System.Drawing.Size(51, 17);
            this.radioButtonLettersNone.TabIndex = 33;
            this.radioButtonLettersNone.Text = "None";
            this.radioButtonLettersNone.UseVisualStyleBackColor = true;
            this.radioButtonLettersNone.CheckedChanged += new System.EventHandler(this.radioButtonLettersNone_CheckedChanged);
            // 
            // checkBoxRNGCrypto
            // 
            this.checkBoxRNGCrypto.AutoSize = true;
            this.checkBoxRNGCrypto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxRNGCrypto.Checked = global::ActGen.Properties.Settings.Default.rngcrypto;
            this.checkBoxRNGCrypto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRNGCrypto.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ActGen.Properties.Settings.Default, "rngcrypto", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxRNGCrypto.Location = new System.Drawing.Point(241, 366);
            this.checkBoxRNGCrypto.Name = "checkBoxRNGCrypto";
            this.checkBoxRNGCrypto.Size = new System.Drawing.Size(183, 17);
            this.checkBoxRNGCrypto.TabIndex = 25;
            this.checkBoxRNGCrypto.Text = "Use RNGCryptoServiceProvider?";
            this.checkBoxRNGCrypto.UseVisualStyleBackColor = true;
            this.checkBoxRNGCrypto.CheckedChanged += new System.EventHandler(this.checkBoxRNGCrypto_CheckedChanged);
            // 
            // checkBox_use_numbers
            // 
            this.checkBox_use_numbers.AutoSize = true;
            this.checkBox_use_numbers.Checked = global::ActGen.Properties.Settings.Default.use_numbers;
            this.checkBox_use_numbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_use_numbers.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ActGen.Properties.Settings.Default, "use_numbers", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_use_numbers.Location = new System.Drawing.Point(127, 126);
            this.checkBox_use_numbers.Name = "checkBox_use_numbers";
            this.checkBox_use_numbers.Size = new System.Drawing.Size(15, 14);
            this.checkBox_use_numbers.TabIndex = 16;
            this.checkBox_use_numbers.UseVisualStyleBackColor = true;
            this.checkBox_use_numbers.CheckedChanged += new System.EventHandler(this.checkBox_use_numbers_CheckedChanged);
            // 
            // checkBox_save_on_exit
            // 
            this.checkBox_save_on_exit.AutoSize = true;
            this.checkBox_save_on_exit.Checked = global::ActGen.Properties.Settings.Default.save_on_exit;
            this.checkBox_save_on_exit.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ActGen.Properties.Settings.Default, "save_on_exit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_save_on_exit.Location = new System.Drawing.Point(34, 366);
            this.checkBox_save_on_exit.Name = "checkBox_save_on_exit";
            this.checkBox_save_on_exit.Size = new System.Drawing.Size(130, 17);
            this.checkBox_save_on_exit.TabIndex = 21;
            this.checkBox_save_on_exit.Text = "Save settings on exit?";
            this.checkBox_save_on_exit.UseVisualStyleBackColor = true;
            // 
            // textBox_characters_between_dashes
            // 
            this.textBox_characters_between_dashes.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ActGen.Properties.Settings.Default, "characters_between_dashes", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_characters_between_dashes.Location = new System.Drawing.Point(398, 149);
            this.textBox_characters_between_dashes.MaxLength = 2;
            this.textBox_characters_between_dashes.Name = "textBox_characters_between_dashes";
            this.textBox_characters_between_dashes.Size = new System.Drawing.Size(23, 20);
            this.textBox_characters_between_dashes.TabIndex = 15;
            this.textBox_characters_between_dashes.Text = global::ActGen.Properties.Settings.Default.characters_between_dashes;
            // 
            // textBox_include_additional_custom_characters
            // 
            this.textBox_include_additional_custom_characters.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ActGen.Properties.Settings.Default, "include_additional_custom_characters", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_include_additional_custom_characters.Location = new System.Drawing.Point(243, 313);
            this.textBox_include_additional_custom_characters.MaxLength = 91;
            this.textBox_include_additional_custom_characters.Name = "textBox_include_additional_custom_characters";
            this.textBox_include_additional_custom_characters.Size = new System.Drawing.Size(181, 20);
            this.textBox_include_additional_custom_characters.TabIndex = 20;
            this.textBox_include_additional_custom_characters.Text = global::ActGen.Properties.Settings.Default.include_additional_custom_characters;
            // 
            // textBox_remove_additional_custom_characters
            // 
            this.textBox_remove_additional_custom_characters.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ActGen.Properties.Settings.Default, "remove_additional_custom_characters", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_remove_additional_custom_characters.Location = new System.Drawing.Point(243, 277);
            this.textBox_remove_additional_custom_characters.MaxLength = 91;
            this.textBox_remove_additional_custom_characters.Name = "textBox_remove_additional_custom_characters";
            this.textBox_remove_additional_custom_characters.Size = new System.Drawing.Size(181, 20);
            this.textBox_remove_additional_custom_characters.TabIndex = 19;
            this.textBox_remove_additional_custom_characters.Text = global::ActGen.Properties.Settings.Default.remove_additional_custom_characters;
            // 
            // checkBox_avoid_characters
            // 
            this.checkBox_avoid_characters.AutoSize = true;
            this.checkBox_avoid_characters.Checked = global::ActGen.Properties.Settings.Default.avoid_characters;
            this.checkBox_avoid_characters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_avoid_characters.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ActGen.Properties.Settings.Default, "avoid_characters", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_avoid_characters.Location = new System.Drawing.Point(409, 240);
            this.checkBox_avoid_characters.Name = "checkBox_avoid_characters";
            this.checkBox_avoid_characters.Size = new System.Drawing.Size(15, 14);
            this.checkBox_avoid_characters.TabIndex = 18;
            this.checkBox_avoid_characters.UseVisualStyleBackColor = true;
            // 
            // checkBox_include_dashes
            // 
            this.checkBox_include_dashes.AutoSize = true;
            this.checkBox_include_dashes.Checked = global::ActGen.Properties.Settings.Default.include_dashes;
            this.checkBox_include_dashes.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ActGen.Properties.Settings.Default, "include_dashes", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox_include_dashes.Location = new System.Drawing.Point(127, 155);
            this.checkBox_include_dashes.Name = "checkBox_include_dashes";
            this.checkBox_include_dashes.Size = new System.Drawing.Size(15, 14);
            this.checkBox_include_dashes.TabIndex = 14;
            this.checkBox_include_dashes.UseVisualStyleBackColor = true;
            this.checkBox_include_dashes.CheckedChanged += new System.EventHandler(this.checkBox_include_dashes_CheckedChanged);
            // 
            // textBox_chars_to_make
            // 
            this.textBox_chars_to_make.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ActGen.Properties.Settings.Default, "chars_to_make", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_chars_to_make.Location = new System.Drawing.Point(398, 72);
            this.textBox_chars_to_make.MaxLength = 2;
            this.textBox_chars_to_make.Name = "textBox_chars_to_make";
            this.textBox_chars_to_make.Size = new System.Drawing.Size(23, 20);
            this.textBox_chars_to_make.TabIndex = 13;
            this.textBox_chars_to_make.Text = global::ActGen.Properties.Settings.Default.chars_to_make;
            // 
            // textBox_amount_to_generate
            // 
            this.textBox_amount_to_generate.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ActGen.Properties.Settings.Default, "amount_to_generate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_amount_to_generate.Location = new System.Drawing.Point(365, 48);
            this.textBox_amount_to_generate.MaxLength = 6;
            this.textBox_amount_to_generate.Name = "textBox_amount_to_generate";
            this.textBox_amount_to_generate.Size = new System.Drawing.Size(56, 20);
            this.textBox_amount_to_generate.TabIndex = 12;
            this.textBox_amount_to_generate.Text = global::ActGen.Properties.Settings.Default.amount_to_generate;
            // 
            // ActGenMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 430);
            this.Controls.Add(this.checkBoxRNGCrypto);
            this.Controls.Add(this.groupBox_used_case);
            this.Controls.Add(this.checkBox_use_numbers);
            this.Controls.Add(this.label_use_numbers);
            this.Controls.Add(this.checkBox_save_on_exit);
            this.Controls.Add(this.label_delimiter_note);
            this.Controls.Add(this.textBox_characters_between_dashes);
            this.Controls.Add(this.textBox_include_additional_custom_characters);
            this.Controls.Add(this.textBox_remove_additional_custom_characters);
            this.Controls.Add(this.checkBox_avoid_characters);
            this.Controls.Add(this.checkBox_include_dashes);
            this.Controls.Add(this.textBox_chars_to_make);
            this.Controls.Add(this.textBox_amount_to_generate);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_console_toggle);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.button_load_defaults);
            this.Controls.Add(this.label_include_additional_custom_characters);
            this.Controls.Add(this.label_remove_additional_custom_characters);
            this.Controls.Add(this.label_avoid_characters);
            this.Controls.Add(this.label_use_upper_lower_case);
            this.Controls.Add(this.label_characters_between_dashes);
            this.Controls.Add(this.label_include_dashes);
            this.Controls.Add(this.label_amount_unique_chars_max);
            this.Controls.Add(this.label_amount_per_code);
            this.Controls.Add(this.label_amount_to_gen_max);
            this.Controls.Add(this.label_amount_to_gen);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ActGenMainForm";
            this.Text = "ActGen:  A Serial Code & Password Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActGenMainForm_FormClosing);
            this.Load += new System.EventHandler(this.ActGenMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_used_case.ResumeLayout(false);
            this.groupBox_used_case.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_amount_to_gen;
        private System.Windows.Forms.Label label_amount_to_gen_max;
        private System.Windows.Forms.Label label_amount_per_code;
        private System.Windows.Forms.Label label_amount_unique_chars_max;
        private System.Windows.Forms.Label label_include_dashes;
        private System.Windows.Forms.Label label_characters_between_dashes;
        private System.Windows.Forms.Label label_use_upper_lower_case;
        private System.Windows.Forms.Label label_avoid_characters;
        private System.Windows.Forms.Label label_remove_additional_custom_characters;
        private System.Windows.Forms.Label label_include_additional_custom_characters;
        private System.Windows.Forms.Button button_load_defaults;
        private System.Windows.Forms.Button button_calculate;
        private System.Windows.Forms.Button button_console_toggle;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findNextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearCurrentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutWebsiteToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_amount_to_generate;
        private System.Windows.Forms.TextBox textBox_chars_to_make;
        private System.Windows.Forms.CheckBox checkBox_include_dashes;
        private System.Windows.Forms.CheckBox checkBox_avoid_characters;
        private System.Windows.Forms.TextBox textBox_remove_additional_custom_characters;
        private System.Windows.Forms.TextBox textBox_include_additional_custom_characters;
        private System.Windows.Forms.TextBox textBox_characters_between_dashes;
        private System.Windows.Forms.Label label_delimiter_note;
        private System.Windows.Forms.CheckBox checkBox_save_on_exit;
        private System.Windows.Forms.RadioButton radioButton_use_both_case;
        private System.Windows.Forms.RadioButton radioButton_use_upper;
        private System.Windows.Forms.RadioButton radioButton_use_lower;
        private System.Windows.Forms.Label label_use_numbers;
        private System.Windows.Forms.CheckBox checkBox_use_numbers;
        private System.Windows.Forms.GroupBox groupBox_used_case;
        private System.Windows.Forms.RadioButton radioButtonLettersNone;
        private System.Windows.Forms.CheckBox checkBoxRNGCrypto;
    }
}


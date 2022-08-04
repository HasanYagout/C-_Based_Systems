namespace Hotel_Management_System
{
    partial class CheckIn
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Duration_TextBox = new System.Windows.Forms.TextBox();
            this.Price_TextBox = new System.Windows.Forms.TextBox();
            this.RoomNumber_ComboBox = new System.Windows.Forms.ComboBox();
            this.Duration_label = new System.Windows.Forms.Label();
            this.Price_Label = new System.Windows.Forms.Label();
            this.RoomType_ComboBox = new System.Windows.Forms.ComboBox();
            this.RoomNumber_Label = new System.Windows.Forms.Label();
            this.RoomType_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Date_Label = new System.Windows.Forms.Label();
            this.try_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.f = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DateSubmit_Label = new System.Windows.Forms.Label();
            this.Date_submit_Label = new System.Windows.Forms.Label();
            this.IDProofSubmit_Label = new System.Windows.Forms.Label();
            this.EmailSubmit_Label = new System.Windows.Forms.Label();
            this.IDProof_submit_label = new System.Windows.Forms.Label();
            this.Email_submit_label = new System.Windows.Forms.Label();
            this.RoomNumberSubmit_Label = new System.Windows.Forms.Label();
            this.RoomNumber_submit_label = new System.Windows.Forms.Label();
            this.NameSubmit_Label = new System.Windows.Forms.Label();
            this.Name_submit_label = new System.Windows.Forms.Label();
            this.PhoneSubmit_Label = new System.Windows.Forms.Label();
            this.Phone_submit_label = new System.Windows.Forms.Label();
            this.RoomTypeSubmit_Label = new System.Windows.Forms.Label();
            this.RoomType_submit_label = new System.Windows.Forms.Label();
            this.my_DataBaseDataSet1 = new Hotel_Management_System.My_DataBaseDataSet();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Phone_Label = new System.Windows.Forms.Label();
            this.Email_Label = new System.Windows.Forms.Label();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.Email_TextBox = new System.Windows.Forms.TextBox();
            this.IDProof_Label = new System.Windows.Forms.Label();
            this.IDProof_ComboBox = new System.Windows.Forms.ComboBox();
            this.Phone_TextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Clear_Button = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_DataBaseDataSet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Duration_label);
            this.groupBox2.Controls.Add(this.Price_Label);
            this.groupBox2.Controls.Add(this.RoomNumber_Label);
            this.groupBox2.Controls.Add(this.RoomType_Label);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(34, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 208);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room Information";
            // 
            // Duration_TextBox
            // 
            this.Duration_TextBox.Location = new System.Drawing.Point(180, 126);
            this.Duration_TextBox.Name = "Duration_TextBox";
            this.Duration_TextBox.Size = new System.Drawing.Size(121, 22);
            this.Duration_TextBox.TabIndex = 3;
            this.Duration_TextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Duration_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.durationTextBox_KeyPress);
            this.Duration_TextBox.Validating += new System.ComponentModel.CancelEventHandler(this.durationTextBox_Validating);
            // 
            // Price_TextBox
            // 
            this.Price_TextBox.Location = new System.Drawing.Point(180, 164);
            this.Price_TextBox.Name = "Price_TextBox";
            this.Price_TextBox.Size = new System.Drawing.Size(121, 22);
            this.Price_TextBox.TabIndex = 3;
            this.Price_TextBox.TextChanged += new System.EventHandler(this.Price_txb_TextChanged);
            // 
            // RoomNumber_ComboBox
            // 
            this.RoomNumber_ComboBox.FormattingEnabled = true;
            this.RoomNumber_ComboBox.Location = new System.Drawing.Point(180, 84);
            this.RoomNumber_ComboBox.Name = "RoomNumber_ComboBox";
            this.RoomNumber_ComboBox.Size = new System.Drawing.Size(121, 24);
            this.RoomNumber_ComboBox.TabIndex = 2;
            this.RoomNumber_ComboBox.SelectedIndexChanged += new System.EventHandler(this.cb_RoomNumber_SelectedIndexChanged);
            this.RoomNumber_ComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_RoomNumber_KeyPress);
            // 
            // Duration_label
            // 
            this.Duration_label.AutoSize = true;
            this.Duration_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration_label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Duration_label.Location = new System.Drawing.Point(23, 129);
            this.Duration_label.Name = "Duration_label";
            this.Duration_label.Size = new System.Drawing.Size(85, 25);
            this.Duration_label.TabIndex = 0;
            this.Duration_label.Text = "Duration";
            // 
            // Price_Label
            // 
            this.Price_Label.AutoSize = true;
            this.Price_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_Label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Price_Label.Location = new System.Drawing.Point(23, 167);
            this.Price_Label.Name = "Price_Label";
            this.Price_Label.Size = new System.Drawing.Size(56, 25);
            this.Price_Label.TabIndex = 0;
            this.Price_Label.Text = "Price";
            // 
            // RoomType_ComboBox
            // 
            this.RoomType_ComboBox.FormattingEnabled = true;
            this.RoomType_ComboBox.Location = new System.Drawing.Point(180, 38);
            this.RoomType_ComboBox.Name = "RoomType_ComboBox";
            this.RoomType_ComboBox.Size = new System.Drawing.Size(121, 24);
            this.RoomType_ComboBox.TabIndex = 1;
            this.RoomType_ComboBox.SelectedIndexChanged += new System.EventHandler(this.cm_RoomType_SelectedIndexChanged);
            this.RoomType_ComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cm_RoomType_KeyPress);
            // 
            // RoomNumber_Label
            // 
            this.RoomNumber_Label.AutoSize = true;
            this.RoomNumber_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNumber_Label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RoomNumber_Label.Location = new System.Drawing.Point(23, 86);
            this.RoomNumber_Label.Name = "RoomNumber_Label";
            this.RoomNumber_Label.Size = new System.Drawing.Size(137, 25);
            this.RoomNumber_Label.TabIndex = 0;
            this.RoomNumber_Label.Text = "Room Number";
            // 
            // RoomType_Label
            // 
            this.RoomType_Label.AutoSize = true;
            this.RoomType_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomType_Label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RoomType_Label.Location = new System.Drawing.Point(23, 41);
            this.RoomType_Label.Name = "RoomType_Label";
            this.RoomType_Label.Size = new System.Drawing.Size(113, 25);
            this.RoomType_Label.TabIndex = 0;
            this.RoomType_Label.Text = "Room Type";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(36, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 208);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Price_TextBox);
            this.panel3.Controls.Add(this.Duration_TextBox);
            this.panel3.Controls.Add(this.RoomNumber_ComboBox);
            this.panel3.Controls.Add(this.RoomType_ComboBox);
            this.panel3.Location = new System.Drawing.Point(2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 208);
            this.panel3.TabIndex = 5;
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.BackColor = System.Drawing.Color.Transparent;
            this.Date_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Date_Label.Location = new System.Drawing.Point(31, 47);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(53, 25);
            this.Date_Label.TabIndex = 1;
            this.Date_Label.Text = "Date";
            // 
            // try_label
            // 
            this.try_label.AutoSize = true;
            this.try_label.Location = new System.Drawing.Point(262, 55);
            this.try_label.Name = "try_label";
            this.try_label.Size = new System.Drawing.Size(0, 17);
            this.try_label.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.BackColor = System.Drawing.Color.Transparent;
            this.Date.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Date.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Date.Location = new System.Drawing.Point(105, 51);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(24, 21);
            this.Date.TabIndex = 5;
            this.Date.Text = "[]";
            this.Date.Click += new System.EventHandler(this.label13_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 36);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.BackColor = System.Drawing.Color.Transparent;
            this.f.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.f.Location = new System.Drawing.Point(463, 33);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(53, 25);
            this.f.TabIndex = 6;
            this.f.Text = "Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(463, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 25);
            this.label11.TabIndex = 6;
            this.label11.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(463, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "Phone";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(500, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DateSubmit_Label
            // 
            this.DateSubmit_Label.AutoSize = true;
            this.DateSubmit_Label.BackColor = System.Drawing.Color.Transparent;
            this.DateSubmit_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateSubmit_Label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DateSubmit_Label.Location = new System.Drawing.Point(463, 33);
            this.DateSubmit_Label.Name = "DateSubmit_Label";
            this.DateSubmit_Label.Size = new System.Drawing.Size(53, 25);
            this.DateSubmit_Label.TabIndex = 6;
            this.DateSubmit_Label.Text = "Date";
            // 
            // Date_submit_Label
            // 
            this.Date_submit_Label.AutoSize = true;
            this.Date_submit_Label.BackColor = System.Drawing.Color.Transparent;
            this.Date_submit_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_submit_Label.ForeColor = System.Drawing.Color.White;
            this.Date_submit_Label.Location = new System.Drawing.Point(622, 33);
            this.Date_submit_Label.Name = "Date_submit_Label";
            this.Date_submit_Label.Size = new System.Drawing.Size(24, 25);
            this.Date_submit_Label.TabIndex = 6;
            this.Date_submit_Label.Text = "[]";
            // 
            // IDProofSubmit_Label
            // 
            this.IDProofSubmit_Label.AutoSize = true;
            this.IDProofSubmit_Label.BackColor = System.Drawing.Color.Transparent;
            this.IDProofSubmit_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDProofSubmit_Label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.IDProofSubmit_Label.Location = new System.Drawing.Point(463, 216);
            this.IDProofSubmit_Label.Name = "IDProofSubmit_Label";
            this.IDProofSubmit_Label.Size = new System.Drawing.Size(80, 25);
            this.IDProofSubmit_Label.TabIndex = 6;
            this.IDProofSubmit_Label.Text = "ID proof";
            // 
            // EmailSubmit_Label
            // 
            this.EmailSubmit_Label.AutoSize = true;
            this.EmailSubmit_Label.BackColor = System.Drawing.Color.Transparent;
            this.EmailSubmit_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailSubmit_Label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.EmailSubmit_Label.Location = new System.Drawing.Point(463, 174);
            this.EmailSubmit_Label.Name = "EmailSubmit_Label";
            this.EmailSubmit_Label.Size = new System.Drawing.Size(60, 25);
            this.EmailSubmit_Label.TabIndex = 6;
            this.EmailSubmit_Label.Text = "Email";
            // 
            // IDProof_submit_label
            // 
            this.IDProof_submit_label.AutoSize = true;
            this.IDProof_submit_label.BackColor = System.Drawing.Color.Transparent;
            this.IDProof_submit_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDProof_submit_label.ForeColor = System.Drawing.Color.White;
            this.IDProof_submit_label.Location = new System.Drawing.Point(622, 216);
            this.IDProof_submit_label.Name = "IDProof_submit_label";
            this.IDProof_submit_label.Size = new System.Drawing.Size(24, 25);
            this.IDProof_submit_label.TabIndex = 6;
            this.IDProof_submit_label.Text = "[]";
            // 
            // Email_submit_label
            // 
            this.Email_submit_label.AutoSize = true;
            this.Email_submit_label.BackColor = System.Drawing.Color.Transparent;
            this.Email_submit_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_submit_label.ForeColor = System.Drawing.Color.White;
            this.Email_submit_label.Location = new System.Drawing.Point(622, 174);
            this.Email_submit_label.Name = "Email_submit_label";
            this.Email_submit_label.Size = new System.Drawing.Size(24, 25);
            this.Email_submit_label.TabIndex = 6;
            this.Email_submit_label.Text = "[]";
            // 
            // RoomNumberSubmit_Label
            // 
            this.RoomNumberSubmit_Label.AutoSize = true;
            this.RoomNumberSubmit_Label.BackColor = System.Drawing.Color.Transparent;
            this.RoomNumberSubmit_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNumberSubmit_Label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RoomNumberSubmit_Label.Location = new System.Drawing.Point(463, 314);
            this.RoomNumberSubmit_Label.Name = "RoomNumberSubmit_Label";
            this.RoomNumberSubmit_Label.Size = new System.Drawing.Size(137, 25);
            this.RoomNumberSubmit_Label.TabIndex = 6;
            this.RoomNumberSubmit_Label.Text = "Room Number";
            // 
            // RoomNumber_submit_label
            // 
            this.RoomNumber_submit_label.AutoSize = true;
            this.RoomNumber_submit_label.BackColor = System.Drawing.Color.Transparent;
            this.RoomNumber_submit_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNumber_submit_label.ForeColor = System.Drawing.Color.White;
            this.RoomNumber_submit_label.Location = new System.Drawing.Point(622, 314);
            this.RoomNumber_submit_label.Name = "RoomNumber_submit_label";
            this.RoomNumber_submit_label.Size = new System.Drawing.Size(24, 25);
            this.RoomNumber_submit_label.TabIndex = 6;
            this.RoomNumber_submit_label.Text = "[]";
            // 
            // NameSubmit_Label
            // 
            this.NameSubmit_Label.AutoSize = true;
            this.NameSubmit_Label.BackColor = System.Drawing.Color.Transparent;
            this.NameSubmit_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameSubmit_Label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NameSubmit_Label.Location = new System.Drawing.Point(463, 83);
            this.NameSubmit_Label.Name = "NameSubmit_Label";
            this.NameSubmit_Label.Size = new System.Drawing.Size(64, 25);
            this.NameSubmit_Label.TabIndex = 6;
            this.NameSubmit_Label.Text = "Name";
            // 
            // Name_submit_label
            // 
            this.Name_submit_label.AutoSize = true;
            this.Name_submit_label.BackColor = System.Drawing.Color.Transparent;
            this.Name_submit_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_submit_label.ForeColor = System.Drawing.Color.White;
            this.Name_submit_label.Location = new System.Drawing.Point(622, 83);
            this.Name_submit_label.Name = "Name_submit_label";
            this.Name_submit_label.Size = new System.Drawing.Size(24, 25);
            this.Name_submit_label.TabIndex = 6;
            this.Name_submit_label.Text = "[]";
            // 
            // PhoneSubmit_Label
            // 
            this.PhoneSubmit_Label.AutoSize = true;
            this.PhoneSubmit_Label.BackColor = System.Drawing.Color.Transparent;
            this.PhoneSubmit_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneSubmit_Label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PhoneSubmit_Label.Location = new System.Drawing.Point(463, 130);
            this.PhoneSubmit_Label.Name = "PhoneSubmit_Label";
            this.PhoneSubmit_Label.Size = new System.Drawing.Size(69, 25);
            this.PhoneSubmit_Label.TabIndex = 6;
            this.PhoneSubmit_Label.Text = "Phone";
            // 
            // Phone_submit_label
            // 
            this.Phone_submit_label.AutoSize = true;
            this.Phone_submit_label.BackColor = System.Drawing.Color.Transparent;
            this.Phone_submit_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_submit_label.ForeColor = System.Drawing.Color.White;
            this.Phone_submit_label.Location = new System.Drawing.Point(622, 130);
            this.Phone_submit_label.Name = "Phone_submit_label";
            this.Phone_submit_label.Size = new System.Drawing.Size(24, 25);
            this.Phone_submit_label.TabIndex = 6;
            this.Phone_submit_label.Text = "[]";
            // 
            // RoomTypeSubmit_Label
            // 
            this.RoomTypeSubmit_Label.AutoSize = true;
            this.RoomTypeSubmit_Label.BackColor = System.Drawing.Color.Transparent;
            this.RoomTypeSubmit_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomTypeSubmit_Label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RoomTypeSubmit_Label.Location = new System.Drawing.Point(463, 266);
            this.RoomTypeSubmit_Label.Name = "RoomTypeSubmit_Label";
            this.RoomTypeSubmit_Label.Size = new System.Drawing.Size(113, 25);
            this.RoomTypeSubmit_Label.TabIndex = 6;
            this.RoomTypeSubmit_Label.Text = "Room Type";
            // 
            // RoomType_submit_label
            // 
            this.RoomType_submit_label.AutoSize = true;
            this.RoomType_submit_label.BackColor = System.Drawing.Color.Transparent;
            this.RoomType_submit_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomType_submit_label.ForeColor = System.Drawing.Color.White;
            this.RoomType_submit_label.Location = new System.Drawing.Point(622, 266);
            this.RoomType_submit_label.Name = "RoomType_submit_label";
            this.RoomType_submit_label.Size = new System.Drawing.Size(24, 25);
            this.RoomType_submit_label.TabIndex = 6;
            this.RoomType_submit_label.Text = "[]";
            // 
            // my_DataBaseDataSet1
            // 
            this.my_DataBaseDataSet1.DataSetName = "My_DataBaseDataSet";
            this.my_DataBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Save_btn.FlatAppearance.BorderSize = 0;
            this.Save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_btn.ForeColor = System.Drawing.Color.White;
            this.Save_btn.Location = new System.Drawing.Point(652, 461);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(126, 42);
            this.Save_btn.TabIndex = 9;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name_Label.Location = new System.Drawing.Point(21, 41);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(69, 25);
            this.Name_Label.TabIndex = 0;
            this.Name_Label.Text = "Name ";
            // 
            // Phone_Label
            // 
            this.Phone_Label.AutoSize = true;
            this.Phone_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_Label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Phone_Label.Location = new System.Drawing.Point(21, 81);
            this.Phone_Label.Name = "Phone_Label";
            this.Phone_Label.Size = new System.Drawing.Size(69, 25);
            this.Phone_Label.TabIndex = 0;
            this.Phone_Label.Text = "Phone";
            // 
            // Email_Label
            // 
            this.Email_Label.AutoSize = true;
            this.Email_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_Label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Email_Label.Location = new System.Drawing.Point(21, 120);
            this.Email_Label.Name = "Email_Label";
            this.Email_Label.Size = new System.Drawing.Size(60, 25);
            this.Email_Label.TabIndex = 0;
            this.Email_Label.Text = "Email";
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(120, 41);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(212, 22);
            this.Name_TextBox.TabIndex = 1;
            this.Name_TextBox.TextChanged += new System.EventHandler(this.Name_txb_TextChanged);
            this.Name_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_txb_KeyPress);
            // 
            // Email_TextBox
            // 
            this.Email_TextBox.Location = new System.Drawing.Point(120, 120);
            this.Email_TextBox.Name = "Email_TextBox";
            this.Email_TextBox.Size = new System.Drawing.Size(212, 22);
            this.Email_TextBox.TabIndex = 1;
            this.Email_TextBox.TextChanged += new System.EventHandler(this.Email_txb_TextChanged);
            this.Email_TextBox.Validating += new System.ComponentModel.CancelEventHandler(this.Email_txb_Validating);
            // 
            // IDProof_Label
            // 
            this.IDProof_Label.AutoSize = true;
            this.IDProof_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDProof_Label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.IDProof_Label.Location = new System.Drawing.Point(21, 164);
            this.IDProof_Label.Name = "IDProof_Label";
            this.IDProof_Label.Size = new System.Drawing.Size(80, 25);
            this.IDProof_Label.TabIndex = 2;
            this.IDProof_Label.Text = "ID proof";
            // 
            // IDProof_ComboBox
            // 
            this.IDProof_ComboBox.FormattingEnabled = true;
            this.IDProof_ComboBox.Items.AddRange(new object[] {
            "Passport",
            "Personal \tID"});
            this.IDProof_ComboBox.Location = new System.Drawing.Point(120, 168);
            this.IDProof_ComboBox.Name = "IDProof_ComboBox";
            this.IDProof_ComboBox.Size = new System.Drawing.Size(121, 24);
            this.IDProof_ComboBox.TabIndex = 1;
            this.IDProof_ComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_IDProof_KeyPress);
            // 
            // Phone_TextBox
            // 
            this.Phone_TextBox.Location = new System.Drawing.Point(120, 81);
            this.Phone_TextBox.Mask = "(999) 000-0000";
            this.Phone_TextBox.Name = "Phone_TextBox";
            this.Phone_TextBox.Size = new System.Drawing.Size(212, 22);
            this.Phone_TextBox.TabIndex = 2;
            this.Phone_TextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.Phone_TextBox);
            this.groupBox3.Controls.Add(this.IDProof_ComboBox);
            this.groupBox3.Controls.Add(this.IDProof_Label);
            this.groupBox3.Controls.Add(this.Email_TextBox);
            this.groupBox3.Controls.Add(this.Name_TextBox);
            this.groupBox3.Controls.Add(this.Email_Label);
            this.groupBox3.Controls.Add(this.Phone_Label);
            this.groupBox3.Controls.Add(this.Name_Label);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox3.Location = new System.Drawing.Point(34, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 208);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Guest Information";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Clear_Button
            // 
            this.Clear_Button.BackColor = System.Drawing.Color.DodgerBlue;
            this.Clear_Button.FlatAppearance.BorderSize = 0;
            this.Clear_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Button.ForeColor = System.Drawing.Color.White;
            this.Clear_Button.Location = new System.Drawing.Point(803, 461);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(126, 42);
            this.Clear_Button.TabIndex = 9;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = false;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::Hotel_Management_System.Properties.Resources.Lawrencium;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1166, 700);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.try_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Date_Label);
            this.Controls.Add(this.RoomType_submit_label);
            this.Controls.Add(this.RoomTypeSubmit_Label);
            this.Controls.Add(this.Phone_submit_label);
            this.Controls.Add(this.PhoneSubmit_Label);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Name_submit_label);
            this.Controls.Add(this.NameSubmit_Label);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RoomNumber_submit_label);
            this.Controls.Add(this.RoomNumberSubmit_Label);
            this.Controls.Add(this.Email_submit_label);
            this.Controls.Add(this.IDProof_submit_label);
            this.Controls.Add(this.EmailSubmit_Label);
            this.Controls.Add(this.IDProofSubmit_Label);
            this.Controls.Add(this.Date_submit_Label);
            this.Controls.Add(this.DateSubmit_Label);
            this.Controls.Add(this.f);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckIn";
            this.Text = "CheckIn";
            this.Load += new System.EventHandler(this.CheckIn_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.my_DataBaseDataSet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label RoomNumber_Label;
        private System.Windows.Forms.Label Duration_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Date_Label;
        private System.Windows.Forms.Label try_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ComboBox RoomNumber_ComboBox;
        private System.Windows.Forms.Label f;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label DateSubmit_Label;
        private System.Windows.Forms.Label Date_submit_Label;
        private System.Windows.Forms.Label IDProofSubmit_Label;
        private System.Windows.Forms.Label EmailSubmit_Label;
        private System.Windows.Forms.Label IDProof_submit_label;
        private System.Windows.Forms.Label Email_submit_label;
        private System.Windows.Forms.Label RoomNumberSubmit_Label;
        private System.Windows.Forms.Label RoomNumber_submit_label;
        private System.Windows.Forms.Label NameSubmit_Label;
        private System.Windows.Forms.Label Name_submit_label;
        private System.Windows.Forms.Label PhoneSubmit_Label;
        private System.Windows.Forms.Label Phone_submit_label;
        private System.Windows.Forms.Label RoomTypeSubmit_Label;
        private System.Windows.Forms.Label RoomType_submit_label;
        private My_DataBaseDataSet my_DataBaseDataSet1;
        private System.Windows.Forms.TextBox Price_TextBox;
        private System.Windows.Forms.TextBox Duration_TextBox;
        private System.Windows.Forms.Label Price_Label;
        private System.Windows.Forms.ComboBox RoomType_ComboBox;
        private System.Windows.Forms.Label RoomType_Label;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label Phone_Label;
        private System.Windows.Forms.Label Email_Label;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.TextBox Email_TextBox;
        private System.Windows.Forms.Label IDProof_Label;
        private System.Windows.Forms.ComboBox IDProof_ComboBox;
        private System.Windows.Forms.MaskedTextBox Phone_TextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Clear_Button;
    }
}
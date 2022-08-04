namespace Hotel_Management_System
{
    partial class ManageUsers
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
            this.Username_Label = new System.Windows.Forms.Label();
            this.ID_Label = new System.Windows.Forms.Label();
            this.UserName_TextBox = new System.Windows.Forms.TextBox();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.Password_Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.users_dataset = new Hotel_Management_System.Users_dataset();
            this.Position_ComboBox = new System.Windows.Forms.ComboBox();
            this.Position_Label = new System.Windows.Forms.Label();
            this.my_DataBaseDataSet5 = new Hotel_Management_System.My_DataBaseDataSet5();
            this.myDataBaseDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.my_DataBaseDataSet4 = new Hotel_Management_System.My_DataBaseDataSet4();
            this.myDataBaseDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Hotel_Management_System.Users_datasetTableAdapters.UsersTableAdapter();
            this.DBID_Label = new System.Windows.Forms.Label();
            this.Access_Label = new System.Windows.Forms.Label();
            this.Access_ComboBox = new System.Windows.Forms.ComboBox();
            this.ConfirmPassword_Label = new System.Windows.Forms.Label();
            this.ConfirmPassword_TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_DataBaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_DataBaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.BackColor = System.Drawing.Color.Transparent;
            this.Username_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Username_Label.Location = new System.Drawing.Point(43, 110);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(132, 29);
            this.Username_Label.TabIndex = 0;
            this.Username_Label.Text = "Username";
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.BackColor = System.Drawing.Color.Transparent;
            this.ID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ID_Label.Location = new System.Drawing.Point(43, 49);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(38, 29);
            this.ID_Label.TabIndex = 1;
            this.ID_Label.Text = "ID";
            // 
            // UserName_TextBox
            // 
            this.UserName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_TextBox.Location = new System.Drawing.Point(196, 110);
            this.UserName_TextBox.Name = "UserName_TextBox";
            this.UserName_TextBox.Size = new System.Drawing.Size(176, 32);
            this.UserName_TextBox.TabIndex = 2;
            this.UserName_TextBox.TextChanged += new System.EventHandler(this.UserName_TextBox_TextChanged);
            this.UserName_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserName_TextBox_KeyPress);
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_TextBox.Location = new System.Drawing.Point(196, 226);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(176, 32);
            this.Password_TextBox.TabIndex = 2;
            this.Password_TextBox.TextChanged += new System.EventHandler(this.Password_TextBox_TextChanged);
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.BackColor = System.Drawing.Color.Transparent;
            this.Password_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Password_Label.Location = new System.Drawing.Point(43, 228);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(128, 29);
            this.Password_Label.TabIndex = 1;
            this.Password_Label.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 1;
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.Color.DodgerBlue;
            this.Add_Button.FlatAppearance.BorderSize = 0;
            this.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Button.ForeColor = System.Drawing.Color.White;
            this.Add_Button.Location = new System.Drawing.Point(151, 603);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(176, 42);
            this.Add_Button.TabIndex = 3;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.BackColor = System.Drawing.Color.DodgerBlue;
            this.Update_Button.FlatAppearance.BorderSize = 0;
            this.Update_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Button.ForeColor = System.Drawing.Color.White;
            this.Update_Button.Location = new System.Drawing.Point(355, 603);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(176, 42);
            this.Update_Button.TabIndex = 3;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = false;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.BackColor = System.Drawing.Color.DodgerBlue;
            this.Clear_Button.FlatAppearance.BorderSize = 0;
            this.Clear_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Button.ForeColor = System.Drawing.Color.White;
            this.Clear_Button.Location = new System.Drawing.Point(563, 603);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(176, 42);
            this.Clear_Button.TabIndex = 3;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = false;
            this.Clear_Button.Click += new System.EventHandler(this.button3_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.AutoGenerateColumns = false;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn});
            this.DataGridView.DataSource = this.usersBindingSource;
            this.DataGridView.Location = new System.Drawing.Point(442, 110);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(446, 285);
            this.DataGridView.TabIndex = 4;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.users_dataset;
            // 
            // users_dataset
            // 
            this.users_dataset.DataSetName = "Users_dataset";
            this.users_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Position_ComboBox
            // 
            this.Position_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Position_ComboBox.FormattingEnabled = true;
            this.Position_ComboBox.Items.AddRange(new object[] {
            "Admin",
            "User\t"});
            this.Position_ComboBox.Location = new System.Drawing.Point(196, 365);
            this.Position_ComboBox.Name = "Position_ComboBox";
            this.Position_ComboBox.Size = new System.Drawing.Size(176, 34);
            this.Position_ComboBox.TabIndex = 5;
            this.Position_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Position_ComboBox_SelectedIndexChanged);
            this.Position_ComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // Position_Label
            // 
            this.Position_Label.AutoSize = true;
            this.Position_Label.BackColor = System.Drawing.Color.Transparent;
            this.Position_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Position_Label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Position_Label.Location = new System.Drawing.Point(43, 366);
            this.Position_Label.Name = "Position_Label";
            this.Position_Label.Size = new System.Drawing.Size(108, 29);
            this.Position_Label.TabIndex = 1;
            this.Position_Label.Text = "Position";
            // 
            // my_DataBaseDataSet5
            // 
            this.my_DataBaseDataSet5.DataSetName = "My_DataBaseDataSet5";
            this.my_DataBaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myDataBaseDataSet5BindingSource
            // 
            this.myDataBaseDataSet5BindingSource.DataSource = this.my_DataBaseDataSet5;
            this.myDataBaseDataSet5BindingSource.Position = 0;
            // 
            // my_DataBaseDataSet4
            // 
            this.my_DataBaseDataSet4.DataSetName = "My_DataBaseDataSet4";
            this.my_DataBaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myDataBaseDataSet4BindingSource
            // 
            this.myDataBaseDataSet4BindingSource.DataSource = this.my_DataBaseDataSet4;
            this.myDataBaseDataSet4BindingSource.Position = 0;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // DBID_Label
            // 
            this.DBID_Label.AutoSize = true;
            this.DBID_Label.BackColor = System.Drawing.Color.Transparent;
            this.DBID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBID_Label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.DBID_Label.Location = new System.Drawing.Point(191, 49);
            this.DBID_Label.Name = "DBID_Label";
            this.DBID_Label.Size = new System.Drawing.Size(55, 29);
            this.DBID_Label.TabIndex = 6;
            this.DBID_Label.Text = "null";
            // 
            // Access_Label
            // 
            this.Access_Label.AutoSize = true;
            this.Access_Label.BackColor = System.Drawing.Color.Transparent;
            this.Access_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Access_Label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Access_Label.Location = new System.Drawing.Point(43, 169);
            this.Access_Label.Name = "Access_Label";
            this.Access_Label.Size = new System.Drawing.Size(96, 29);
            this.Access_Label.TabIndex = 7;
            this.Access_Label.Text = "Access";
            // 
            // Access_ComboBox
            // 
            this.Access_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Access_ComboBox.FormattingEnabled = true;
            this.Access_ComboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.Access_ComboBox.Location = new System.Drawing.Point(196, 167);
            this.Access_ComboBox.Name = "Access_ComboBox";
            this.Access_ComboBox.Size = new System.Drawing.Size(176, 34);
            this.Access_ComboBox.TabIndex = 8;
            this.Access_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Access_ComboBox_SelectedIndexChanged);
            this.Access_ComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_KeyPress);
            // 
            // ConfirmPassword_Label
            // 
            this.ConfirmPassword_Label.AutoSize = true;
            this.ConfirmPassword_Label.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmPassword_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword_Label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ConfirmPassword_Label.Location = new System.Drawing.Point(43, 287);
            this.ConfirmPassword_Label.Name = "ConfirmPassword_Label";
            this.ConfirmPassword_Label.Size = new System.Drawing.Size(128, 58);
            this.ConfirmPassword_Label.TabIndex = 1;
            this.ConfirmPassword_Label.Text = "Confirm\r\nPassword";
            // 
            // ConfirmPassword_TextBox
            // 
            this.ConfirmPassword_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword_TextBox.Location = new System.Drawing.Point(196, 304);
            this.ConfirmPassword_TextBox.Name = "ConfirmPassword_TextBox";
            this.ConfirmPassword_TextBox.Size = new System.Drawing.Size(176, 32);
            this.ConfirmPassword_TextBox.TabIndex = 2;
            this.ConfirmPassword_TextBox.TextChanged += new System.EventHandler(this.Password_TextBox_TextChanged);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Management_System.Properties.Resources.Lawrencium;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.Access_ComboBox);
            this.Controls.Add(this.Access_Label);
            this.Controls.Add(this.DBID_Label);
            this.Controls.Add(this.Position_ComboBox);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.ConfirmPassword_TextBox);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Position_Label);
            this.Controls.Add(this.ConfirmPassword_Label);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.UserName_TextBox);
            this.Controls.Add(this.ID_Label);
            this.Controls.Add(this.Username_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_DataBaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_DataBaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet4BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.Label ID_Label;
        private System.Windows.Forms.TextBox UserName_TextBox;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.BindingSource myDataBaseDataSet4BindingSource;
        private My_DataBaseDataSet4 my_DataBaseDataSet4;
        private System.Windows.Forms.ComboBox Position_ComboBox;
        private System.Windows.Forms.Label Position_Label;
        private My_DataBaseDataSet5 my_DataBaseDataSet5;
        private System.Windows.Forms.BindingSource myDataBaseDataSet5BindingSource;
        private Users_dataset users_dataset;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Users_datasetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label DBID_Label;
        private System.Windows.Forms.Label Access_Label;
        private System.Windows.Forms.ComboBox Access_ComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label ConfirmPassword_Label;
        private System.Windows.Forms.TextBox ConfirmPassword_TextBox;
    }
}
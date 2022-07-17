namespace Hotel_Management_System
{
    partial class Register
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
            this.Register_Name_Label = new System.Windows.Forms.Label();
            this.Register_Password_Label = new System.Windows.Forms.Label();
            this.Register_Name_TextBox = new System.Windows.Forms.TextBox();
            this.Register_Password_TextBox = new System.Windows.Forms.TextBox();
            this.Register_Sign_Up_Button = new System.Windows.Forms.Button();
            this.Register_Clear_Button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.my_DataBaseDataSet5 = new Hotel_Management_System.My_DataBaseDataSet5();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Hotel_Management_System.My_DataBaseDataSet5TableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_DataBaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Register_Name_Label
            // 
            this.Register_Name_Label.AutoSize = true;
            this.Register_Name_Label.Location = new System.Drawing.Point(29, 43);
            this.Register_Name_Label.Name = "Register_Name_Label";
            this.Register_Name_Label.Size = new System.Drawing.Size(45, 17);
            this.Register_Name_Label.TabIndex = 0;
            this.Register_Name_Label.Text = "Name";
            // 
            // Register_Password_Label
            // 
            this.Register_Password_Label.AutoSize = true;
            this.Register_Password_Label.Location = new System.Drawing.Point(29, 80);
            this.Register_Password_Label.Name = "Register_Password_Label";
            this.Register_Password_Label.Size = new System.Drawing.Size(69, 17);
            this.Register_Password_Label.TabIndex = 1;
            this.Register_Password_Label.Text = "Password";
            // 
            // Register_Name_TextBox
            // 
            this.Register_Name_TextBox.CausesValidation = false;
            this.Register_Name_TextBox.Location = new System.Drawing.Point(196, 40);
            this.Register_Name_TextBox.Name = "Register_Name_TextBox";
            this.Register_Name_TextBox.Size = new System.Drawing.Size(100, 22);
            this.Register_Name_TextBox.TabIndex = 3;
            // 
            // Register_Password_TextBox
            // 
            this.Register_Password_TextBox.CausesValidation = false;
            this.Register_Password_TextBox.Location = new System.Drawing.Point(196, 77);
            this.Register_Password_TextBox.Name = "Register_Password_TextBox";
            this.Register_Password_TextBox.PasswordChar = '*';
            this.Register_Password_TextBox.Size = new System.Drawing.Size(100, 22);
            this.Register_Password_TextBox.TabIndex = 4;
            // 
            // Register_Sign_Up_Button
            // 
            this.Register_Sign_Up_Button.Location = new System.Drawing.Point(32, 189);
            this.Register_Sign_Up_Button.Name = "Register_Sign_Up_Button";
            this.Register_Sign_Up_Button.Size = new System.Drawing.Size(75, 23);
            this.Register_Sign_Up_Button.TabIndex = 6;
            this.Register_Sign_Up_Button.Text = "Sign Up";
            this.Register_Sign_Up_Button.UseVisualStyleBackColor = true;
            this.Register_Sign_Up_Button.Click += new System.EventHandler(this.Register_Sign_Up_Button_Click);
            // 
            // Register_Clear_Button
            // 
            this.Register_Clear_Button.Location = new System.Drawing.Point(196, 189);
            this.Register_Clear_Button.Name = "Register_Clear_Button";
            this.Register_Clear_Button.Size = new System.Drawing.Size(75, 23);
            this.Register_Clear_Button.TabIndex = 7;
            this.Register_Clear_Button.Text = "Clear";
            this.Register_Clear_Button.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(494, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // my_DataBaseDataSet5
            // 
            this.my_DataBaseDataSet5.DataSetName = "My_DataBaseDataSet5";
            this.my_DataBaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.my_DataBaseDataSet5;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(568, 577);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Register_Clear_Button);
            this.Controls.Add(this.Register_Sign_Up_Button);
            this.Controls.Add(this.Register_Password_TextBox);
            this.Controls.Add(this.Register_Name_TextBox);
            this.Controls.Add(this.Register_Password_Label);
            this.Controls.Add(this.Register_Name_Label);
            this.Name = "Register";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_DataBaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Register_Name_Label;
        private System.Windows.Forms.Label Register_Password_Label;
        private System.Windows.Forms.TextBox Register_Name_TextBox;
        private System.Windows.Forms.TextBox Register_Password_TextBox;
        private System.Windows.Forms.Button Register_Sign_Up_Button;
        private System.Windows.Forms.Button Register_Clear_Button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private My_DataBaseDataSet5 my_DataBaseDataSet5;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private My_DataBaseDataSet5TableAdapters.UsersTableAdapter usersTableAdapter;
    }
}
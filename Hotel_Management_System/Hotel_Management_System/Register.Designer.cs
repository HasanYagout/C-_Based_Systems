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
            this.Name_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.SignUp_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.my_DataBaseDataSet5 = new Hotel_Management_System.My_DataBaseDataSet5();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Hotel_Management_System.My_DataBaseDataSet5TableAdapters.UsersTableAdapter();
            this.ConfirmPassword_Label = new System.Windows.Forms.Label();
            this.ConfirmPassword_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.my_DataBaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.BackColor = System.Drawing.Color.Transparent;
            this.Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Name_Label.Location = new System.Drawing.Point(237, 111);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(82, 29);
            this.Name_Label.TabIndex = 0;
            this.Name_Label.Text = "Name";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.BackColor = System.Drawing.Color.Transparent;
            this.Password_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Password_Label.Location = new System.Drawing.Point(237, 182);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(128, 29);
            this.Password_Label.TabIndex = 1;
            this.Password_Label.Text = "Password";
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.CausesValidation = false;
            this.Name_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_TextBox.Location = new System.Drawing.Point(480, 111);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(179, 34);
            this.Name_TextBox.TabIndex = 3;
            this.Name_TextBox.TextChanged += new System.EventHandler(this.Name_TextBox_TextChanged);
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.CausesValidation = false;
            this.Password_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_TextBox.Location = new System.Drawing.Point(480, 177);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.PasswordChar = '*';
            this.Password_TextBox.Size = new System.Drawing.Size(179, 34);
            this.Password_TextBox.TabIndex = 4;
            this.Password_TextBox.TextChanged += new System.EventHandler(this.Password_TextBox_TextChanged);
            // 
            // SignUp_Button
            // 
            this.SignUp_Button.BackColor = System.Drawing.Color.DodgerBlue;
            this.SignUp_Button.FlatAppearance.BorderSize = 0;
            this.SignUp_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUp_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp_Button.ForeColor = System.Drawing.Color.White;
            this.SignUp_Button.Location = new System.Drawing.Point(304, 368);
            this.SignUp_Button.Name = "SignUp_Button";
            this.SignUp_Button.Size = new System.Drawing.Size(111, 48);
            this.SignUp_Button.TabIndex = 6;
            this.SignUp_Button.Text = "Sign Up";
            this.SignUp_Button.UseVisualStyleBackColor = false;
            this.SignUp_Button.Click += new System.EventHandler(this.Register_Sign_Up_Button_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.BackColor = System.Drawing.Color.DodgerBlue;
            this.Clear_Button.FlatAppearance.BorderSize = 0;
            this.Clear_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Button.ForeColor = System.Drawing.Color.White;
            this.Clear_Button.Location = new System.Drawing.Point(498, 368);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(111, 48);
            this.Clear_Button.TabIndex = 7;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = false;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
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
            // ConfirmPassword_Label
            // 
            this.ConfirmPassword_Label.AutoSize = true;
            this.ConfirmPassword_Label.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmPassword_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword_Label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ConfirmPassword_Label.Location = new System.Drawing.Point(237, 260);
            this.ConfirmPassword_Label.Name = "ConfirmPassword_Label";
            this.ConfirmPassword_Label.Size = new System.Drawing.Size(226, 29);
            this.ConfirmPassword_Label.TabIndex = 1;
            this.ConfirmPassword_Label.Text = "Confirm Password";
            // 
            // ConfirmPassword_TextBox
            // 
            this.ConfirmPassword_TextBox.CausesValidation = false;
            this.ConfirmPassword_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword_TextBox.Location = new System.Drawing.Point(480, 257);
            this.ConfirmPassword_TextBox.Name = "ConfirmPassword_TextBox";
            this.ConfirmPassword_TextBox.PasswordChar = '*';
            this.ConfirmPassword_TextBox.Size = new System.Drawing.Size(179, 34);
            this.ConfirmPassword_TextBox.TabIndex = 4;
            this.ConfirmPassword_TextBox.TextChanged += new System.EventHandler(this.ConfirmPassword_TextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(842, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Management_System.Properties.Resources.Lawrencium;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.SignUp_Button);
            this.Controls.Add(this.ConfirmPassword_TextBox);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.ConfirmPassword_Label);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.Name_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.my_DataBaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Button SignUp_Button;
        private System.Windows.Forms.Button Clear_Button;
        private My_DataBaseDataSet5 my_DataBaseDataSet5;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private My_DataBaseDataSet5TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label ConfirmPassword_Label;
        private System.Windows.Forms.TextBox ConfirmPassword_TextBox;
        private System.Windows.Forms.Label label4;
    }
}
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
            this.Register_Name_Label = new System.Windows.Forms.Label();
            this.Register_Password_Label = new System.Windows.Forms.Label();
            this.Register_Confirm_Password_Label = new System.Windows.Forms.Label();
            this.Register_Name_TextBox = new System.Windows.Forms.TextBox();
            this.Register_Password_TextBox = new System.Windows.Forms.TextBox();
            this.Register_Confirm_Password_TextBox = new System.Windows.Forms.TextBox();
            this.Register_Sign_Up_Button = new System.Windows.Forms.Button();
            this.Register_Clear_Button = new System.Windows.Forms.Button();
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
            // Register_Confirm_Password_Label
            // 
            this.Register_Confirm_Password_Label.AutoSize = true;
            this.Register_Confirm_Password_Label.Location = new System.Drawing.Point(29, 129);
            this.Register_Confirm_Password_Label.Name = "Register_Confirm_Password_Label";
            this.Register_Confirm_Password_Label.Size = new System.Drawing.Size(121, 17);
            this.Register_Confirm_Password_Label.TabIndex = 2;
            this.Register_Confirm_Password_Label.Text = "Confirm Password";
            // 
            // Register_Name_TextBox
            // 
            this.Register_Name_TextBox.Location = new System.Drawing.Point(196, 40);
            this.Register_Name_TextBox.Name = "Register_Name_TextBox";
            this.Register_Name_TextBox.Size = new System.Drawing.Size(100, 22);
            this.Register_Name_TextBox.TabIndex = 3;
            // 
            // Register_Password_TextBox
            // 
            this.Register_Password_TextBox.Location = new System.Drawing.Point(196, 77);
            this.Register_Password_TextBox.Name = "Register_Password_TextBox";
            this.Register_Password_TextBox.PasswordChar = '*';
            this.Register_Password_TextBox.Size = new System.Drawing.Size(100, 22);
            this.Register_Password_TextBox.TabIndex = 4;
            // 
            // Register_Confirm_Password_TextBox
            // 
            this.Register_Confirm_Password_TextBox.Location = new System.Drawing.Point(196, 126);
            this.Register_Confirm_Password_TextBox.Name = "Register_Confirm_Password_TextBox";
            this.Register_Confirm_Password_TextBox.PasswordChar = '*';
            this.Register_Confirm_Password_TextBox.Size = new System.Drawing.Size(100, 22);
            this.Register_Confirm_Password_TextBox.TabIndex = 5;
            // 
            // Register_Sign_Up_Button
            // 
            this.Register_Sign_Up_Button.Location = new System.Drawing.Point(32, 189);
            this.Register_Sign_Up_Button.Name = "Register_Sign_Up_Button";
            this.Register_Sign_Up_Button.Size = new System.Drawing.Size(75, 23);
            this.Register_Sign_Up_Button.TabIndex = 6;
            this.Register_Sign_Up_Button.Text = "Sign Up";
            this.Register_Sign_Up_Button.UseVisualStyleBackColor = true;
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
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 577);
            this.Controls.Add(this.Register_Clear_Button);
            this.Controls.Add(this.Register_Sign_Up_Button);
            this.Controls.Add(this.Register_Confirm_Password_TextBox);
            this.Controls.Add(this.Register_Password_TextBox);
            this.Controls.Add(this.Register_Name_TextBox);
            this.Controls.Add(this.Register_Confirm_Password_Label);
            this.Controls.Add(this.Register_Password_Label);
            this.Controls.Add(this.Register_Name_Label);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Register_Name_Label;
        private System.Windows.Forms.Label Register_Password_Label;
        private System.Windows.Forms.Label Register_Confirm_Password_Label;
        private System.Windows.Forms.TextBox Register_Name_TextBox;
        private System.Windows.Forms.TextBox Register_Password_TextBox;
        private System.Windows.Forms.TextBox Register_Confirm_Password_TextBox;
        private System.Windows.Forms.Button Register_Sign_Up_Button;
        private System.Windows.Forms.Button Register_Clear_Button;
    }
}
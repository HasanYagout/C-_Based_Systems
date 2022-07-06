namespace Hotel_Management_System
{
    partial class MainWindow
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
            this.Check_In_Button = new System.Windows.Forms.Button();
            this.Check_Out_Button = new System.Windows.Forms.Button();
            this.Manage_Rooms_Button = new System.Windows.Forms.Button();
            this.Main_window_panel = new System.Windows.Forms.Panel();
            this.Log_Out_Button = new System.Windows.Forms.Button();
            this.Users_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Check_In_Button
            // 
            this.Check_In_Button.BackColor = System.Drawing.Color.Transparent;
            this.Check_In_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Check_In_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Check_In_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_In_Button.ForeColor = System.Drawing.Color.White;
            this.Check_In_Button.Location = new System.Drawing.Point(29, 166);
            this.Check_In_Button.Name = "Check_In_Button";
            this.Check_In_Button.Size = new System.Drawing.Size(216, 102);
            this.Check_In_Button.TabIndex = 0;
            this.Check_In_Button.Text = "Check In";
            this.Check_In_Button.UseVisualStyleBackColor = false;
            // 
            // Check_Out_Button
            // 
            this.Check_Out_Button.BackColor = System.Drawing.Color.Transparent;
            this.Check_Out_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Check_Out_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_Out_Button.ForeColor = System.Drawing.Color.White;
            this.Check_Out_Button.Location = new System.Drawing.Point(29, 274);
            this.Check_Out_Button.Name = "Check_Out_Button";
            this.Check_Out_Button.Size = new System.Drawing.Size(216, 102);
            this.Check_Out_Button.TabIndex = 1;
            this.Check_Out_Button.Text = "Check Out";
            this.Check_Out_Button.UseVisualStyleBackColor = false;
            // 
            // Manage_Rooms_Button
            // 
            this.Manage_Rooms_Button.BackColor = System.Drawing.Color.Transparent;
            this.Manage_Rooms_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Manage_Rooms_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Manage_Rooms_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage_Rooms_Button.ForeColor = System.Drawing.Color.White;
            this.Manage_Rooms_Button.Location = new System.Drawing.Point(29, 382);
            this.Manage_Rooms_Button.Name = "Manage_Rooms_Button";
            this.Manage_Rooms_Button.Size = new System.Drawing.Size(216, 102);
            this.Manage_Rooms_Button.TabIndex = 2;
            this.Manage_Rooms_Button.Text = "Manage Rooms";
            this.Manage_Rooms_Button.UseVisualStyleBackColor = false;
            // 
            // Main_window_panel
            // 
            this.Main_window_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Main_window_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_window_panel.ForeColor = System.Drawing.Color.White;
            this.Main_window_panel.Location = new System.Drawing.Point(251, 166);
            this.Main_window_panel.Name = "Main_window_panel";
            this.Main_window_panel.Size = new System.Drawing.Size(1400, 700);
            this.Main_window_panel.TabIndex = 3;
            this.Main_window_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_window_panel_Paint);
            // 
            // Log_Out_Button
            // 
            this.Log_Out_Button.BackColor = System.Drawing.Color.Transparent;
            this.Log_Out_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Log_Out_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Log_Out_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_Out_Button.ForeColor = System.Drawing.Color.White;
            this.Log_Out_Button.Location = new System.Drawing.Point(29, 598);
            this.Log_Out_Button.Name = "Log_Out_Button";
            this.Log_Out_Button.Size = new System.Drawing.Size(216, 102);
            this.Log_Out_Button.TabIndex = 2;
            this.Log_Out_Button.Text = "Log Out";
            this.Log_Out_Button.UseVisualStyleBackColor = false;
            this.Log_Out_Button.Click += new System.EventHandler(this.Log_Out_Button_Click);
            // 
            // Users_Button
            // 
            this.Users_Button.BackColor = System.Drawing.Color.Transparent;
            this.Users_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Users_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Users_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_Button.ForeColor = System.Drawing.Color.White;
            this.Users_Button.Location = new System.Drawing.Point(29, 490);
            this.Users_Button.Name = "Users_Button";
            this.Users_Button.Size = new System.Drawing.Size(216, 102);
            this.Users_Button.TabIndex = 2;
            this.Users_Button.Text = "Users";
            this.Users_Button.UseVisualStyleBackColor = false;
            this.Users_Button.Click += new System.EventHandler(this.Users_Button_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Management_System.Properties.Resources.gradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.Log_Out_Button);
            this.Controls.Add(this.Main_window_panel);
            this.Controls.Add(this.Users_Button);
            this.Controls.Add(this.Manage_Rooms_Button);
            this.Controls.Add(this.Check_Out_Button);
            this.Controls.Add(this.Check_In_Button);
            this.DoubleBuffered = true;
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "MainWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Check_In_Button;
        private System.Windows.Forms.Button Check_Out_Button;
        private System.Windows.Forms.Button Manage_Rooms_Button;
        private System.Windows.Forms.Panel Main_window_panel;
        private System.Windows.Forms.Button Log_Out_Button;
        private System.Windows.Forms.Button Users_Button;



    }
}
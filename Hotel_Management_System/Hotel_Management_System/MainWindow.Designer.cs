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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Users_Button = new System.Windows.Forms.Button();
            this.Users_PictureBox = new System.Windows.Forms.PictureBox();
            this.CheckIn_Button = new System.Windows.Forms.Button();
            this.CheckOut_Button = new System.Windows.Forms.Button();
            this.Rooms_button = new System.Windows.Forms.Button();
            this.Rooms_PictureBox = new System.Windows.Forms.PictureBox();
            this.CheckOut_PictureBox = new System.Windows.Forms.PictureBox();
            this.CheckIn_PictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MainWindow_Label = new System.Windows.Forms.Label();
            this.User_Label = new System.Windows.Forms.Label();
            this.Welcome_Label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Users_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rooms_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckOut_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckIn_PictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserToolStripMenuItem,
            this.ReservationToolStripMenuItem,
            this.logOutToolStripMenuItem1,
            this.checkInToolStripMenuItem1,
            this.checkOutToolStripMenuItem,
            this.manageRoomsToolStripMenuItem,
            this.manageUsersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 38);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UserToolStripMenuItem
            // 
            this.UserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem2});
            this.UserToolStripMenuItem.Name = "UserToolStripMenuItem";
            this.UserToolStripMenuItem.Size = new System.Drawing.Size(69, 34);
            this.UserToolStripMenuItem.Text = "User";
            this.UserToolStripMenuItem.Click += new System.EventHandler(this.checkInToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.changePasswordToolStripMenuItem.Text = "change password";
            // 
            // logOutToolStripMenuItem2
            // 
            this.logOutToolStripMenuItem2.Image = global::Hotel_Management_System.Properties.Resources.logout__4_1;
            this.logOutToolStripMenuItem2.Name = "logOutToolStripMenuItem2";
            this.logOutToolStripMenuItem2.Size = new System.Drawing.Size(254, 34);
            this.logOutToolStripMenuItem2.Text = "Log Out";
            this.logOutToolStripMenuItem2.Click += new System.EventHandler(this.logOutToolStripMenuItem2_Click);
            // 
            // ReservationToolStripMenuItem
            // 
            this.ReservationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addReservationToolStripMenuItem,
            this.manageReservationToolStripMenuItem});
            this.ReservationToolStripMenuItem.Name = "ReservationToolStripMenuItem";
            this.ReservationToolStripMenuItem.Size = new System.Drawing.Size(137, 34);
            this.ReservationToolStripMenuItem.Text = "Reservation";
            this.ReservationToolStripMenuItem.Click += new System.EventHandler(this.ReservationToolStripMenuItem_Click);
            // 
            // addReservationToolStripMenuItem
            // 
            this.addReservationToolStripMenuItem.Name = "addReservationToolStripMenuItem";
            this.addReservationToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.addReservationToolStripMenuItem.Text = "Add Reservation";
            this.addReservationToolStripMenuItem.Click += new System.EventHandler(this.addReservationToolStripMenuItem_Click);
            // 
            // manageReservationToolStripMenuItem
            // 
            this.manageReservationToolStripMenuItem.Name = "manageReservationToolStripMenuItem";
            this.manageReservationToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.manageReservationToolStripMenuItem.Text = "Manage Reservation";
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(12, 34);
            // 
            // checkInToolStripMenuItem1
            // 
            this.checkInToolStripMenuItem1.Name = "checkInToolStripMenuItem1";
            this.checkInToolStripMenuItem1.Size = new System.Drawing.Size(108, 34);
            this.checkInToolStripMenuItem1.Text = "Check In";
            this.checkInToolStripMenuItem1.Click += new System.EventHandler(this.checkInToolStripMenuItem1_Click);
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(126, 34);
            this.checkOutToolStripMenuItem.Text = "Check Out";
            this.checkOutToolStripMenuItem.Click += new System.EventHandler(this.checkOutToolStripMenuItem_Click_1);
            // 
            // manageRoomsToolStripMenuItem
            // 
            this.manageRoomsToolStripMenuItem.Name = "manageRoomsToolStripMenuItem";
            this.manageRoomsToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.manageRoomsToolStripMenuItem.Text = "Manage Rooms";
            this.manageRoomsToolStripMenuItem.Click += new System.EventHandler(this.manageRoomsToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(163, 34);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(293, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 700);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1235, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Users_Button
            // 
            this.Users_Button.FlatAppearance.BorderSize = 0;
            this.Users_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Users_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_Button.Location = new System.Drawing.Point(13, 438);
            this.Users_Button.Name = "Users_Button";
            this.Users_Button.Size = new System.Drawing.Size(240, 62);
            this.Users_Button.TabIndex = 9;
            this.Users_Button.Text = "Users";
            this.Users_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Users_Button.UseVisualStyleBackColor = true;
            this.Users_Button.Click += new System.EventHandler(this.Users_Button_Click_1);
            // 
            // Users_PictureBox
            // 
            this.Users_PictureBox.Image = global::Hotel_Management_System.Properties.Resources.man;
            this.Users_PictureBox.Location = new System.Drawing.Point(161, 452);
            this.Users_PictureBox.Name = "Users_PictureBox";
            this.Users_PictureBox.Size = new System.Drawing.Size(64, 38);
            this.Users_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Users_PictureBox.TabIndex = 10;
            this.Users_PictureBox.TabStop = false;
            // 
            // CheckIn_Button
            // 
            this.CheckIn_Button.FlatAppearance.BorderSize = 0;
            this.CheckIn_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckIn_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckIn_Button.Location = new System.Drawing.Point(13, 174);
            this.CheckIn_Button.Name = "CheckIn_Button";
            this.CheckIn_Button.Size = new System.Drawing.Size(240, 62);
            this.CheckIn_Button.TabIndex = 9;
            this.CheckIn_Button.Text = "Check In";
            this.CheckIn_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckIn_Button.UseVisualStyleBackColor = true;
            this.CheckIn_Button.Click += new System.EventHandler(this.CheckIn_Button_Click);
            // 
            // CheckOut_Button
            // 
            this.CheckOut_Button.FlatAppearance.BorderSize = 0;
            this.CheckOut_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckOut_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOut_Button.Location = new System.Drawing.Point(13, 257);
            this.CheckOut_Button.Name = "CheckOut_Button";
            this.CheckOut_Button.Size = new System.Drawing.Size(240, 62);
            this.CheckOut_Button.TabIndex = 9;
            this.CheckOut_Button.Text = "Check Out";
            this.CheckOut_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckOut_Button.UseVisualStyleBackColor = true;
            this.CheckOut_Button.Click += new System.EventHandler(this.CheckOut_Button_Click);
            // 
            // Rooms_button
            // 
            this.Rooms_button.FlatAppearance.BorderSize = 0;
            this.Rooms_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rooms_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rooms_button.Location = new System.Drawing.Point(13, 345);
            this.Rooms_button.Name = "Rooms_button";
            this.Rooms_button.Size = new System.Drawing.Size(240, 62);
            this.Rooms_button.TabIndex = 9;
            this.Rooms_button.Text = "Rooms";
            this.Rooms_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Rooms_button.UseVisualStyleBackColor = true;
            this.Rooms_button.Click += new System.EventHandler(this.Rooms_button_Click);
            // 
            // Rooms_PictureBox
            // 
            this.Rooms_PictureBox.Image = global::Hotel_Management_System.Properties.Resources.managerooms;
            this.Rooms_PictureBox.Location = new System.Drawing.Point(161, 356);
            this.Rooms_PictureBox.Name = "Rooms_PictureBox";
            this.Rooms_PictureBox.Size = new System.Drawing.Size(64, 38);
            this.Rooms_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Rooms_PictureBox.TabIndex = 10;
            this.Rooms_PictureBox.TabStop = false;
            // 
            // CheckOut_PictureBox
            // 
            this.CheckOut_PictureBox.Image = global::Hotel_Management_System.Properties.Resources.check_out__1_;
            this.CheckOut_PictureBox.Location = new System.Drawing.Point(161, 267);
            this.CheckOut_PictureBox.Name = "CheckOut_PictureBox";
            this.CheckOut_PictureBox.Size = new System.Drawing.Size(64, 38);
            this.CheckOut_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CheckOut_PictureBox.TabIndex = 10;
            this.CheckOut_PictureBox.TabStop = false;
            // 
            // CheckIn_PictureBox
            // 
            this.CheckIn_PictureBox.Image = global::Hotel_Management_System.Properties.Resources.check_in;
            this.CheckIn_PictureBox.Location = new System.Drawing.Point(161, 185);
            this.CheckIn_PictureBox.Name = "CheckIn_PictureBox";
            this.CheckIn_PictureBox.Size = new System.Drawing.Size(64, 38);
            this.CheckIn_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CheckIn_PictureBox.TabIndex = 10;
            this.CheckIn_PictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.MainWindow_Label);
            this.panel2.Location = new System.Drawing.Point(1, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1192, 110);
            this.panel2.TabIndex = 11;
            // 
            // MainWindow_Label
            // 
            this.MainWindow_Label.AutoSize = true;
            this.MainWindow_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainWindow_Label.ForeColor = System.Drawing.Color.White;
            this.MainWindow_Label.Location = new System.Drawing.Point(59, 12);
            this.MainWindow_Label.Name = "MainWindow_Label";
            this.MainWindow_Label.Size = new System.Drawing.Size(311, 76);
            this.MainWindow_Label.TabIndex = 0;
            this.MainWindow_Label.Text = "Welcome";
            // 
            // User_Label
            // 
            this.User_Label.AutoSize = true;
            this.User_Label.BackColor = System.Drawing.Color.Transparent;
            this.User_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.User_Label.Location = new System.Drawing.Point(140, 799);
            this.User_Label.Name = "User_Label";
            this.User_Label.Size = new System.Drawing.Size(29, 29);
            this.User_Label.TabIndex = 12;
            this.User_Label.Text = "[]";
            // 
            // Welcome_Label
            // 
            this.Welcome_Label.AutoSize = true;
            this.Welcome_Label.BackColor = System.Drawing.Color.Transparent;
            this.Welcome_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_Label.ForeColor = System.Drawing.Color.White;
            this.Welcome_Label.Location = new System.Drawing.Point(13, 799);
            this.Welcome_Label.Name = "Welcome_Label";
            this.Welcome_Label.Size = new System.Drawing.Size(121, 29);
            this.Welcome_Label.TabIndex = 13;
            this.Welcome_Label.Text = "Welcome:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Hotel_Management_System.Properties.Resources.Lawrencium;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 1080);
            this.Controls.Add(this.Welcome_Label);
            this.Controls.Add(this.User_Label);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CheckIn_PictureBox);
            this.Controls.Add(this.CheckOut_PictureBox);
            this.Controls.Add(this.Rooms_PictureBox);
            this.Controls.Add(this.Users_PictureBox);
            this.Controls.Add(this.Rooms_button);
            this.Controls.Add(this.CheckOut_Button);
            this.Controls.Add(this.CheckIn_Button);
            this.Controls.Add(this.Users_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Users_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rooms_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckOut_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckIn_PictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem2;
        public System.Windows.Forms.Button Users_Button;
        public System.Windows.Forms.PictureBox Users_PictureBox;
        private System.Windows.Forms.Button CheckIn_Button;
        private System.Windows.Forms.Button CheckOut_Button;
        public System.Windows.Forms.Button Rooms_button;
        public System.Windows.Forms.PictureBox Rooms_PictureBox;
        private System.Windows.Forms.PictureBox CheckOut_PictureBox;
        private System.Windows.Forms.PictureBox CheckIn_PictureBox;
        private System.Windows.Forms.ToolStripMenuItem addReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkInToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem manageRoomsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label MainWindow_Label;
        public System.Windows.Forms.Label User_Label;
        private System.Windows.Forms.Label Welcome_Label;



    }
}
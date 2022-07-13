using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Users_Button_Click(object sender, EventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            ManageUsers manageusers = new ManageUsers { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            
            this.Main_window_panel.Controls.Add(manageusers);
            
            manageusers.Show();
            
            
        }

        private void Log_Out_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("are you sure you want to log out?", "Log Out!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
          
            
           
        }

        private void Main_window_panel_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Manage_Rooms_Button_Click(object sender, EventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
           ManageRooms managerooms = new ManageRooms { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            this.Main_window_panel.Controls.Add(managerooms);
            managerooms.Show();
        }

        private void Check_In_Button_Click(object sender, EventArgs e)
        {
            
            MainWindow mainwindow = new MainWindow();
            CheckIn checkin = new CheckIn { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            this.Main_window_panel.Controls.Add(checkin);
            checkin.Show();

        }

       

        
    }
}

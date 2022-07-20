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

        public void f()
        {
            MainWindow mainwindow = new MainWindow();
            ManageUsers manageusers = new ManageUsers { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };


            manageusers.Show();
        
        }

        private void Users_Button_Click(object sender, EventArgs e)
        {

            f();
            
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

            managerooms.Show();
        }

        private void Check_In_Button_Click(object sender, EventArgs e)
        {
            
            MainWindow mainwindow = new MainWindow();
            CheckIn checkin = new CheckIn();


            checkin.Show();

        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CheckIn checkin = new CheckIn() { TopLevel = false, TopMost = true };
            checkin.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(checkin);
            checkin.Show();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            ManageUsers manageusers= new ManageUsers() { TopLevel = false, TopMost = true };
            manageusers.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(manageusers);
            manageusers.Show();
        }

        private void manageRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            ManageRooms managerooms = new ManageRooms() { TopLevel = false, TopMost = true };
            managerooms.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(managerooms);
            managerooms.Show();

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          DialogResult result=  MessageBox.Show("do you want to log out?","confirm",MessageBoxButtons.YesNo);
          if (result == DialogResult.Yes)
          {
              Login login = new Login();
              this.Dispose();
              login.Show();
          
          }
        }

       

        
    }
}

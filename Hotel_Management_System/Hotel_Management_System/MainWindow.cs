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
            Users_Button.Visible = false;
            Rooms_button.Visible = false;
            Rooms_PictureBox.Visible = false;
            Users_PictureBox.Visible = false;
            changePasswordToolStripMenuItem.Visible = false;
            manageRoomsToolStripMenuItem.Visible = false;
            manageUsersToolStripMenuItem.Visible = false;
            
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
            //panel1.Controls.Clear();
            //CheckIn checkin = new CheckIn() { TopLevel = false, TopMost = true };
            //checkin.FormBorderStyle = FormBorderStyle.None;
            //panel1.Controls.Add(checkin);
            //checkin.Show();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Check_Out checkout = new Check_Out { TopLevel = false, TopMost = true };
            checkout.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(checkout);
            checkout.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            ManageUsers manageusers= new ManageUsers() { TopLevel = false, TopMost = true };
            manageusers.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(manageusers);
            manageusers.Show();
        }

        


        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void logOutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("do you want to log out?", "confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                this.Dispose();
                login.Show();

            }
        }

        private void ReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        

        public void Users_Button_Click_1(object sender, EventArgs e)
        {
            MainWindow_Label.Text = Users_Button.Text;
            panel1.Controls.Clear();
            ManageUsers manageusers = new ManageUsers { TopLevel = false, TopMost = true };
            manageusers.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(manageusers);
            Users_Button.BackColor = ColorTranslator.FromHtml("#404040");
            Users_Button.ForeColor = Color.White;
            CheckIn_Button.BackColor = Color.White;
            CheckIn_Button.ForeColor = Color.Black;
            CheckOut_Button.BackColor = Color.White;
            CheckOut_Button.ForeColor = Color.Black;
            Rooms_button.ForeColor = Color.Black;
            Rooms_button.BackColor = Color.White;
            manageusers.Show();
        }

        private void CheckOut_Button_Click(object sender, EventArgs e)
        {
            MainWindow_Label.Text = CheckOut_Button.Text;
            panel1.Controls.Clear();
            Check_Out checkout = new Check_Out { TopLevel = false, TopMost = true };
            checkout.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(checkout);
            CheckOut_Button.BackColor = ColorTranslator.FromHtml("#404040");
            CheckOut_Button.ForeColor = Color.White;
            Users_Button.BackColor = Color.White;
            Users_Button.ForeColor = Color.Black;
            CheckIn_Button.BackColor = Color.White;
            CheckIn_Button.ForeColor = Color.Black;
            Rooms_button.ForeColor = Color.Black;
            Rooms_button.BackColor = Color.White;
            checkout.Show();
        }

        private void Rooms_button_Click(object sender, EventArgs e)
        {
            MainWindow_Label.Text = Rooms_button.Text;
            panel1.Controls.Clear();
            Rooms_button.BackColor = Color.White;
            Rooms_button.ForeColor = Color.Black;
            ManageRooms managerooms = new ManageRooms { TopLevel = false, TopMost = true };
            managerooms.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(managerooms);
            Users_Button.BackColor = Color.White;
            Users_Button.ForeColor = Color.Black;
            CheckOut_Button.BackColor = Color.White;
            CheckOut_Button.ForeColor = Color.Black;
            Rooms_button.ForeColor = Color.White;
            Rooms_button.BackColor = ColorTranslator.FromHtml("#404040");
            CheckIn_Button.BackColor = Color.White;
            CheckIn_Button.ForeColor = Color.Black;
            managerooms.Show();
        }

        private void CheckIn_Button_Click(object sender, EventArgs e)
        {
            MainWindow_Label.Text = CheckIn_Button.Text;
            panel1.Controls.Clear();
            Rooms_button.BackColor = Color.White;
            Rooms_button.ForeColor = Color.Black;
            CheckIn checkin = new CheckIn { TopLevel = false, TopMost = true };
            checkin.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(checkin);
            Users_Button.BackColor = Color.White;
            Users_Button.ForeColor = Color.Black;
            CheckOut_Button.BackColor = Color.White;
            CheckOut_Button.ForeColor = Color.Black;
            Rooms_button.BackColor = Color.White;
            Rooms_button.ForeColor = Color.Black;
            CheckIn_Button.BackColor = ColorTranslator.FromHtml("#404040");
            CheckIn_Button.ForeColor = Color.White;
            checkin.Show();

        }

        private void checkInToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainWindow_Label.Text = CheckIn_Button.Text;
            panel1.Controls.Clear();
            Rooms_button.BackColor = Color.White;
            Rooms_button.ForeColor = Color.Black;
            CheckIn checkin = new CheckIn { TopLevel = false, TopMost = true };
            checkin.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(checkin);
            Users_Button.BackColor = Color.White;
            Users_Button.ForeColor = Color.Black;
            CheckOut_Button.BackColor = Color.White;
            CheckOut_Button.ForeColor = Color.Black;
            Rooms_button.BackColor = Color.White;
            Rooms_button.ForeColor = Color.Black;
            CheckIn_Button.BackColor = ColorTranslator.FromHtml("#404040");
            CheckIn_Button.ForeColor = Color.White;
            checkin.Show();
        }

        private void checkOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MainWindow_Label.Text = CheckOut_Button.Text;
            panel1.Controls.Clear();
            Check_Out checkout = new Check_Out { TopLevel = false, TopMost = true };
            checkout.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(checkout);
            CheckOut_Button.BackColor = ColorTranslator.FromHtml("#404040");
            CheckOut_Button.ForeColor = Color.White;
            Users_Button.BackColor = Color.White;
            Users_Button.ForeColor = Color.Black;
            CheckIn_Button.BackColor = Color.White;
            CheckIn_Button.ForeColor = Color.Black;
            Rooms_button.ForeColor = Color.Black;
            Rooms_button.BackColor = Color.White;
            checkout.Show();
        }

        private void manageRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow_Label.Text = Rooms_button.Text;
            panel1.Controls.Clear();
            Rooms_button.BackColor = Color.White;
            Rooms_button.ForeColor = Color.Black;
            ManageRooms managerooms = new ManageRooms { TopLevel = false, TopMost = true };
            managerooms.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(managerooms);
            Users_Button.BackColor = Color.White;
            Users_Button.ForeColor = Color.Black;
            CheckOut_Button.BackColor = Color.White;
            CheckOut_Button.ForeColor = Color.Black;
            Rooms_button.ForeColor = Color.White;
            Rooms_button.BackColor = ColorTranslator.FromHtml("#404040");
            CheckIn_Button.BackColor = Color.White;
            CheckIn_Button.ForeColor = Color.Black;
            managerooms.Show();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow_Label.Text = Users_Button.Text;
            panel1.Controls.Clear();
            ManageUsers manageusers = new ManageUsers { TopLevel = false, TopMost = true };
            manageusers.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(manageusers);
            Users_Button.BackColor = ColorTranslator.FromHtml("#404040");
            Users_Button.ForeColor = Color.White;
            CheckIn_Button.BackColor = Color.White;
            CheckIn_Button.ForeColor = Color.Black;
            CheckOut_Button.BackColor = Color.White;
            CheckOut_Button.ForeColor = Color.Black;
            Rooms_button.ForeColor = Color.Black;
            Rooms_button.BackColor = Color.White;
            manageusers.Show();
        }

        private void addReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Reservation reservation = new Reservation { TopLevel = false, TopMost = true };
            reservation.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(reservation);
            reservation.Show();
           

        }

        

        


       

        
    }
}

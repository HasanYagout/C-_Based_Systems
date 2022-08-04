using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Hotel_Management_System
{
    public partial class CheckIn : Form
    {
      

       public static string DataBasePath = Properties.Settings.Default.My_DataBaseConnectionString;
       private const string InsertQuery = "insert into CheckIn (CheckInDate,RoomType,Duration,RoomNumber,Price,Name,Phone,Email,IDProof,State) values(@date, @rtype,@duration, @rnum,@price,@nam,@pho,@ema,@proof,@state)";
       private const string SelectQuery = "select Id,CheckInDate ,RoomType,RoomNumber,BedType,Name,Phone,Email,IDProof from CheckIn";
       
      

      

        public CheckIn()
        {
            InitializeComponent();
            GetRooms();
            Price_TextBox.Enabled = false;
            Save_btn.Enabled = false;
            
            
        }


        public void connection ()
        {

            using (SqlConnection connection = new SqlConnection(DataBasePath))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(InsertQuery, connection))
                {
                    
                    command.Parameters.AddWithValue("@date", Date.Text);
                    command.Parameters.AddWithValue("@rtypee", RoomType_ComboBox.GetItemText(RoomType_ComboBox.SelectedItem));
                    command.Parameters.AddWithValue("@rnum", RoomNumber_ComboBox.GetItemText(RoomNumber_ComboBox.SelectedItem));
                   
                }

            }
        }

       

        public void GetRooms()
        {
            using (SqlConnection connection = new SqlConnection(DataBasePath))
            {
                connection.Open();

                string SelectQuery = "select number,roomtype from Rooms where status ='unbooked'";
                using (SqlCommand command = new SqlCommand(SelectQuery, connection))
                {
                    
                        if( RoomType_ComboBox.Text!="")
                        {
                            
                            
                        }
                        else
                        {
                            
                            DataTable dt = new DataTable();
                            dt.Load(command.ExecuteReader());
                            RoomType_ComboBox.DisplayMember="roomtype";
                            RoomType_ComboBox.ValueMember="number";
                            RoomType_ComboBox.DataSource = dt;
                            RoomNumber_ComboBox.DisplayMember = "number";
                            RoomNumber_ComboBox.DataSource = dt;
                        
                        }
                        

                    }

                }

            
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckIn checkin = new CheckIn();
            checkin.Show();
            
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUsers manageusers = new ManageUsers();
            manageusers.Show();
        }

        


        private void CheckIn_Load(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (RoomType_ComboBox.SelectedItem == null || RoomNumber_ComboBox.SelectedItem == null || Duration_TextBox.Text == "" || Price_TextBox.Text == "" || Name_TextBox.Text == null || Phone_TextBox.Text == "" || Email_TextBox.Text == "" || IDProof_ComboBox.SelectedItem == null)
            {
                MessageBox.Show("One Of The Fields is Empty","Warning",MessageBoxButtons.OK);
                
            }
            if (RoomType_ComboBox.SelectedItem != null && RoomNumber_ComboBox.SelectedItem != null && Duration_TextBox.Text!=null && Price_TextBox.Text != "" && Name_TextBox.Text != null && Phone_TextBox.Text != "" && Email_TextBox.Text != "" && IDProof_ComboBox.SelectedItem != null)
            {
               
                Save_btn.Enabled = true;
                Date_submit_Label.Text = Date.Text;
                Name_submit_label.Text = Name_TextBox.Text;
                Phone_submit_label.Text = Phone_TextBox.Text;
                Email_submit_label.Text = Email_TextBox.Text;
                IDProof_submit_label.Text = IDProof_ComboBox.GetItemText(IDProof_ComboBox.SelectedItem);
                RoomType_submit_label.Text = RoomType_ComboBox.GetItemText(RoomType_ComboBox.SelectedItem);
                RoomNumber_submit_label.Text = RoomNumber_ComboBox.GetItemText(RoomNumber_ComboBox.SelectedItem);
            }
           
        }


      

        private void cm_RoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetRooms();
        }

      

        private void cb_RoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            getTotalPrice();
        }

        public void getTotalPrice()
        {
            using (SqlConnection connection = new SqlConnection(DataBasePath))
            {
                string query = "select price from rooms where number='" + RoomNumber_ComboBox.GetItemText(RoomNumber_ComboBox.SelectedItem) + "'";
                connection.Open();
                double total;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (Duration_TextBox.Text == "")
                    {
                        total = 0;
                    }
                    else
                    {

                        SqlDataReader reader;
                        reader = command.ExecuteReader();
                        if (reader.Read())
                        {

                            string user1 = reader["price"].ToString();
                            //int user2 = Convert.ToInt32(user1);
                            double user2 = Convert.ToDouble(user1);
                            int dur = Convert.ToInt32(Duration_TextBox.Text);

                            total = (user2 * dur);
                            Price_TextBox.Text = total.ToString();


                        }
                    }



                }

            }
        
        
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            getTotalPrice();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CheckIn checkin = new CheckIn { TopLevel = false, TopMost = true };
            checkin.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(checkin);
            checkin.Show();
            insertcus();
            roomupdate();
        }


        public void roomupdate()
        {
            string updateQuery="update rooms set status ='booked' where number ='"+RoomNumber_ComboBox.GetItemText(RoomNumber_ComboBox.SelectedItem)+"'";

            using (SqlConnection connection = new SqlConnection(DataBasePath))
            { 
                connection.Open();
            using (SqlCommand command = new SqlCommand(updateQuery,connection))
            {
                command.Parameters.AddWithValue("@stat", "booked");
                command.ExecuteNonQuery();
                MessageBox.Show("yello");
                
            
            }
            
            }
        
        }


        public void insertcus()
        {
            using (SqlConnection connection = new SqlConnection(DataBasePath))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(InsertQuery, connection))
                {
                    string dateToString = Date.Text.ToString();
                    //string clint_state = "active";
                    
                    string r= "booked";
                    command.Parameters.AddWithValue("@nam", Name_TextBox.Text);
                    command.Parameters.AddWithValue("@da", Date.Text);
                    command.Parameters.AddWithValue("@rt",RoomType_ComboBox.GetItemText(RoomType_ComboBox.SelectedIndex) );
                    command.Parameters.AddWithValue("@rn", RoomNumber_ComboBox.GetItemText(RoomNumber_ComboBox.SelectedIndex));
                    command.Parameters.AddWithValue("@du", Date.Text);
                  
                    command.Parameters.AddWithValue("@date", Date.Text);

                    command.Parameters.AddWithValue("@rtype", RoomType_ComboBox.GetItemText(RoomType_ComboBox.SelectedItem));
                    command.Parameters.AddWithValue("@rnum", RoomNumber_ComboBox.GetItemText(RoomNumber_ComboBox.SelectedItem));

                    command.Parameters.AddWithValue("@pho", Phone_TextBox.Text);


                    command.Parameters.AddWithValue("@ema", Email_TextBox.Text);
                    
                    command.Parameters.AddWithValue("@proof", IDProof_ComboBox.GetItemText(IDProof_ComboBox.SelectedItem));


                    command.Parameters.AddWithValue("@duration", Duration_TextBox.Text);


                    command.Parameters.AddWithValue("@price", Price_TextBox.Text);
                    command.Parameters.AddWithValue("@state",r );

                    command.ExecuteNonQuery();
                    MessageBox.Show("success");



                }

            }
        
        
        }

        private void Control_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (((Control)sender).Text.Trim().Length == 0)
            {
                error = "this field is required";
                e.Cancel = true;
            }
            errorProvider1.SetError((Control)sender, error);
        }


        private void Price_txb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        

        private void Email_txb_Validating(object sender, CancelEventArgs e)
        {
            Control_Validating(sender, e);
            string error = null;
            try
            {
                new MailAddress(Email_TextBox.Text);
            }
            catch
            {
                error = "please use a valid format email";
                e.Cancel = true;

            }
            errorProvider1.SetError((Control)sender, error);
           
        }

        private void durationTextBox_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void durationTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;

            }

            
        }

        private void Name_txb_KeyPress(object sender, KeyPressEventArgs e)
        {




            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space || e.KeyChar==(char)Keys.Back);                
            
        }

        private void Date_TextBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Name_txb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_txb_TextChanged(object sender, EventArgs e)
        {

        }

        private void cm_RoomType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_RoomNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void cb_IDProof_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            RoomType_ComboBox.Text="";
                RoomNumber_ComboBox.Text="";
                Duration_TextBox.Text = "";
                Price_TextBox.Text = "";
                Name_TextBox.Text = "";
               Phone_TextBox.Text = "";
                Email_TextBox.Text = "";
                IDProof_ComboBox.Text = "";
                Date_submit_Label.Text = "[]";
                Name_submit_label.Text = "[]";
                Phone_submit_label.Text = "[]";
                Email_submit_label.Text = "[]";
                IDProof_submit_label.Text = "[]";
                RoomType_submit_label.Text = "[]";
                RoomNumber_submit_label.Text = "[]";

        }

        



        }

    

    }


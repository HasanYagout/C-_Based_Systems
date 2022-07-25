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

namespace Hotel_Management_System
{
    public partial class CheckIn : Form
    {
      

       public static string DataBasePath = Properties.Settings.Default.My_DataBaseConnectionString;
       private const string InsertQuery = "insert into CheckIn (CheckInDate,RoomType,RoomNumber,BedType,Name,Phone,Email,IDProof) values(@date, @rtype, @rnum,@btype,@nam,@pho,@ema,@proof)";
       private const string SelectQuery = "select Id,CheckInDate ,RoomType,RoomNumber,BedType,Name,Phone,Email,IDProof from CheckIn";
       private const string selectidquery = "select scope_identity() as id from checkin";
       public string na { get; set; }
       public string da { get; set; }
       public string rt { get; set; }
       public string rn { get; set; }
       public string du { get; set; }
       public string pr { get; set; }
       public string ph { get; set; }
       public string rm { get; set; }
       public string ip { get; set; }

      

        public CheckIn()
        {
            InitializeComponent();
            GetRooms();
            
        }


        public void connection ()
        {

            using (SqlConnection connection = new SqlConnection(DataBasePath))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(InsertQuery, connection))
                {
                    
                    command.Parameters.AddWithValue("@date", Date_TextBox.Text);
                    command.Parameters.AddWithValue("@rtypee", cm_RoomType.GetItemText(cm_RoomType.SelectedItem));
                    command.Parameters.AddWithValue("@rnum", cb_RoomNumber.GetItemText(cb_RoomNumber.SelectedItem));
                   
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
                    SqlDataReader reader;
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        if(cm_RoomType.Text!="")
                        {
                            
                        }
                        else
                        {
                        string user1 = reader["number"].ToString();
                        string type = reader["roomtype"].ToString();
                        cb_RoomNumber.Items.Add(user1);
                        cm_RoomType.Items.Add(type);
                        }
                        

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
            dateTimePicker1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Date_submit_id.Text = Date_TextBox.Text;
            Name_submit_label.Text = Name_txb.Text;
            Phone_submit_label.Text = Phone_txb.Text;
            Email_submit_label.Text = Email_txb.Text;
            IDProof_submit_label.Text = cb_IDProof.GetItemText(cb_IDProof.SelectedItem);
            RoomType_submit_label.Text= cm_RoomType.GetItemText(cm_RoomType.SelectedItem);
            RoomNumber_submit_label.Text = cb_RoomNumber.GetItemText(cb_RoomNumber.SelectedItem);
        }


      

        private void cm_RoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetRooms();
        }

        private void cb_BedType_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetRooms();
        }

        private void cb_RoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(DataBasePath))
            {
                string query = "select price from rooms where number='" + cb_RoomNumber.GetItemText(cb_RoomNumber.SelectedItem) + "'";
                connection.Open();
                int total;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (textBox1.Text == "")
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
                            int user2 = Convert.ToInt32(user1);

                            int dur = Convert.ToInt32(textBox1.Text);

                            total = (user2 * dur);
                            Price_txb.Text = total.ToString();


                        }
                    }
                  


                }

            }
        

        }

        private void Save_btn_Click(object sender, EventArgs e)
        {

        }

        public void insertcus()
        {
            using (SqlConnection connection = new SqlConnection(DataBasePath))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(InsertQuery, connection))
                {
                   
                    command.Parameters.AddWithValue("@na", Name_txb.Text);
                    command.Parameters.AddWithValue("@da", Date_TextBox.Text);
                    command.Parameters.AddWithValue("@rt",cm_RoomType.GetItemText(cm_RoomType.SelectedIndex) );
                    command.Parameters.AddWithValue("@rn", cb_RoomNumber.GetItemText(cb_RoomNumber.SelectedIndex));
                    command.Parameters.AddWithValue("@du", Date_TextBox.Text);
                    command.Parameters.AddWithValue("@da", Date_TextBox.Text);
                    command.Parameters.AddWithValue("@da", Date_TextBox.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("success");



                }

            }
        
        
        }



        }

    

    }


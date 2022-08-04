using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
namespace Hotel_Management_System
{
    public partial class Reservation : Form
    {
        public string InsertQuery = "insert into reservation (CheckInDate,RoomType,Duration,RoomNumber,Price,Name,Phone,checkoutdate) values(@indate, @rtype,@duration, @rnum,@price,@nam,@pho,@outdate)";
        public static string DataBasePath = Properties.Settings.Default.My_DataBaseConnectionString;

        public Reservation()
        {
            InitializeComponent();
           
        }

        private void Reservation_Load(object sender, EventArgs e)
        {

            GetRooms();


        }

        private void inlabel_Click(object sender, EventArgs e)
        {

        }

        public void GetRooms()
        {
            using (SqlConnection connection = new SqlConnection(DataBasePath))
            {
                connection.Open();

                string SelectQuery = "select number,roomtype from Rooms where status ='unbooked'";


                using (SqlCommand command = new SqlCommand(SelectQuery, connection))
                {



                    if (cm_RoomType.Text != "")
                    {


                    }
                    else
                    {

                        DataTable dt = new DataTable();
                        dt.Load(command.ExecuteReader());
                        cm_RoomType.DisplayMember = "roomtype";
                        cm_RoomType.ValueMember = "number";
                        cm_RoomType.DataSource = dt;
                        cb_RoomNumber.DisplayMember = "number";
                        cb_RoomNumber.DataSource = dt;

                    }


                }

            }


        }

        private void durationTextBox_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(DataBasePath))
            {
                string query = "select price from rooms where number='" + cb_RoomNumber.GetItemText(cb_RoomNumber.SelectedItem) + "'";
                connection.Open();
                int total;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (durationTextBox.Text == "")
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

                            int dur = Convert.ToInt32(durationTextBox.Text);

                            total = (user2 * dur);
                            Price_txb.Text = total.ToString();


                        }
                    }



                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           using (SqlConnection connection = new SqlConnection(DataBasePath))
            {
                using (SqlCommand command = new SqlCommand(InsertQuery, connection))
                {

                    command.Parameters.AddWithValue("@name", Name_TextBox.Text);
                    command.Parameters.AddWithValue("@nam", Name_TextBox.Text);
                    command.Parameters.AddWithValue("@nam", Name_TextBox.Text);
                    command.Parameters.AddWithValue("@nam", Name_TextBox.Text);
                    command.Parameters.AddWithValue("@nam", Name_TextBox.Text);
                    command.Parameters.AddWithValue("@nam", Name_TextBox.Text);
                
                }
            
            }
        }

       

       
    }
}

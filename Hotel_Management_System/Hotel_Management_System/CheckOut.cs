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
    public partial class Check_Out : Form
    {
        public static string DataBasePath = Properties.Settings.Default.My_DataBaseConnectionString;

        public Check_Out()
        {
            InitializeComponent();
            CheckOut_DatePicker.Enabled = false;
           

        }

        public void searching()
        {

            using (SqlConnection connection = new SqlConnection(DataBasePath))
            {         string SelectQuery = "select id,CheckInDate ,RoomType,RoomNumber,Name,price from CheckIn where roomnumber ='"+searching_txb.Text+"'";

                connection.Open();

                using (SqlCommand command = new SqlCommand(SelectQuery, connection))
                {
                    SqlDataReader reader;
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {

                        string cho_id = reader["Id"].ToString();
                        string cho_name = reader["name"].ToString();
                        indate_checkout_label.Text = reader["CheckInDate"].ToString();
                        string cho_roomnumber = reader["roomnumber"].ToString();
                        string cho_roomtype = reader["roomtype"].ToString();
                        choId_Label.Text = cho_id;
                        Name_label.Text = cho_name;
                        RoomNumber_label.Text = cho_roomnumber;
                        Roomtype_label.Text = cho_roomtype;


                     string price = reader["price"].ToString();


                        DateTime eee = DateTime.ParseExact(indate_checkout_label.Text, "yyyy-MM-dd", null);
                      int aa = (CheckOut_DatePicker.Value.Date-eee ).Days;


                      Duration_label.Text = aa.ToString();
                      
                      int bbb = Convert.ToInt32(price);
                      int total = aa * bbb;
                      Price_label.Text = total.ToString();
                    }

                }

            }




        }

        public void days()
        { 
        
        
}

       

      

        private void searching_txb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                searching();
            }
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            searching();
        }

        private void CheckOutCustomer()
        {
            string DeleteQuery = "delete from checkin where roomnumber = '" + RoomNumber_label.Text + "'";
            using (SqlConnection connection = new SqlConnection(DataBasePath))
            { 
                connection.Open();
                using (SqlCommand command = new SqlCommand(DeleteQuery, connection))
                {
                    command.Parameters.AddWithValue("roomnumber",RoomNumber_label.Text );
                     command.ExecuteNonQuery();
                     MessageBox.Show("check out completed");
                     
                     
                
                }
                
            
            }
            

          
            
        
        
        }

        private void UpdateRooms()
        {


            string UpdateQuery = "update rooms set status ='unbooked' where number = '" + RoomNumber_label.Text + "'";
            using (SqlConnection connection = new SqlConnection(DataBasePath))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(UpdateQuery, connection))
                {
                    command.Parameters.AddWithValue("status","unbooked");
                    command.ExecuteNonQuery();
                    MessageBox.Show("room updated");



                }


            }
        
        }


        private void InsertIntoCheckOut()
        {
            string insertquery = "insert into CheckOut (id,name,RoomNumber,RoomType,CheckInDate,checkoutdate,Duration,Price) values(@id,@nam,@rnum,@rtype,@indate,@outdate,@duration,@price)";

            using (SqlConnection connection = new SqlConnection(DataBasePath))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(insertquery, connection))
                {
                    command.Parameters.AddWithValue("id", choId_Label.Text);
                    command.Parameters.AddWithValue("nam", Name_label.Text);
                    command.Parameters.AddWithValue("rnum", RoomNumber_label.Text);
                    command.Parameters.AddWithValue("rtype", Roomtype_label.Text);
                    command.Parameters.AddWithValue("indate", indate_checkout_label.Text);
                    command.Parameters.AddWithValue("outdate", CheckOut_DatePicker.Text);
                    command.Parameters.AddWithValue("duration", Duration_label.Text);
                    command.Parameters.AddWithValue("price", Price_label.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("insert completed");



                }

            }
        
        }

        private void CheckOut_Button_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckOutTable c = new CheckOutTable();
            c.Show();
            
        }

        private void CheckOut_Button_Click_1(object sender, EventArgs e)
        {
            CheckOutCustomer();
            InsertIntoCheckOut();
            UpdateRooms();
        }

        

       

    }
}

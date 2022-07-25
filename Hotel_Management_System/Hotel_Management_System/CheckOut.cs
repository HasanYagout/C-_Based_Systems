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
           
           

        }

        public void searching()
        {

            using (SqlConnection connection = new SqlConnection(DataBasePath))
            {         string SelectQuery = "select CheckInDate ,RoomType,RoomNumber,Name from CheckIn where roomnumber ='"+searching_txb.Text+"'";

                connection.Open();

                using (SqlCommand command = new SqlCommand(SelectQuery, connection))
                {
                    SqlDataReader reader;
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                            
                        
                        string cho_name = reader["name"].ToString();
                        string cho_checkindate = reader["checkinddate"].ToString();
                        string cho_roomnumber = reader["roomnumber"].ToString();
                        string cho_roomtype = reader["roomtype"].ToString();
                        Name_label.Text = cho_name;
                        RoomNumber_label.Text = cho_roomnumber;
                        Roomtype_label.Text = cho_roomtype;

                        DateTime datebefore = CheckOut_DatePicker.Value.Date;
                        CheckIn_DatePicker.Text = cho_checkindate;
                       
                    
                    }

                }

            }




        }

        public void days()
        { 
        
        
}

        private void button1_Click(object sender, EventArgs e)
        {
            searching();
        }

        private void Check_Out_Load(object sender, EventArgs e)
        {
            
        }

    }
}

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


        public CheckIn()
        {
            InitializeComponent();
            
           Date_TextBox.Text = DateTime.Today.ToShortDateString();
           Date_TextBox.ReadOnly = true;


        }


        public void connection ()
        {

            using (SqlConnection connection = new SqlConnection(DataBasePath))
            {
                

                using (SqlCommand command = new SqlCommand(InsertQuery, connection))
                {

                    command.Parameters.AddWithValue("@date", Date_TextBox.Text);
                    command.Parameters.AddWithValue("@rtypee", comboBox1.GetItemText(comboBox1.SelectedItem));
                    command.Parameters.AddWithValue("@rnum", comboBox2.GetItemText(comboBox2.SelectedItem));
                }

            }
        }




        public void date()
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

       


        

        

    }
}

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
    public partial class ManageRooms : Form
    {

                public static string DataBasePath = Properties.Settings.Default.My_DataBaseConnectionString;
                private const string InsertQuery = "insert into Rooms (Number,RoomType,Price,Status) values(@Num,@rtype,@pri,@stat)";
                private const string SelectQuery = "select Number,RoomType,Price,Status from Rooms";
                private const string DeleteQuery = "delete from rooms where number = @num";
                public string num { get; set; }
                public string rtype { get; set; }
                public string btype { get; set; }
                public string pri { get; set; }
                public string stat { get; set; }

        public ManageRooms()
        {
            InitializeComponent();
            dataGridView1.DataSource= GetRooms();
            buttons();
           

        }

        public void buttons()
        {
            if(RoomType_ComboBox.SelectedItem==null||String.IsNullOrEmpty(Price_textBox.Text) || String.IsNullOrEmpty(RoomNumber_TextBox.Text))
            {
                add_button.Enabled = false;
                Delete_Button.Enabled = false;
                Clear_Button.Enabled = true;
                

               
            }
            if (RoomType_ComboBox.SelectedItem != null && !String.IsNullOrEmpty(Price_textBox.Text) && !String.IsNullOrEmpty(RoomNumber_TextBox.Text))
            {

                add_button.Enabled = true;
                Delete_Button.Enabled = true;
                Clear_Button.Enabled = true;
            }

            else if (RoomType_ComboBox.SelectedItem == null && String.IsNullOrEmpty(Price_textBox.Text) && String.IsNullOrEmpty(RoomNumber_TextBox.Text))
            {

                
                Clear_Button.Enabled = false;
            } 
           
        
        }

        public DataTable GetRooms()
        {
            DataTable datatable = new DataTable();
            using (SqlConnection con = new SqlConnection(DataBasePath))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(SelectQuery, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(datatable);
                    }
                }
            }
            return datatable;
        }






        public void connection( ManageRooms managerooms)
        {
             using(SqlConnection connection = new SqlConnection(DataBasePath))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(InsertQuery,connection))
                    {
                        command.Parameters.AddWithValue("@num", RoomNumber_TextBox.Text);
                        command.Parameters.AddWithValue("@rtype",RoomType_ComboBox.GetItemText(RoomType_ComboBox.SelectedItem));
                        command.Parameters.AddWithValue("@pri",Price_textBox.Text);
                        command.Parameters.AddWithValue("@stat", "unbooked");
                        command.ExecuteNonQuery();
                        MessageBox.Show("success");

                        
                        
                    }
    
                    }
        
        }

       



       


        private void ManageRooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'my_DataBaseDataSet4.Rooms' table. You can move, or remove it, as needed.
           

        }


        public bool DeleteUser(ManageRooms user)
        {
            ManageRooms rooms= new ManageRooms();
            int rows;
            using (SqlConnection con = new SqlConnection(DataBasePath))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DeleteQuery, con))
                {
                    com.Parameters.AddWithValue("num", rooms.num);
                    rows = com.ExecuteNonQuery();
                
                }
            
            }
            return (rows > 0) ? true : false;

        }




        

        private void add_button_Click(object sender, EventArgs e)
        {
            ManageRooms managerooms = new ManageRooms();
            managerooms.num = RoomNumber_TextBox.Text;
            managerooms.rtype = RoomType_ComboBox.GetItemText(RoomType_ComboBox.SelectedItem);
            managerooms.pri = Price_textBox.Text;
            managerooms.stat = "unbooked";
            connection(managerooms);
            dataGridView1.DataSource = GetRooms();
            Clear();
        }

        private void Clear()
        {
            RoomNumber_TextBox.Text = "";
            RoomType_ComboBox.SelectedItem = null;
            Price_textBox.Text = "";
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

            }
        }

        private void RoomNumber_TextBox_TextChanged(object sender, EventArgs e)
        {
            buttons();
        }

        private void RoomType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttons();

        }

        private void Price_textBox_TextChanged(object sender, EventArgs e)
        {
            buttons();

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            Delete_Button.Enabled = true;
        }

        private void RoomType_ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Clear();
           
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {

        }

    }
}

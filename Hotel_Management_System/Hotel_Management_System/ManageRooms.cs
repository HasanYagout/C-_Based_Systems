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
                private const string InsertQuery = "insert into Rooms (Number,RoomType,BedType,Price,Status) values(@Num,@rtype,@btype,@pri,@stat)";
                private const string SelectQuery = "select Number,RoomType,BedType,Price,Status from Rooms";
                public string num { get; set; }
                public string rtype { get; set; }
                public string btype { get; set; }
                public string pri { get; set; }
                public string stat { get; set; }

        public ManageRooms()
        {
            InitializeComponent();
            dataGridView1.DataSource= GetRooms();

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
                        command.Parameters.AddWithValue("@num", textBox1.Text);
                        command.Parameters.AddWithValue("@rtype",comboBox1.GetItemText(comboBox1.SelectedItem));
                        command.Parameters.AddWithValue("@btype",comboBox2.GetItemText(comboBox2.SelectedItem) );
                        command.Parameters.AddWithValue("@pri",textBox4.Text);
                        command.Parameters.AddWithValue("@stat", "unbooked");
                        command.ExecuteNonQuery();
                        MessageBox.Show("success");

                        
                        
                    }
    
                    }
        
        }

       



       

        private void add_button_Click(object sender, EventArgs e)
        {
            ManageRooms managerooms = new ManageRooms();
            managerooms.num = textBox1.Text;
            managerooms.rtype=comboBox1.GetItemText(comboBox1.SelectedItem);
            managerooms.btype=comboBox2.GetItemText(comboBox2.SelectedItem);
            managerooms.pri=textBox4.Text;
            managerooms.stat = "unbooked";
            connection(managerooms);
            dataGridView1.DataSource = GetRooms();
            

        }

        private void ManageRooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'my_DataBaseDataSet4.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.my_DataBaseDataSet4.Rooms);

        }

    }
}

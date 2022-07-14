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
    public partial class ManageUsers : Form
    {
        public string Id { get; set; }
        public string user { get; set; }
        public string pas { get; set; }
        public string sta { get; set; }
        public string po { get; set; }
        
        public static string DataBasePath = Properties.Settings.Default.My_DataBaseConnectionString;
        private const string SelectQuery = "select id,username,password,status,position from Users";
        private const string UpdateQuery = "update Users set username=@user,password=@pas,status=@sta,position=@po where id =@ID";



        public ManageUsers()
        {
            InitializeComponent();
        }


        public static DataTable GetUsers()
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
           


        private void ManageUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'my_DataBaseDataSet6.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this.my_DataBaseDataSet6.Users);
            // TODO: This line of code loads data into the 'my_DataBaseDataSet2.Users' table. You can move, or remove it, as needed.

        }





        public bool UpdateUser(ManageUsers user1)
        {
            int rows;
            using (SqlConnection connection = new SqlConnection(DataBasePath))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(UpdateQuery, connection))
                {

                    command.Parameters.AddWithValue("@Id", Id);
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pas", pas);
                    command.Parameters.AddWithValue("@sta", sta);
                    command.Parameters.AddWithValue("@po", po);
                    rows= command.ExecuteNonQuery();
                }

            }
            return (rows > 0) ? true : false;

        }




        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             

            using(SqlConnection connection = new SqlConnection(DataBasePath))
            {
                
                DialogResult result = new System.Windows.Forms.DialogResult();
                connection.Open();
                using (SqlCommand command = new SqlCommand(SelectQuery, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                  result=  MessageBox.Show("do you want to grant access to this user","confirm",MessageBoxButtons.YesNo);

                  if (reader.Read())
                  {

                      string uu = reader["id"].ToString();
                      string uu2 = reader["username"].ToString();
                      string uu3 = reader["password"].ToString();
                      string uu4 = reader["status"].ToString();
                      string uu5 = reader["position"].ToString();

                      if (result == DialogResult.Yes)
                      {
                          ManageUsers user1 = new ManageUsers();
                          user1.Id = uu;
                          user1.user = uu2;
                          user1.pas = uu3;
                          user1.sta = "true";
                          user1.po = uu5;
                          MessageBox.Show("success");
                      }
                  
                  
                  }
                    
                }

            
            }
            
          
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

    }
}

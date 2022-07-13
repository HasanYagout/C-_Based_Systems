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
        
        public static string DataBasePath = Properties.Settings.Default.My_DataBaseConnectionString;
        private const string SelectQuery = "select username,password,status,position from Users";


        public ManageUsers()
        {
            InitializeComponent();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'my_DataBaseDataSet2.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.my_DataBaseDataSet2.Users);

        }


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             Register register = new Register();

            using(SqlConnection connection = new SqlConnection(DataBasePath))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(SelectQuery, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string name = reader["username"].ToString();
                        string pass = reader["password"].ToString();
                        string stat = reader["status"].ToString();
                        string pos = reader["position"].ToString();
                        DialogResult result = MessageBox.Show("do you want to grant access to this user", "confirm", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {

                            register.sta = "true";
                            MainWindow mainwindow = new MainWindow();
                            mainwindow.Show();
                            
                           

                        }


                        else if (result == DialogResult.No)
                            register.sta = "false";


                        else if (result == DialogResult.No && register.pos.Equals("admin"))
                        {
                            MessageBox.Show("you can't edit this user");

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

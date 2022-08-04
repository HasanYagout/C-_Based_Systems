using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class CheckOutTable : Form
    {
        public CheckOutTable()
        {
            InitializeComponent();
        }

        private void CheckOutTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'checkoutdata.CheckOut' table. You can move, or remove it, as needed.
            this.checkOutTableAdapter.Fill(this.checkoutdata.CheckOut);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conveni
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();

            DataTable BillTable = new DataTable();
            string str = "hello";

            BillTable.Columns.Add("hello");
            BillTable.Columns.Add("hello2");
            BillTable.Columns.Add("hello3");
            Billshow.DataSource = BillTable;
        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Billshow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

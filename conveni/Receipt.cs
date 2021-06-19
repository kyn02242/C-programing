using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace conveni
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("가장 최근 결제 영수증.txt");
            label1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }
    }
}

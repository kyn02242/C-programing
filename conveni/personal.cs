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
    public partial class personal : Form
    {
        
        
        public personal()
        {
            InitializeComponent();
            this.numericUpDown1.Maximum = 3;
            this.numericUpDown1.Minimum = 1;
            this.numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
        }
        private void personal_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
            label3.Text = "00:00 ~ 08:00";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(this.numericUpDown1.Value > 3)
            {
                this.numericUpDown1.Value = 1;
            }
            if (this.numericUpDown1.Value < 1)
            {
                this.numericUpDown1.Value = 3;
            }
            if(this.numericUpDown1.Value == 1)
            {
                label3.Text = "00:00 ~ 08:00";
            }
            else if(this.numericUpDown1.Value == 2)
            {
                label3.Text = "08:00 ~ 16:00";
            }
            else
            {
                label3.Text = "16:00 ~ 00:00";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            person dobi = new person();
            dobi.name = textBox1.Text;
            dobi.time = label3.Text;
            Global.person_list[Global.tmp] = dobi;
            Global.tmp++;
            Close();
        }

    }
    

}

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
    public partial class Personnel_ADD : Form
    {
        public Personnel_ADD()
        {
            InitializeComponent();
            Text = "직원 수정 및 관리";

            dataGridView1.DataSource = DataManager.Personnels;
            dataGridView1.CurrentCellChanged += dataGridView1_CurrentCellChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int textBox1Int = int.Parse(textBox1.Text);
                if (DataManager.Personnels.Exists((x) => x.Id == textBox1Int))
                {
                    MessageBox.Show("이미 존재하는 아이디 입니다");
                }
                else
                {
                    Personnel personnel = new Personnel()
                    {
                        Id = int.Parse(textBox1.Text),
                        Name = textBox2.Text,
                        Date = textBox3.Text,
                        WorkingTime = textBox4.Text,
                        Gender = textBox5.Text,

                    };
                    DataManager.Personnels.Add(personnel);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = DataManager.Personnels;
                    DataManager.Save();
                }
            }
            catch (Exception exception)
            {

            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Personnel personnel = DataManager.Personnels.Single((x) => x.Id == int.Parse(textBox1.Text));
                personnel.Name = textBox2.Text;
                personnel.Date = textBox3.Text;
                personnel.WorkingTime = textBox4.Text;
                personnel.Gender = textBox5.Text;


                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataManager.Personnels;
                DataManager.Save();
            }
            catch (Exception exception)
            {
                MessageBox.Show("존재하지 않는 아이디 입니다.");
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Personnel personnel = DataManager.Personnels.Single((x) => x.Id == int.Parse(textBox1.Text));
                DataManager.Personnels.Remove(personnel);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataManager.Personnels;
                DataManager.Save();
            }
            catch (Exception exception)
            {
                MessageBox.Show("존재하지 않는 아이디 입니다.");
            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Personnel personnel = dataGridView1.CurrentRow.DataBoundItem as Personnel;
                textBox1.Text = (personnel.Id).ToString();
                textBox2.Text = personnel.Name;
                textBox3.Text = personnel.Date;
                textBox4.Text = personnel.WorkingTime;
                textBox5.Text = personnel.Gender;
                
            }
            catch (Exception exception)
            {

            }
        }

        
    }
}

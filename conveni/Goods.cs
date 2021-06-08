using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace conveni
{
    
    public partial class Goods : Form
    {
        public Goods()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ID_GOODS_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ADD_GOODS_Click(object sender, EventArgs e)
        {
            Goods_ADD GOODS_ADD = new Goods_ADD();
            GOODS_ADD.ShowDialog();

        }

        private void EXIT_GOODS_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SEARCH_GOODS_Click(object sender, EventArgs e)
        {

        }
    }

    public class Good
    {
        public int id;
        public string name;
        public int amount;
        
    }
}

public static class Global
{
    public static ArrayList Goods_list;
    public static int cnt;//arraylist 구성 개수
}


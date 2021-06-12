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
    public partial class Goods_ADD : Form
    {
        int id;
        int amount;
        string name;
        public Goods_ADD()
        {
            InitializeComponent();
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {
            id = Convert.ToInt32(ID.Text);
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            Good goods = new Good();
            goods.id = id;
            goods.amount = amount;
            goods.name = name;
            //for(int i = 0; i < Global.cnt; i++)
            //{
            //    if(Global.Goods_list[i].id == goods.id)
            //    {
            //        Global.Goods_list[i].amount += goods.amount;
            //    }
            //}
            Global.Goods_list.Add(goods);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Amount_TextChanged(object sender, EventArgs e)
        {
            amount = Convert.ToInt32(Amount.Text);
        }

        private void Goods_add_name_TextChanged(object sender, EventArgs e)
        {
            name = Goods_add_name.Text;
        }
    }
}

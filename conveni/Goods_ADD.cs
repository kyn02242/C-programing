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
    public partial class Goods_ADD : Form
    {
        
        public Goods_ADD()
        {
            InitializeComponent();
        }

        
        private void Accept_Click(object sender, EventArgs e)
        {
            int id;
            int amount;
            string name;
            int price;

            id = Convert.ToInt32(ID.Text);//입력 받기
            amount = Convert.ToInt32(Amount.Text);//입력 받기
            name = Goods_add_name.Text;//입력 받기
            price = Convert.ToInt32(Price.Text);//입력 받기

            if (Global.Total_money < amount * price)
            {
                ERROR error = new ERROR();
                error.ShowDialog();
                return;
            }
            else
            {
                Global.Total_money -= amount * price;
                for (int i = 0; i < Global.cnt; i++)//id같은것 추가하면, 개수만 늘림
                {
                    if (Global.Goods_list[i].id == id)
                    {
                        Global.Goods_list[i].amount += amount;
                        Close();
                        return;

                    }
                }

                Good goods = new Good();//물품 구조체 생성

                goods.id = id;
                goods.amount = amount;
                goods.name = name;
                goods.price = price;

                Global.Goods_list[Global.cnt] = goods;//구조체를 전역변수 Goods_list 리스트에 저장
                Global.cnt++;//리스트에 저장된 개수 증가
                label1.Text = Convert.ToString(id) + "번이 추가되었습니다.";//indicator

                Close();
            }
        }
        private void ID_TextChanged(object sender, EventArgs e)
        {

        }
        private void Goods_add_name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Price_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

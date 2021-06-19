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
using System.IO;


namespace conveni
{

    public partial class Goods : Form
    {
        StreamWriter sw;
        public Goods()
        {
            InitializeComponent();
            
            int i = 0;

            this.listView1.BeginUpdate();//리스트 업데이트 시작

            ListViewItem item;

            this.listView1.Items.Clear();//리스트 일단 비우고 시작

            while (i < Global.cnt)//리스트에 구조체 배열 넣기
            {
                item = new ListViewItem(Global.Goods_list[i].id.ToString());
                item.SubItems.Add(Global.Goods_list[i].name);
                item.SubItems.Add(Global.Goods_list[i].amount.ToString() + "개");
                item.SubItems.Add(Global.Goods_list[i].price.ToString() + "원");

                this.listView1.Items.Add(item);//아이템 추가
                i++;
            }
            this.listView1.EndUpdate();//리스트 업데이트 종료
        }

        private void ID_GOODS_TextChanged(object sender, EventArgs e)
        {

        }


        private void ADD_GOODS_Click(object sender, EventArgs e)
        {
            Goods_ADD GOODS_ADD = new Goods_ADD();
            GOODS_ADD.ShowDialog();
            int i = 0;

            listView1.BeginUpdate();//리스트 업데이트 시작

            ListViewItem item;

            listView1.Items.Clear();//리스트 일단 비우고 시작

            while (i < Global.cnt)//리스트에 구조체 배열 넣기
            {
                item = new ListViewItem(Global.Goods_list[i].id.ToString());
                item.SubItems.Add(Global.Goods_list[i].name);
                item.SubItems.Add(Global.Goods_list[i].amount.ToString() + "개");
                item.SubItems.Add(Global.Goods_list[i].price.ToString() + "원");

                listView1.Items.Add(item);//아이템 추가
                i++;
            }
            listView1.EndUpdate();//리스트 업데이트 종료
            sw = new StreamWriter("물건 목록.txt");
            for (i = 0; i < Global.cnt; i++)
            {
                sw.WriteLine(Global.Goods_list[i].id);
                sw.WriteLine(Global.Goods_list[i].name);
                sw.WriteLine(Global.Goods_list[i].amount);
                sw.WriteLine(Global.Goods_list[i].price);
            }
            sw.Close();
        }

        private void EXIT_GOODS_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SEARCH_GOODS_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Global.cnt; i++)
            {
                listView1.Items[i].Selected = false;
                listView1.Items[i].Focused = false;
            }
            int id = Convert.ToInt32(ID_GOODS.Text);
            for (int i = 0; i < Global.cnt; i++)
            {
                if (Global.Goods_list[i].id == id)
                {
                    listView1.Items[i].Selected = true;
                    listView1.Items[i].Focused = true;
                    listView1.TopItem = listView1.Items[i];

                    break;
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        //private void button1_Click(object sender, EventArgs e)
        //{
            
        //    int i = 0;

        //    listView1.BeginUpdate();//리스트 업데이트 시작

        //    ListViewItem item;

        //    listView1.Items.Clear();//리스트 일단 비우고 시작

        //    while (i < Global.cnt)//리스트에 구조체 배열 넣기
        //    {
        //        item = new ListViewItem(Global.Goods_list[i].id.ToString());
        //        item.SubItems.Add(Global.Goods_list[i].name);
        //        item.SubItems.Add(Global.Goods_list[i].amount.ToString()+"개");
        //        item.SubItems.Add(Global.Goods_list[i].price.ToString()+"원");

        //        listView1.Items.Add(item);//아이템 추가
        //        i++;
        //    }
        //    listView1.EndUpdate();//리스트 업데이트 종료
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}



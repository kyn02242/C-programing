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

            //DataTable BillTable = new DataTable();
            //string str = "hello";
            //dataGridView1.DataSource = DataManager.Goods;
            //dataGridView2.DataSource = DataManager.receipts;

            int i = 0;

            this.listView2.BeginUpdate();//리스트 업데이트 시작

            ListViewItem item;

            this.listView2.Items.Clear();//리스트 일단 비우고 시작

            while (i < Global.cnt)//리스트에 구조체 배열 넣기
            {
                item = new ListViewItem(Global.Goods_list[i].id.ToString());
                item.SubItems.Add(Global.Goods_list[i].name);
                item.SubItems.Add(Global.Goods_list[i].amount.ToString() + "개");
                item.SubItems.Add(Global.Goods_list[i].price.ToString() + "원");

                this.listView2.Items.Add(item);//아이템 추가
                i++;
            }
            this.listView2.EndUpdate();//리스트 업데이트 종료

            this.listView3.BeginUpdate();
            ListViewItem item_buy;

            this.listView3.Items.Clear();//리스트 일단 비우고 시작

            i = 0;

            while (i < Global.cnt_buy)//리스트에 구조체 배열 넣기
            {
                item_buy = new ListViewItem(Global.buy_list[i].id.ToString());
                item_buy.SubItems.Add(Global.buy_list[i].name);
                item_buy.SubItems.Add(Global.buy_list[i].amount.ToString() + "개");
                item_buy.SubItems.Add(Global.buy_list[i].price.ToString() + "원");

                this.listView3.Items.Add(item_buy);//아이템 추가

                i++;
            }
            this.listView3.EndUpdate();//리스트 업데이트 종료


        }



        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            bool ExitBtnClosing;
            if (MessageBox.Show("결제 취소하시겠습니까?", "결제 취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ExitBtnClosing = true;
                this.DialogResult = DialogResult.Abort;
                Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Billshow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Change_Click(object sender, EventArgs e)
        {
            bool ExitBtnClosing;
            int rest = Convert.ToInt32(label8.Text);
            if (rest < 0)
            {
                ERROR error = new ERROR();
                error.ShowDialog();
                return;
            }
            else
            {
                if (MessageBox.Show("결제 하시겠습니까?", "결제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ExitBtnClosing = true;
                    this.DialogResult = DialogResult.Abort;
                    for (int i = 0; i < Global.cnt_buy; i++)
                    {
                        for(int j = 0; j < Global.cnt; j++)
                        {
                            if(Global.buy_list[i].id == Global.Goods_list[j].id)
                            {
                                Global.Goods_list[j].amount -= Global.buy_list[i].amount;
                                Global.Total_money += (Global.buy_list[i].amount) * (Global.buy_list[i].price);
                                break;
                            }
                        }
                    }
                    for(int i = 0; i < Global.cnt_buy; i++)
                    {
                        Global.buy_list[i].id = 0;
                        Global.buy_list[i].amount = 0;
                        Global.buy_list[i].name = null;
                        Global.buy_list[i].price = 0;
                    }
                    Global.cnt_buy = 0;
                    Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)//구매 목록으로 넣기
        {
            int id = Convert.ToInt32(textBox2.Text);
            int num = Convert.ToInt32(textBox1.Text);
            
            for(int i = 0; i < Global.cnt; i++)
            {
                if(Global.Goods_list[i].id == id)
                {
                    if (num > Global.Goods_list[i].amount)//재고보다 많은것을 요구할때
                    {
                        ERROR error = new ERROR();
                        error.ShowDialog();
                        break;
                    }
                    else//재고보다 적을때
                    {
                        for(int j = 0; j < Global.cnt_buy; j++)
                        {
                            if(Global.buy_list[j].id == id)//구매 목록에 이미 같은것이 있을때
                            {
                                Global.buy_list[j].amount = num;//해당 물품의 요구 개수만 변화
                                this.listView3.BeginUpdate();

                                ListViewItem item_by;

                                this.listView3.Items.Clear();//리스트 일단 비우고 시작

                                int l = 0;

                                while (l < Global.cnt_buy)//리스트에 구조체 배열 넣기
                                {
                                    item_by = new ListViewItem(Global.buy_list[l].id.ToString());
                                    item_by.SubItems.Add(Global.buy_list[l].name);
                                    item_by.SubItems.Add(Global.buy_list[l].amount.ToString() + "개");
                                    item_by.SubItems.Add(Global.buy_list[l].price.ToString() + "원");

                                    this.listView3.Items.Add(item_by);//아이템 추가

                                    l++;
                                }
                                this.listView3.EndUpdate();//리스트 업데이트 종료
                                int sum1 = 0;
                                for (int n = 0; n < Global.cnt_buy; n++)
                                {
                                    sum1 += (Global.buy_list[n].amount) * (Global.buy_list[n].price);
                                }
                                label6.Text = Convert.ToString(sum1);
                                return;
                            }
                        }
                        //같은것 없어서 추가해야할때
                        Global.buy_list[Global.cnt_buy].name = Global.Goods_list[id - 1].name;
                        Global.buy_list[Global.cnt_buy].price = Global.Goods_list[id - 1].price;
                        Global.buy_list[Global.cnt_buy].id = id;
                        Global.buy_list[Global.cnt_buy].amount = num;
                        Global.cnt_buy++;
                        break;
                    }
                }
            }
            this.listView3.BeginUpdate();

            ListViewItem item_buy;

            this.listView3.Items.Clear();//리스트 일단 비우고 시작

            int k = 0;

            int sum = 0;

            for(int n = 0; n < Global.cnt_buy; n++)
            {
                sum += (Global.buy_list[n].amount) * (Global.buy_list[n].price);
            }
            label6.Text = Convert.ToString(sum);

            while (k < Global.cnt_buy)//리스트에 구조체 배열 넣기
            {
                item_buy = new ListViewItem(Global.buy_list[k].id.ToString());
                item_buy.SubItems.Add(Global.buy_list[k].name);
                item_buy.SubItems.Add(Global.buy_list[k].amount.ToString() + "개");
                item_buy.SubItems.Add(Global.buy_list[k].price.ToString() + "원");

                this.listView3.Items.Add(item_buy);//아이템 추가

                k++;
            }
            this.listView3.EndUpdate();//리스트 업데이트 종료
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money = Convert.ToInt32(textBox3.Text);
            label8.Text = Convert.ToString(money - Convert.ToInt32(label6.Text));
        }
    }
        
}

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
    public partial class MainMenu : Form
    {
        bool ExitBtnClosing = false;
        public MainMenu()
        {
            InitializeComponent();
            this.label1.Text = "보유자금 : " + Convert.ToString(Global.Total_money) + "원";
        }


        private void Calculate_Click(object sender, EventArgs e)
        {
            Bill showBill = new Bill();
            showBill.ShowDialog();
            label1.Text = "보유자금 : " + Convert.ToString(Global.Total_money) + "원";
        }

        private void Personnel_Click(object sender, EventArgs e)
        {
            Employee EMPLOYEE = new Employee();
            EMPLOYEE.ShowDialog();
            label1.Text = "보유자금 : " + Convert.ToString(Global.Total_money) + "원";
        }

        private void Storage_Click(object sender, EventArgs e)
        {
            Goods GOODS = new Goods();
            GOODS.ShowDialog();
            label1.Text = "보유자금 : " + Convert.ToString(Global.Total_money) + "원";
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "편의점 시스템 종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ExitBtnClosing = true;
                this.DialogResult = DialogResult.Abort;
                Application.Exit();
            }
        }

        private void Receipt_Click(object sender, EventArgs e)
        {

        }

        private void Refund_Click(object sender, EventArgs e)
        {

        }

        private void Change_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public struct Good//구조체 선언
    {
        public int id;
        public string name;
        public int amount;
        public int price;
    }
    public struct person
    {
        public string name;
        public string time;
    }

    public static class Global//전역변수(리스트, 리스트 길이) 선언
    {
        public static Good[] Goods_list = new Good[10000];
        public static person[] person_list = new person[100];
        public static Good[] buy_list = new Good[10000];
        public static int cnt = 0;
        public static int tmp = 0;
        public static int cnt_buy = 0;
        public static int Total_money = 100000000;
    }
}
    

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
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace conveni
{
    public partial class MainMenu : Form
    {
        bool ExitBtnClosing = false;
        public MainMenu()
        {
            InitializeComponent();
            //목록들 불러오기
            StreamReader sr_e = new StreamReader("직원 목록.txt");
            StreamReader sr_g = new StreamReader("물건 목록.txt");

            int lineCount = File.ReadAllLines("직원 목록.txt").Length;
            for(int i = 0; i < lineCount; i++)
            {
                Global.person_list[i].name = sr_e.ReadLine();
                Global.person_list[i].time = sr_e.ReadLine();
            }
            Global.tmp = lineCount / 2;
            sr_e.Close();

            lineCount = File.ReadAllLines("물건 목록.txt").Length;
            for(int i = 0; i < lineCount; i++)
            {
                Global.Goods_list[i].id = Convert.ToInt32(sr_g.ReadLine());
                Global.Goods_list[i].name = sr_g.ReadLine();
                Global.Goods_list[i].amount = Convert.ToInt32(sr_g.ReadLine());
                Global.Goods_list[i].price = Convert.ToInt32(sr_g.ReadLine());
                Global.Total_money -= Global.Goods_list[i].amount * Global.Goods_list[i].price;
            }
            Global.cnt = lineCount / 4;
            sr_g.Close();
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
            Receipt receipt = new Receipt();
            receipt.ShowDialog();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
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
        public static int cnt = 0; //물품 수
        public static int tmp = 0; // 직원 수
        public static int cnt_buy = 0; //장바구니 물품 수
        public static int Total_money = 100000000;
    }
}
    

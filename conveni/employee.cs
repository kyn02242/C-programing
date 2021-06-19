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
    public partial class Employee : Form
    {
        StreamWriter sw;
        private Timer Timer = null;
        public Employee()
        {
            InitializeComponent();

            this.EMPLOYEE_TIME.Text = DateTime.Now.ToString();

            this.Timer = new Timer();
            this.Timer.Tick += Timer_Tick;
            this.Timer.Interval = 1000;
            this.Timer.Start();

            int i = 0;

            this.listView1.BeginUpdate();//리스트 업데이트 시작

            ListViewItem item;

            this.listView1.Items.Clear();//리스트 일단 비우고 시작

            while (i < Global.tmp)//리스트에 구조체 배열 넣기
            {
                item = new ListViewItem(Global.person_list[i].name);
                item.SubItems.Add(Global.person_list[i].time);

                this.listView1.Items.Add(item);//아이템 추가

                i++;
            }
            this.listView1.EndUpdate();//리스트 업데이트 종료
        }

        private void EMPLOYEE_LEFTTIME_Click(object sender, EventArgs e)
        {

        }

        private void EMPLOYEE_EXIT_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void EMPLOYEE_ADD_Click(object sender, EventArgs e)
        {
            personal person_add = new personal();
            person_add.ShowDialog();
            int i = 0;

            listView1.BeginUpdate();//리스트 업데이트 시작

            ListViewItem item;

            listView1.Items.Clear();//리스트 일단 비우고 시작

            while (i < Global.tmp)//리스트에 구조체 배열 넣기
            {
                item = new ListViewItem(Global.person_list[i].name);
                item.SubItems.Add(Global.person_list[i].time);

                listView1.Items.Add(item);//아이템 추가

                i++;
            }
            listView1.EndUpdate();//리스트 업데이트 종료

            sw = new StreamWriter("직원 목록.txt");
            for(i = 0;i<Global.tmp; i++)
            {
                sw.WriteLine(Global.person_list[i].name);
                sw.WriteLine(Global.person_list[i].time);
            }
            sw.Close();
        }

        private void EMPLOYEE_LIST_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//갱신버튼 클릭 1.시간 최신화 2.리스트 최신화
        {
            
            int i = 0;

            listView1.BeginUpdate();//리스트 업데이트 시작

            ListViewItem item;

            listView1.Items.Clear();//리스트 일단 비우고 시작

            while (i < Global.tmp)//리스트에 구조체 배열 넣기
            {
                item = new ListViewItem(Global.person_list[i].name);
                item.SubItems.Add(Global.person_list[i].time);

                listView1.Items.Add(item);//아이템 추가

                i++;
            }
            listView1.EndUpdate();//리스트 업데이트 종료
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            EMPLOYEE_TIME.Text = DateTime.Now.ToString();
            
        }

        private void EMPLOYEE_TIME_Click(object sender, EventArgs e)
        {
             
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
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
        }


        private void Calculate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello!");
        }

        private void Personnel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("making!");
        }

        private void Storage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All right");
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("종료하시겠습니까?" , "편의점 시스템 종료" ,MessageBoxButtons.YesNo) == DialogResult.Yes)
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
    }
}
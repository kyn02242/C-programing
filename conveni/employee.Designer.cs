
namespace conveni
{
    partial class Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EMPLOYEE_CALENDAR = new System.Windows.Forms.MonthCalendar();
            this.EMPLOYEE_TIME = new System.Windows.Forms.Label();
            this.EMPLOYEE_LIST = new System.Windows.Forms.ListBox();
            this.EMPLOYEE_STARTTIME = new System.Windows.Forms.Label();
            this.EMPLOYEE_ENDTIME = new System.Windows.Forms.Label();
            this.EMPLOYEE_LEFTTIME = new System.Windows.Forms.Label();
            this.EMPLOYEE_ADD = new System.Windows.Forms.Button();
            this.EMPLOYEE_EXIT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EMPLOYEE_CALENDAR
            // 
            this.EMPLOYEE_CALENDAR.Location = new System.Drawing.Point(26, 23);
            this.EMPLOYEE_CALENDAR.Margin = new System.Windows.Forms.Padding(13, 15, 13, 15);
            this.EMPLOYEE_CALENDAR.Name = "EMPLOYEE_CALENDAR";
            this.EMPLOYEE_CALENDAR.TabIndex = 0;
            // 
            // EMPLOYEE_TIME
            // 
            this.EMPLOYEE_TIME.AutoSize = true;
            this.EMPLOYEE_TIME.Location = new System.Drawing.Point(509, 337);
            this.EMPLOYEE_TIME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EMPLOYEE_TIME.Name = "EMPLOYEE_TIME";
            this.EMPLOYEE_TIME.Size = new System.Drawing.Size(90, 25);
            this.EMPLOYEE_TIME.TabIndex = 1;
            this.EMPLOYEE_TIME.Text = "현재 시간";
            // 
            // EMPLOYEE_LIST
            // 
            this.EMPLOYEE_LIST.FormattingEnabled = true;
            this.EMPLOYEE_LIST.ItemHeight = 25;
            this.EMPLOYEE_LIST.Location = new System.Drawing.Point(357, 12);
            this.EMPLOYEE_LIST.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EMPLOYEE_LIST.Name = "EMPLOYEE_LIST";
            this.EMPLOYEE_LIST.Size = new System.Drawing.Size(508, 279);
            this.EMPLOYEE_LIST.TabIndex = 2;
            this.EMPLOYEE_LIST.SelectedIndexChanged += new System.EventHandler(this.EMPLOYEE_LIST_SelectedIndexChanged);
            // 
            // EMPLOYEE_STARTTIME
            // 
            this.EMPLOYEE_STARTTIME.AutoSize = true;
            this.EMPLOYEE_STARTTIME.Location = new System.Drawing.Point(487, 450);
            this.EMPLOYEE_STARTTIME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EMPLOYEE_STARTTIME.Name = "EMPLOYEE_STARTTIME";
            this.EMPLOYEE_STARTTIME.Size = new System.Drawing.Size(132, 25);
            this.EMPLOYEE_STARTTIME.TabIndex = 3;
            this.EMPLOYEE_STARTTIME.Text = "근무 시작 시간";
            // 
            // EMPLOYEE_ENDTIME
            // 
            this.EMPLOYEE_ENDTIME.AutoSize = true;
            this.EMPLOYEE_ENDTIME.Location = new System.Drawing.Point(487, 573);
            this.EMPLOYEE_ENDTIME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EMPLOYEE_ENDTIME.Name = "EMPLOYEE_ENDTIME";
            this.EMPLOYEE_ENDTIME.Size = new System.Drawing.Size(132, 25);
            this.EMPLOYEE_ENDTIME.TabIndex = 4;
            this.EMPLOYEE_ENDTIME.Text = "근무 종료 시간";
            // 
            // EMPLOYEE_LEFTTIME
            // 
            this.EMPLOYEE_LEFTTIME.AutoSize = true;
            this.EMPLOYEE_LEFTTIME.Location = new System.Drawing.Point(487, 685);
            this.EMPLOYEE_LEFTTIME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EMPLOYEE_LEFTTIME.Name = "EMPLOYEE_LEFTTIME";
            this.EMPLOYEE_LEFTTIME.Size = new System.Drawing.Size(132, 25);
            this.EMPLOYEE_LEFTTIME.TabIndex = 5;
            this.EMPLOYEE_LEFTTIME.Text = "근무 남은 시간";
            this.EMPLOYEE_LEFTTIME.Click += new System.EventHandler(this.EMPLOYEE_LEFTTIME_Click);
            // 
            // EMPLOYEE_ADD
            // 
            this.EMPLOYEE_ADD.Location = new System.Drawing.Point(876, 389);
            this.EMPLOYEE_ADD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EMPLOYEE_ADD.Name = "EMPLOYEE_ADD";
            this.EMPLOYEE_ADD.Size = new System.Drawing.Size(250, 125);
            this.EMPLOYEE_ADD.TabIndex = 6;
            this.EMPLOYEE_ADD.Text = "직원 고용";
            this.EMPLOYEE_ADD.UseVisualStyleBackColor = true;
            this.EMPLOYEE_ADD.Click += new System.EventHandler(this.EMPLOYEE_ADD_Click);
            // 
            // EMPLOYEE_EXIT
            // 
            this.EMPLOYEE_EXIT.Location = new System.Drawing.Point(876, 605);
            this.EMPLOYEE_EXIT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EMPLOYEE_EXIT.Name = "EMPLOYEE_EXIT";
            this.EMPLOYEE_EXIT.Size = new System.Drawing.Size(250, 125);
            this.EMPLOYEE_EXIT.TabIndex = 8;
            this.EMPLOYEE_EXIT.Text = "종료";
            this.EMPLOYEE_EXIT.UseVisualStyleBackColor = true;
            this.EMPLOYEE_EXIT.Click += new System.EventHandler(this.EMPLOYEE_EXIT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 450);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "근무 시작 시간";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 573);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "근무 종료 시간";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 685);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "근무 남은 시간";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 337);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "현재 시간";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EMPLOYEE_EXIT);
            this.Controls.Add(this.EMPLOYEE_ADD);
            this.Controls.Add(this.EMPLOYEE_LEFTTIME);
            this.Controls.Add(this.EMPLOYEE_ENDTIME);
            this.Controls.Add(this.EMPLOYEE_STARTTIME);
            this.Controls.Add(this.EMPLOYEE_LIST);
            this.Controls.Add(this.EMPLOYEE_TIME);
            this.Controls.Add(this.EMPLOYEE_CALENDAR);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Employee";
            this.Text = "employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar EMPLOYEE_CALENDAR;
        private System.Windows.Forms.Label EMPLOYEE_TIME;
        private System.Windows.Forms.ListBox EMPLOYEE_LIST;
        private System.Windows.Forms.Label EMPLOYEE_STARTTIME;
        private System.Windows.Forms.Label EMPLOYEE_ENDTIME;
        private System.Windows.Forms.Label EMPLOYEE_LEFTTIME;
        private System.Windows.Forms.Button EMPLOYEE_ADD;
        private System.Windows.Forms.Button EMPLOYEE_EXIT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}
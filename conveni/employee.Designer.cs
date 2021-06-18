
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
            this.EMPLOYEE_ADD = new System.Windows.Forms.Button();
            this.EMPLOYEE_EXIT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.time = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // EMPLOYEE_CALENDAR
            // 
            this.EMPLOYEE_CALENDAR.Location = new System.Drawing.Point(18, 12);
            this.EMPLOYEE_CALENDAR.Name = "EMPLOYEE_CALENDAR";
            this.EMPLOYEE_CALENDAR.TabIndex = 0;
            // 
            // EMPLOYEE_TIME
            // 
            this.EMPLOYEE_TIME.AutoSize = true;
            this.EMPLOYEE_TIME.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EMPLOYEE_TIME.Location = new System.Drawing.Point(241, 274);
            this.EMPLOYEE_TIME.Name = "EMPLOYEE_TIME";
            this.EMPLOYEE_TIME.Size = new System.Drawing.Size(134, 37);
            this.EMPLOYEE_TIME.TabIndex = 1;
            this.EMPLOYEE_TIME.Text = "현재 시간";
            this.EMPLOYEE_TIME.Click += new System.EventHandler(this.EMPLOYEE_TIME_Click);
            // 
            // EMPLOYEE_ADD
            // 
            this.EMPLOYEE_ADD.Location = new System.Drawing.Point(613, 233);
            this.EMPLOYEE_ADD.Name = "EMPLOYEE_ADD";
            this.EMPLOYEE_ADD.Size = new System.Drawing.Size(175, 75);
            this.EMPLOYEE_ADD.TabIndex = 6;
            this.EMPLOYEE_ADD.Text = "직원 고용";
            this.EMPLOYEE_ADD.UseVisualStyleBackColor = true;
            this.EMPLOYEE_ADD.Click += new System.EventHandler(this.EMPLOYEE_ADD_Click);
            // 
            // EMPLOYEE_EXIT
            // 
            this.EMPLOYEE_EXIT.Location = new System.Drawing.Point(613, 363);
            this.EMPLOYEE_EXIT.Name = "EMPLOYEE_EXIT";
            this.EMPLOYEE_EXIT.Size = new System.Drawing.Size(175, 75);
            this.EMPLOYEE_EXIT.TabIndex = 8;
            this.EMPLOYEE_EXIT.Text = "종료";
            this.EMPLOYEE_EXIT.UseVisualStyleBackColor = true;
            this.EMPLOYEE_EXIT.Click += new System.EventHandler(this.EMPLOYEE_EXIT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "현재 시간";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 63);
            this.button1.TabIndex = 14;
            this.button1.Text = "갱신";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.time});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(250, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(345, 162);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Text = "    이름    ";
            this.name.Width = 68;
            // 
            // time
            // 
            this.time.Text = "시간";
            this.time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.time.Width = 273;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EMPLOYEE_EXIT);
            this.Controls.Add(this.EMPLOYEE_ADD);
            this.Controls.Add(this.EMPLOYEE_TIME);
            this.Controls.Add(this.EMPLOYEE_CALENDAR);
            this.Name = "Employee";
            this.Text = "employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar EMPLOYEE_CALENDAR;
        private System.Windows.Forms.Label EMPLOYEE_TIME;
        private System.Windows.Forms.Button EMPLOYEE_ADD;
        private System.Windows.Forms.Button EMPLOYEE_EXIT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader name;
    }
}
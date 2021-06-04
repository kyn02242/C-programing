
namespace conveni
{
    partial class Bill
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
            this.label3 = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.Button();
            this.Waitexit = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Billshow = new System.Windows.Forms.DataGridView();
            this.상품이름 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상품코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.가격 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listView2 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.Billshow)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(211, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "상품 목록";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(790, 599);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(199, 65);
            this.Change.TabIndex = 14;
            this.Change.Text = "결제하기";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Waitexit
            // 
            this.Waitexit.Location = new System.Drawing.Point(801, 738);
            this.Waitexit.Name = "Waitexit";
            this.Waitexit.Size = new System.Drawing.Size(110, 65);
            this.Waitexit.TabIndex = 16;
            this.Waitexit.Text = "대기";
            this.Waitexit.UseVisualStyleBackColor = true;
            this.Waitexit.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 32;
            this.listBox2.Items.AddRange(new object[] {
            "받을 금액",
            "",
            "결제할 금액",
            "거스름돈"});
            this.listBox2.Location = new System.Drawing.Point(553, 437);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(170, 132);
            this.listBox2.TabIndex = 20;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(759, 437);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(230, 132);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(934, 738);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(106, 65);
            this.exit.TabIndex = 22;
            this.exit.Text = "결제 취소";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 599);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 65);
            this.button1.TabIndex = 23;
            this.button1.Text = "금액 투입";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Billshow
            // 
            this.Billshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Billshow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.상품이름,
            this.상품코드,
            this.가격});
            this.Billshow.Location = new System.Drawing.Point(12, 118);
            this.Billshow.Name = "Billshow";
            this.Billshow.RowHeadersWidth = 62;
            this.Billshow.RowTemplate.Height = 33;
            this.Billshow.Size = new System.Drawing.Size(514, 604);
            this.Billshow.TabIndex = 24;
            this.Billshow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Billshow_CellContentClick);
            // 
            // 상품이름
            // 
            this.상품이름.HeaderText = "상품이름";
            this.상품이름.MinimumWidth = 8;
            this.상품이름.Name = "상품이름";
            this.상품이름.Width = 150;
            // 
            // 상품코드
            // 
            this.상품코드.HeaderText = "상품코드";
            this.상품코드.MinimumWidth = 8;
            this.상품코드.Name = "상품코드";
            this.상품코드.Width = 150;
            // 
            // 가격
            // 
            this.가격.HeaderText = "가격";
            this.가격.MinimumWidth = 8;
            this.가격.Name = "가격";
            this.가격.Width = 150;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(553, 118);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(436, 284);
            this.listView2.TabIndex = 26;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 852);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.Billshow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.Waitexit);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.label3);
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Billshow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Waitexit;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Billshow;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상품이름;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상품코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 가격;
        private System.Windows.Forms.ListView listView2;
    }
}
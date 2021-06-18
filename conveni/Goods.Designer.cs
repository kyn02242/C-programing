
namespace conveni
{
    partial class Goods
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
            this.ID_GOODS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ADD_GOODS = new System.Windows.Forms.Button();
            this.EXIT_GOODS = new System.Windows.Forms.Button();
            this.SEARCH_GOODS = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.amount = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID_GOODS
            // 
            this.ID_GOODS.Location = new System.Drawing.Point(871, 35);
            this.ID_GOODS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ID_GOODS.Name = "ID_GOODS";
            this.ID_GOODS.Size = new System.Drawing.Size(253, 31);
            this.ID_GOODS.TabIndex = 1;
            this.ID_GOODS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ID_GOODS.TextChanged += new System.EventHandler(this.ID_GOODS_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(836, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ADD_GOODS
            // 
            this.ADD_GOODS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ADD_GOODS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ADD_GOODS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ADD_GOODS.Location = new System.Drawing.Point(926, 199);
            this.ADD_GOODS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ADD_GOODS.Name = "ADD_GOODS";
            this.ADD_GOODS.Size = new System.Drawing.Size(163, 90);
            this.ADD_GOODS.TabIndex = 3;
            this.ADD_GOODS.Text = "상품/수량 추가";
            this.ADD_GOODS.UseVisualStyleBackColor = false;
            this.ADD_GOODS.Click += new System.EventHandler(this.ADD_GOODS_Click);
            // 
            // EXIT_GOODS
            // 
            this.EXIT_GOODS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.EXIT_GOODS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EXIT_GOODS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXIT_GOODS.Location = new System.Drawing.Point(926, 430);
            this.EXIT_GOODS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EXIT_GOODS.Name = "EXIT_GOODS";
            this.EXIT_GOODS.Size = new System.Drawing.Size(163, 90);
            this.EXIT_GOODS.TabIndex = 4;
            this.EXIT_GOODS.Text = "종료";
            this.EXIT_GOODS.UseVisualStyleBackColor = false;
            this.EXIT_GOODS.Click += new System.EventHandler(this.EXIT_GOODS_Click);
            // 
            // SEARCH_GOODS
            // 
            this.SEARCH_GOODS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SEARCH_GOODS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SEARCH_GOODS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SEARCH_GOODS.Location = new System.Drawing.Point(926, 87);
            this.SEARCH_GOODS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SEARCH_GOODS.Name = "SEARCH_GOODS";
            this.SEARCH_GOODS.Size = new System.Drawing.Size(163, 73);
            this.SEARCH_GOODS.TabIndex = 2;
            this.SEARCH_GOODS.Text = "검색";
            this.SEARCH_GOODS.UseVisualStyleBackColor = false;
            this.SEARCH_GOODS.Click += new System.EventHandler(this.SEARCH_GOODS_Click);
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.name,
            this.amount,
            this.Price});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(17, 35);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(808, 529);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 80;
            // 
            // name
            // 
            this.name.Text = "이름";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.Width = 203;
            // 
            // amount
            // 
            this.amount.Text = "수량";
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amount.Width = 120;
            // 
            // Price
            // 
            this.Price.Text = "가격";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Width = 160;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(926, 317);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 86);
            this.button1.TabIndex = 0;
            this.button1.Text = "갱신";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Goods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::conveni.Properties.Resources.thumb_d_398D2558C2751C55DAB3094C7C67AE66;
            this.ClientSize = new System.Drawing.Size(1142, 633);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.SEARCH_GOODS);
            this.Controls.Add(this.EXIT_GOODS);
            this.Controls.Add(this.ADD_GOODS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID_GOODS);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Goods";
            this.Text = "Goods";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ID_GOODS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ADD_GOODS;
        private System.Windows.Forms.Button EXIT_GOODS;
        private System.Windows.Forms.Button SEARCH_GOODS;
        private System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ColumnHeader ID;
        public System.Windows.Forms.ColumnHeader 이름;
        public System.Windows.Forms.ColumnHeader amount;
        public System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader Price;
    }
}
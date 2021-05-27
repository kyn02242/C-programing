
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
            this.LIST_GOODS = new System.Windows.Forms.ListBox();
            this.SEARCH_GOODS = new System.Windows.Forms.Button();
            this.ID_GOODS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ADD_GOODS = new System.Windows.Forms.Button();
            this.EXIT_GOODS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LIST_GOODS
            // 
            this.LIST_GOODS.FormattingEnabled = true;
            this.LIST_GOODS.ItemHeight = 15;
            this.LIST_GOODS.Location = new System.Drawing.Point(12, 12);
            this.LIST_GOODS.Name = "LIST_GOODS";
            this.LIST_GOODS.Size = new System.Drawing.Size(567, 424);
            this.LIST_GOODS.TabIndex = 0;
            this.LIST_GOODS.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SEARCH_GOODS
            // 
            this.SEARCH_GOODS.Location = new System.Drawing.Point(663, 50);
            this.SEARCH_GOODS.Name = "SEARCH_GOODS";
            this.SEARCH_GOODS.Size = new System.Drawing.Size(125, 46);
            this.SEARCH_GOODS.TabIndex = 1;
            this.SEARCH_GOODS.Text = "검색";
            this.SEARCH_GOODS.UseVisualStyleBackColor = true;
            this.SEARCH_GOODS.Click += new System.EventHandler(this.button1_Click);
            // 
            // ID_GOODS
            // 
            this.ID_GOODS.Location = new System.Drawing.Point(610, 21);
            this.ID_GOODS.Name = "ID_GOODS";
            this.ID_GOODS.Size = new System.Drawing.Size(178, 23);
            this.ID_GOODS.TabIndex = 2;
            this.ID_GOODS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ID_GOODS.TextChanged += new System.EventHandler(this.ID_GOODS_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // ADD_GOODS
            // 
            this.ADD_GOODS.Location = new System.Drawing.Point(610, 269);
            this.ADD_GOODS.Name = "ADD_GOODS";
            this.ADD_GOODS.Size = new System.Drawing.Size(177, 71);
            this.ADD_GOODS.TabIndex = 4;
            this.ADD_GOODS.Text = "상품 추가";
            this.ADD_GOODS.UseVisualStyleBackColor = true;
            this.ADD_GOODS.Click += new System.EventHandler(this.ADD_GOODS_Click);
            // 
            // EXIT_GOODS
            // 
            this.EXIT_GOODS.Location = new System.Drawing.Point(610, 365);
            this.EXIT_GOODS.Name = "EXIT_GOODS";
            this.EXIT_GOODS.Size = new System.Drawing.Size(177, 71);
            this.EXIT_GOODS.TabIndex = 5;
            this.EXIT_GOODS.Text = "종료";
            this.EXIT_GOODS.UseVisualStyleBackColor = true;
            this.EXIT_GOODS.Click += new System.EventHandler(this.EXIT_GOODS_Click);
            // 
            // Goods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EXIT_GOODS);
            this.Controls.Add(this.ADD_GOODS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID_GOODS);
            this.Controls.Add(this.SEARCH_GOODS);
            this.Controls.Add(this.LIST_GOODS);
            this.Name = "Goods";
            this.Text = "Goods";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LIST_GOODS;
        private System.Windows.Forms.Button SEARCH_GOODS;
        private System.Windows.Forms.TextBox ID_GOODS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ADD_GOODS;
        private System.Windows.Forms.Button EXIT_GOODS;
    }
}
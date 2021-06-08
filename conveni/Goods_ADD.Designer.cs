
namespace conveni
{
    partial class Goods_ADD
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
            this.Accept = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.TextBox();
            this.ID_indicator = new System.Windows.Forms.Label();
            this.Amount_indicator = new System.Windows.Forms.Label();
            this.Name_indicator = new System.Windows.Forms.Label();
            this.Goods_add_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(209, 250);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(75, 23);
            this.Accept.TabIndex = 0;
            this.Accept.Text = "확인";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(290, 250);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "취소";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(39, 48);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(186, 23);
            this.ID.TabIndex = 2;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(39, 182);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(186, 23);
            this.Amount.TabIndex = 3;
            this.Amount.TextChanged += new System.EventHandler(this.Amount_TextChanged);
            // 
            // ID_indicator
            // 
            this.ID_indicator.AutoSize = true;
            this.ID_indicator.Location = new System.Drawing.Point(39, 30);
            this.ID_indicator.Name = "ID_indicator";
            this.ID_indicator.Size = new System.Drawing.Size(19, 15);
            this.ID_indicator.TabIndex = 4;
            this.ID_indicator.Text = "ID";
            // 
            // Amount_indicator
            // 
            this.Amount_indicator.AutoSize = true;
            this.Amount_indicator.Location = new System.Drawing.Point(39, 164);
            this.Amount_indicator.Name = "Amount_indicator";
            this.Amount_indicator.Size = new System.Drawing.Size(31, 15);
            this.Amount_indicator.TabIndex = 5;
            this.Amount_indicator.Text = "수량";
            // 
            // Name_indicator
            // 
            this.Name_indicator.AutoSize = true;
            this.Name_indicator.Location = new System.Drawing.Point(39, 98);
            this.Name_indicator.Name = "Name_indicator";
            this.Name_indicator.Size = new System.Drawing.Size(31, 15);
            this.Name_indicator.TabIndex = 7;
            this.Name_indicator.Text = "이름";
            // 
            // Goods_add_name
            // 
            this.Goods_add_name.Location = new System.Drawing.Point(39, 116);
            this.Goods_add_name.Name = "Goods_add_name";
            this.Goods_add_name.Size = new System.Drawing.Size(186, 23);
            this.Goods_add_name.TabIndex = 6;
            this.Goods_add_name.TextChanged += new System.EventHandler(this.Goods_add_name_TextChanged);
            // 
            // Goods_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 285);
            this.Controls.Add(this.Name_indicator);
            this.Controls.Add(this.Goods_add_name);
            this.Controls.Add(this.Amount_indicator);
            this.Controls.Add(this.ID_indicator);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Accept);
            this.Name = "Goods_ADD";
            this.Text = "Goods_ADD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Label ID_indicator;
        private System.Windows.Forms.Label Amount_indicator;
        private System.Windows.Forms.Label Name_indicator;
        private System.Windows.Forms.TextBox Goods;
        private System.Windows.Forms.TextBox Goods_add_name;
    }
}
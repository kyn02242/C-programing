
namespace conveni
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Calculate = new System.Windows.Forms.Button();
            this.Personnel = new System.Windows.Forms.Button();
            this.Storage = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Receipt = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.Refund = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Wait1 = new System.Windows.Forms.Button();
            this.Wait2 = new System.Windows.Forms.Button();
            this.Wait3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(396, 69);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(244, 105);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "계산";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Personnel
            // 
            this.Personnel.Location = new System.Drawing.Point(326, 426);
            this.Personnel.Name = "Personnel";
            this.Personnel.Size = new System.Drawing.Size(198, 65);
            this.Personnel.TabIndex = 1;
            this.Personnel.Text = "직원 조회";
            this.Personnel.UseVisualStyleBackColor = true;
            this.Personnel.Click += new System.EventHandler(this.Personnel_Click);
            // 
            // Storage
            // 
            this.Storage.Location = new System.Drawing.Point(87, 539);
            this.Storage.Name = "Storage";
            this.Storage.Size = new System.Drawing.Size(198, 65);
            this.Storage.TabIndex = 2;
            this.Storage.Text = "재고 조회";
            this.Storage.UseVisualStyleBackColor = true;
            this.Storage.Click += new System.EventHandler(this.Storage_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(888, 650);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(136, 36);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "종료";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Receipt
            // 
            this.Receipt.Location = new System.Drawing.Point(87, 426);
            this.Receipt.Name = "Receipt";
            this.Receipt.Size = new System.Drawing.Size(198, 65);
            this.Receipt.TabIndex = 4;
            this.Receipt.Text = "영수증 조회";
            this.Receipt.UseVisualStyleBackColor = true;
            this.Receipt.Click += new System.EventHandler(this.Receipt_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(674, 308);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(174, 41);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(637, 451);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(211, 126);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // Refund
            // 
            this.Refund.Location = new System.Drawing.Point(888, 491);
            this.Refund.Name = "Refund";
            this.Refund.Size = new System.Drawing.Size(136, 86);
            this.Refund.TabIndex = 7;
            this.Refund.Text = "환불";
            this.Refund.UseVisualStyleBackColor = true;
            this.Refund.Click += new System.EventHandler(this.Refund_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(326, 539);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(198, 65);
            this.Change.TabIndex = 8;
            this.Change.Text = "수정";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(674, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "현재 금고 현황";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(653, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "직전 결제 내역";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(212, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "통합 조회 시스템";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Wait1
            // 
            this.Wait1.Location = new System.Drawing.Point(888, 296);
            this.Wait1.Name = "Wait1";
            this.Wait1.Size = new System.Drawing.Size(112, 34);
            this.Wait1.TabIndex = 13;
            this.Wait1.Text = "대기1";
            this.Wait1.UseVisualStyleBackColor = true;
            // 
            // Wait2
            // 
            this.Wait2.Location = new System.Drawing.Point(888, 350);
            this.Wait2.Name = "Wait2";
            this.Wait2.Size = new System.Drawing.Size(112, 34);
            this.Wait2.TabIndex = 14;
            this.Wait2.Text = "대기2";
            this.Wait2.UseVisualStyleBackColor = true;
            // 
            // Wait3
            // 
            this.Wait3.Location = new System.Drawing.Point(888, 409);
            this.Wait3.Name = "Wait3";
            this.Wait3.Size = new System.Drawing.Size(112, 34);
            this.Wait3.TabIndex = 15;
            this.Wait3.Text = "대기3";
            this.Wait3.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 698);
            this.Controls.Add(this.Wait3);
            this.Controls.Add(this.Wait2);
            this.Controls.Add(this.Wait1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Refund);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Receipt);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Storage);
            this.Controls.Add(this.Personnel);
            this.Controls.Add(this.Calculate);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Personnel;
        private System.Windows.Forms.Button Storage;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Receipt;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button Refund;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Wait1;
        private System.Windows.Forms.Button Wait2;
        private System.Windows.Forms.Button Wait3;
    }
}



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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.AutoSize = true;
            this.Calculate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Calculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calculate.Location = new System.Drawing.Point(277, 41);
            this.Calculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(171, 63);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "계산";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Personnel
            // 
            this.Personnel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Personnel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Personnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Personnel.Location = new System.Drawing.Point(226, 229);
            this.Personnel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Personnel.Name = "Personnel";
            this.Personnel.Size = new System.Drawing.Size(139, 39);
            this.Personnel.TabIndex = 1;
            this.Personnel.Text = "직원 조회";
            this.Personnel.UseVisualStyleBackColor = false;
            this.Personnel.Click += new System.EventHandler(this.Personnel_Click);
            // 
            // Storage
            // 
            this.Storage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Storage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Storage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Storage.Location = new System.Drawing.Point(147, 295);
            this.Storage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Storage.Name = "Storage";
            this.Storage.Size = new System.Drawing.Size(139, 39);
            this.Storage.TabIndex = 2;
            this.Storage.Text = "재고 조회";
            this.Storage.UseVisualStyleBackColor = false;
            this.Storage.Click += new System.EventHandler(this.Storage_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(603, 325);
            this.Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(95, 30);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "종료";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Receipt
            // 
            this.Receipt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Receipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Receipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Receipt.Location = new System.Drawing.Point(54, 229);
            this.Receipt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Receipt.Name = "Receipt";
            this.Receipt.Size = new System.Drawing.Size(139, 39);
            this.Receipt.TabIndex = 4;
            this.Receipt.Text = "영수증 조회";
            this.Receipt.UseVisualStyleBackColor = false;
            this.Receipt.Click += new System.EventHandler(this.Receipt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(477, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "현재 금고 현황";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(148, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "통합 조회 시스템";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::conveni.Properties.Resources.thumb_d_398D2558C2751C55DAB3094C7C67AE66;
            this.ClientSize = new System.Drawing.Size(725, 388);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Receipt);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Storage);
            this.Controls.Add(this.Personnel);
            this.Controls.Add(this.Calculate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenu";
            this.Text = "편의점 MainMenu";
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
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
    }
}


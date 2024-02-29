namespace FormAppJob
{
    partial class UV_TrangChu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHS = new System.Windows.Forms.Button();
            this.btnTB = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnUT = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 288);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "HỒ SƠ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 288);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "ỨNG TUYỂN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(541, 288);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(178, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "LỊCH SỬ ỨNG TUYỂN";
            // 
            // btnHS
            // 
            this.btnHS.BackgroundImage = global::FormAppJob.Properties.Resources.profile;
            this.btnHS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHS.Location = new System.Drawing.Point(76, 138);
            this.btnHS.Name = "btnHS";
            this.btnHS.Size = new System.Drawing.Size(153, 135);
            this.btnHS.TabIndex = 30;
            this.btnHS.UseVisualStyleBackColor = true;
            this.btnHS.Click += new System.EventHandler(this.btnHS_Click);
            // 
            // btnTB
            // 
            this.btnTB.BackgroundImage = global::FormAppJob.Properties.Resources.notification;
            this.btnTB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTB.Location = new System.Drawing.Point(22, 21);
            this.btnTB.Name = "btnTB";
            this.btnTB.Size = new System.Drawing.Size(46, 40);
            this.btnTB.TabIndex = 29;
            this.btnTB.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = global::FormAppJob.Properties.Resources.logout;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.Location = new System.Drawing.Point(711, 21);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(62, 56);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnUT
            // 
            this.btnUT.BackgroundImage = global::FormAppJob.Properties.Resources.apply;
            this.btnUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUT.Location = new System.Drawing.Point(309, 138);
            this.btnUT.Name = "btnUT";
            this.btnUT.Size = new System.Drawing.Size(152, 135);
            this.btnUT.TabIndex = 3;
            this.btnUT.UseVisualStyleBackColor = true;
            this.btnUT.Click += new System.EventHandler(this.btnUT_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackgroundImage = global::FormAppJob.Properties.Resources.history__1_;
            this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHistory.Location = new System.Drawing.Point(558, 138);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(145, 135);
            this.btnHistory.TabIndex = 31;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // UV_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(803, 443);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnHS);
            this.Controls.Add(this.btnTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnUT);
            this.Name = "UV_TrangChu";
            this.Text = "Trang Chủ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUT;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTB;
        private System.Windows.Forms.Button btnHS;
        private System.Windows.Forms.Button btnHistory;
    }
}
namespace FormAppJob
{
    partial class DangKy
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tenTK = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_Confirm = new System.Windows.Forms.TextBox();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.btn_UngVien = new System.Windows.Forms.RadioButton();
            this.btn_DoanhNghiep = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(96, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên tài khoản :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(96, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(96, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(96, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Xác nhận lại mật khẩu :";
            // 
            // txt_tenTK
            // 
            this.txt_tenTK.Location = new System.Drawing.Point(287, 213);
            this.txt_tenTK.Name = "txt_tenTK";
            this.txt_tenTK.Size = new System.Drawing.Size(343, 22);
            this.txt_tenTK.TabIndex = 6;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(287, 254);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(343, 22);
            this.txt_Email.TabIndex = 7;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(287, 294);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(343, 22);
            this.txt_Pass.TabIndex = 8;
            // 
            // txt_Confirm
            // 
            this.txt_Confirm.Location = new System.Drawing.Point(287, 336);
            this.txt_Confirm.Name = "txt_Confirm";
            this.txt_Confirm.Size = new System.Drawing.Size(343, 22);
            this.txt_Confirm.TabIndex = 9;
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_DangKy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKy.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_DangKy.Location = new System.Drawing.Point(367, 387);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(96, 36);
            this.btn_DangKy.TabIndex = 10;
            this.btn_DangKy.Text = "Đăng ký";
            this.btn_DangKy.UseVisualStyleBackColor = false;
            // 
            // btn_UngVien
            // 
            this.btn_UngVien.AutoSize = true;
            this.btn_UngVien.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UngVien.Location = new System.Drawing.Point(398, 186);
            this.btn_UngVien.Name = "btn_UngVien";
            this.btn_UngVien.Size = new System.Drawing.Size(85, 21);
            this.btn_UngVien.TabIndex = 11;
            this.btn_UngVien.TabStop = true;
            this.btn_UngVien.Text = "Ứng viên";
            this.btn_UngVien.UseVisualStyleBackColor = true;
            // 
            // btn_DoanhNghiep
            // 
            this.btn_DoanhNghiep.AutoSize = true;
            this.btn_DoanhNghiep.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoanhNghiep.Location = new System.Drawing.Point(500, 187);
            this.btn_DoanhNghiep.Name = "btn_DoanhNghiep";
            this.btn_DoanhNghiep.Size = new System.Drawing.Size(117, 21);
            this.btn_DoanhNghiep.TabIndex = 12;
            this.btn_DoanhNghiep.TabStop = true;
            this.btn_DoanhNghiep.Text = "Doanh nghiệp";
            this.btn_DoanhNghiep.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::FormAppJob.Properties.Resources.previous;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(21, 22);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 42);
            this.btnBack.TabIndex = 40;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormAppJob.Properties.Resources.register;
            this.pictureBox1.Location = new System.Drawing.Point(323, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btn_DoanhNghiep);
            this.Controls.Add(this.btn_UngVien);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.txt_Confirm);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_tenTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DangKy";
            this.Text = "Đăng ký";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tenTK;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_Confirm;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.RadioButton btn_UngVien;
        private System.Windows.Forms.RadioButton btn_DoanhNghiep;
        private System.Windows.Forms.Button btnBack;
    }
}
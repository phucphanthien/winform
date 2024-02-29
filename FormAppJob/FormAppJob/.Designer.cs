namespace FormAppJob
{
    partial class Login
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
            this.btn_ungVien = new System.Windows.Forms.RadioButton();
            this.btn_doanhNghiep = new System.Windows.Forms.RadioButton();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.link_forgetPass = new System.Windows.Forms.LinkLabel();
            this.link_dangKy = new System.Windows.Forms.LinkLabel();
            this.btn_Login = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ungVien
            // 
            this.btn_ungVien.AutoSize = true;
            this.btn_ungVien.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ungVien.ForeColor = System.Drawing.Color.Teal;
            this.btn_ungVien.Location = new System.Drawing.Point(358, 221);
            this.btn_ungVien.Name = "btn_ungVien";
            this.btn_ungVien.Size = new System.Drawing.Size(85, 21);
            this.btn_ungVien.TabIndex = 3;
            this.btn_ungVien.TabStop = true;
            this.btn_ungVien.Text = "Ứng viên";
            this.btn_ungVien.UseVisualStyleBackColor = true;
            // 
            // btn_doanhNghiep
            // 
            this.btn_doanhNghiep.AutoSize = true;
            this.btn_doanhNghiep.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doanhNghiep.ForeColor = System.Drawing.Color.Teal;
            this.btn_doanhNghiep.Location = new System.Drawing.Point(464, 221);
            this.btn_doanhNghiep.Name = "btn_doanhNghiep";
            this.btn_doanhNghiep.Size = new System.Drawing.Size(117, 21);
            this.btn_doanhNghiep.TabIndex = 4;
            this.btn_doanhNghiep.TabStop = true;
            this.btn_doanhNghiep.Text = "Doanh nghiệp";
            this.btn_doanhNghiep.UseVisualStyleBackColor = true;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(247, 248);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(343, 22);
            this.txt_name.TabIndex = 5;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(247, 291);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(343, 22);
            this.txt_pass.TabIndex = 6;
            // 
            // link_forgetPass
            // 
            this.link_forgetPass.AutoSize = true;
            this.link_forgetPass.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_forgetPass.Location = new System.Drawing.Point(300, 340);
            this.link_forgetPass.Name = "link_forgetPass";
            this.link_forgetPass.Size = new System.Drawing.Size(106, 17);
            this.link_forgetPass.TabIndex = 7;
            this.link_forgetPass.TabStop = true;
            this.link_forgetPass.Text = "Quên mật khẩu ?";
            this.link_forgetPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_forgetPass_LinkClicked);
            // 
            // link_dangKy
            // 
            this.link_dangKy.AutoSize = true;
            this.link_dangKy.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_dangKy.Location = new System.Drawing.Point(446, 340);
            this.link_dangKy.Name = "link_dangKy";
            this.link_dangKy.Size = new System.Drawing.Size(55, 17);
            this.link_dangKy.TabIndex = 8;
            this.link_dangKy.TabStop = true;
            this.link_dangKy.Text = "Đăng ký";
            this.link_dangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_dangKy_LinkClicked);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Lavender;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.Navy;
            this.btn_Login.Location = new System.Drawing.Point(358, 378);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(116, 38);
            this.btn_Login.TabIndex = 9;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FormAppJob.Properties.Resources.padlock;
            this.pictureBox3.Location = new System.Drawing.Point(193, 281);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FormAppJob.Properties.Resources.user_icon_150670;
            this.pictureBox2.Location = new System.Drawing.Point(193, 238);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormAppJob.Properties.Resources.web_browser;
            this.pictureBox1.Location = new System.Drawing.Point(303, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.link_dangKy);
            this.Controls.Add(this.link_forgetPass);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_doanhNghiep);
            this.Controls.Add(this.btn_ungVien);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton btn_ungVien;
        private System.Windows.Forms.RadioButton btn_doanhNghiep;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.LinkLabel link_forgetPass;
        private System.Windows.Forms.LinkLabel link_dangKy;
        private System.Windows.Forms.Button btn_Login;
    }
}


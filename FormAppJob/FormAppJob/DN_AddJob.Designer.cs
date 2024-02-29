namespace FormAppJob
{
    partial class DN_AddJob
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbviTri = new System.Windows.Forms.ComboBox();
            this.cblinhVuc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbmucLuong = new System.Windows.Forms.ComboBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtJob = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtJob)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID Job";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(31, 127);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(219, 22);
            this.txtID.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Vị trí công việc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Lĩnh vực";
            // 
            // cbviTri
            // 
            this.cbviTri.FormattingEnabled = true;
            this.cbviTri.Items.AddRange(new object[] {
            "Freelancer",
            "Parttime",
            "Fulltime"});
            this.cbviTri.Location = new System.Drawing.Point(31, 199);
            this.cbviTri.Name = "cbviTri";
            this.cbviTri.Size = new System.Drawing.Size(219, 24);
            this.cbviTri.TabIndex = 31;
            // 
            // cblinhVuc
            // 
            this.cblinhVuc.FormattingEnabled = true;
            this.cblinhVuc.Items.AddRange(new object[] {
            "IT",
            "Graphic Design",
            "Teacher",
            "Pharmacist",
            "Dentist",
            "Marketing ",
            "Accountant",
            "Translator",
            "Robotics Engineer",
            "Software Tester",
            "Other..."});
            this.cblinhVuc.Location = new System.Drawing.Point(31, 267);
            this.cblinhVuc.Name = "cblinhVuc";
            this.cblinhVuc.Size = new System.Drawing.Size(219, 24);
            this.cblinhVuc.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Mức lương";
            // 
            // cbmucLuong
            // 
            this.cbmucLuong.FormattingEnabled = true;
            this.cbmucLuong.Items.AddRange(new object[] {
            "<5M",
            "5-8M",
            "8-12M",
            "12-15M",
            "15-20M",
            "20-30M",
            "30M+"});
            this.cbmucLuong.Location = new System.Drawing.Point(31, 339);
            this.cbmucLuong.Name = "cbmucLuong";
            this.cbmucLuong.Size = new System.Drawing.Size(219, 24);
            this.cbmucLuong.TabIndex = 34;
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::FormAppJob.Properties.Resources.edit;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Location = new System.Drawing.Point(181, 389);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(45, 40);
            this.btnSua.TabIndex = 37;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::FormAppJob.Properties.Resources.add;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(718, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 50);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::FormAppJob.Properties.Resources.previous;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(21, 16);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 42);
            this.btnBack.TabIndex = 41;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::FormAppJob.Properties.Resources.trash;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Location = new System.Drawing.Point(113, 389);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(43, 40);
            this.btnXoa.TabIndex = 42;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::FormAppJob.Properties.Resources.plus1;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Location = new System.Drawing.Point(47, 389);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(42, 40);
            this.btnThem.TabIndex = 43;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtJob
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtJob.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtJob.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtJob.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtJob.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtJob.Location = new System.Drawing.Point(309, 106);
            this.dtJob.Name = "dtJob";
            this.dtJob.RowHeadersVisible = false;
            this.dtJob.RowHeadersWidth = 51;
            this.dtJob.RowTemplate.Height = 24;
            this.dtJob.Size = new System.Drawing.Size(435, 294);
            this.dtJob.TabIndex = 44;
            this.dtJob.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtJob.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtJob.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtJob.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtJob.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtJob.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtJob.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtJob.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtJob.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtJob.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtJob.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtJob.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtJob.ThemeStyle.HeaderStyle.Height = 4;
            this.dtJob.ThemeStyle.ReadOnly = false;
            this.dtJob.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtJob.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtJob.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtJob.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtJob.ThemeStyle.RowsStyle.Height = 24;
            this.dtJob.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtJob.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // DN_AddJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtJob);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.cbmucLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cblinhVuc);
            this.Controls.Add(this.cbviTri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "DN_AddJob";
            this.Text = "AddJob";
            this.Load += new System.EventHandler(this.AddJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtJob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbviTri;
        private System.Windows.Forms.ComboBox cblinhVuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbmucLuong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private Guna.UI2.WinForms.Guna2DataGridView dtJob;
    }
}
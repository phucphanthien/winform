namespace FormAppJob
{
    partial class DN_ListUV
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
            this.dtListUV = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtListUV)).BeginInit();
            this.SuspendLayout();
            // 
            // dtListUV
            // 
            this.dtListUV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtListUV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListUV.Location = new System.Drawing.Point(24, 94);
            this.dtListUV.Name = "dtListUV";
            this.dtListUV.RowHeadersWidth = 51;
            this.dtListUV.RowTemplate.Height = 24;
            this.dtListUV.Size = new System.Drawing.Size(523, 311);
            this.dtListUV.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::FormAppJob.Properties.Resources.previous;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(24, 24);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 42);
            this.btnBack.TabIndex = 41;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(583, 164);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(84, 17);
            this.lblID.TabIndex = 42;
            this.lblID.Text = "ID Ứng Viên";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(586, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 43;
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::FormAppJob.Properties.Resources.plus1;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Location = new System.Drawing.Point(586, 246);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(42, 40);
            this.btnThem.TabIndex = 47;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::FormAppJob.Properties.Resources.trash;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Location = new System.Drawing.Point(652, 246);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(43, 40);
            this.btnXoa.TabIndex = 48;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "DANH SÁCH CÁC ỨNG VIÊN";
            // 
            // DN_ListUV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtListUV);
            this.Name = "DN_ListUV";
            this.Text = "DN_ListUV";
            ((System.ComponentModel.ISupportInitialize)(this.dtListUV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtListUV;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
    }
}
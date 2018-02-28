namespace ThuctapNhom
{
    partial class FormThongTinPhongBan
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
            this.dvgphongban = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.lbltenphongban = new System.Windows.Forms.Label();
            this.txtsoluongnv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgphongban)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgphongban
            // 
            this.dvgphongban.AllowUserToAddRows = false;
            this.dvgphongban.AllowUserToDeleteRows = false;
            this.dvgphongban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgphongban.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvgphongban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgphongban.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dvgphongban.Location = new System.Drawing.Point(0, 248);
            this.dvgphongban.Margin = new System.Windows.Forms.Padding(4);
            this.dvgphongban.Name = "dvgphongban";
            this.dvgphongban.ReadOnly = true;
            this.dvgphongban.Size = new System.Drawing.Size(812, 245);
            this.dvgphongban.TabIndex = 0;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(669, 78);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(100, 28);
            this.btnthoat.TabIndex = 1;
            this.btnthoat.Text = "&Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // lbltenphongban
            // 
            this.lbltenphongban.AutoSize = true;
            this.lbltenphongban.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbltenphongban.Location = new System.Drawing.Point(7, 9);
            this.lbltenphongban.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltenphongban.Name = "lbltenphongban";
            this.lbltenphongban.Size = new System.Drawing.Size(173, 36);
            this.lbltenphongban.TabIndex = 4;
            this.lbltenphongban.Text = "Phòng Ban";
            // 
            // txtsoluongnv
            // 
            this.txtsoluongnv.Enabled = false;
            this.txtsoluongnv.Location = new System.Drawing.Point(181, 78);
            this.txtsoluongnv.Margin = new System.Windows.Forms.Padding(4);
            this.txtsoluongnv.Name = "txtsoluongnv";
            this.txtsoluongnv.Size = new System.Drawing.Size(107, 22);
            this.txtsoluongnv.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Số Lượng Nhân Sự";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdienthoai);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbltenphongban);
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.txtsoluongnv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 232);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hot line";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(181, 124);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(331, 22);
            this.txtEmail.TabIndex = 15;
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Enabled = false;
            this.txtdienthoai.Location = new System.Drawing.Point(181, 174);
            this.txtdienthoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(331, 22);
            this.txtdienthoai.TabIndex = 16;
            // 
            // FormThongTinPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(812, 493);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dvgphongban);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormThongTinPhongBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin phòng ban";
            this.Load += new System.EventHandler(this.FormPhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgphongban)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgphongban;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label lbltenphongban;
        private System.Windows.Forms.TextBox txtsoluongnv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
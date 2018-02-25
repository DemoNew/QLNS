namespace ThuctapNhom
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnnhanvien = new System.Windows.Forms.Button();
            this.btnphongban = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.lbltenandloai = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnnhanvien
            // 
            this.btnnhanvien.Image = global::ThuctapNhom.Properties.Resources._1493872786_User_group;
            this.btnnhanvien.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnnhanvien.Location = new System.Drawing.Point(116, 146);
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.Size = new System.Drawing.Size(100, 81);
            this.btnnhanvien.TabIndex = 0;
            this.btnnhanvien.Text = "&Nhân Viên";
            this.btnnhanvien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnnhanvien.UseVisualStyleBackColor = true;
            this.btnnhanvien.Click += new System.EventHandler(this.btnnhanvien_Click);
            // 
            // btnphongban
            // 
            this.btnphongban.Image = global::ThuctapNhom.Properties.Resources._1493872988_Department;
            this.btnphongban.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnphongban.Location = new System.Drawing.Point(333, 146);
            this.btnphongban.Name = "btnphongban";
            this.btnphongban.Size = new System.Drawing.Size(100, 81);
            this.btnphongban.TabIndex = 1;
            this.btnphongban.Text = "&Phòng Ban";
            this.btnphongban.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnphongban.UseVisualStyleBackColor = true;
            this.btnphongban.Click += new System.EventHandler(this.btnphongban_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Image = global::ThuctapNhom.Properties.Resources._1493873182_help_browser;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHelp.Location = new System.Drawing.Point(558, 156);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(100, 71);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "&Trợ Giúp";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1,
            this.toolStripButton2,
            this.lbltenandloai});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(818, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem,
            this.phòngBanToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(67, 22);
            this.toolStripDropDownButton1.Text = "Menu";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nhânViênToolStripMenuItem.Image")));
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.nhânViênToolStripMenuItem.Text = "Nhân Viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // phòngBanToolStripMenuItem
            // 
            this.phòngBanToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("phòngBanToolStripMenuItem.Image")));
            this.phòngBanToolStripMenuItem.Name = "phòngBanToolStripMenuItem";
            this.phòngBanToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.phòngBanToolStripMenuItem.Text = "Phòng Ban";
            this.phòngBanToolStripMenuItem.Click += new System.EventHandler(this.phòngBanToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::ThuctapNhom.Properties.Resources._1493873182_help_browser;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(72, 22);
            this.toolStripButton1.Text = "&Trợ Giúp";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(82, 22);
            this.toolStripButton2.Text = "&Đăng Xuất";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // lbltenandloai
            // 
            this.lbltenandloai.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbltenandloai.Name = "lbltenandloai";
            this.lbltenandloai.Size = new System.Drawing.Size(81, 22);
            this.lbltenandloai.Text = "Chào User Vip";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::ThuctapNhom.Properties.Resources.nhansu1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnphongban);
            this.Controls.Add(this.btnnhanvien);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnhanvien;
        private System.Windows.Forms.Button btnphongban;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel lbltenandloai;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngBanToolStripMenuItem;
    }
}
namespace quan_ly_thu_vien
{
    partial class frmMain
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
            this.Hieusach = new System.Windows.Forms.Label();
            this.chuongtrinhquanly = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThuthu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThemuon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNXB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoso = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHosomuon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHosotra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaocao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTongTienThuDuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhsachchuatra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhsachtheothemuon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimsach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimthuthu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hieusach
            // 
            this.Hieusach.AutoSize = true;
            this.Hieusach.BackColor = System.Drawing.Color.PapayaWhip;
            this.Hieusach.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Hieusach.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Hieusach.Location = new System.Drawing.Point(482, 187);
            this.Hieusach.Name = "Hieusach";
            this.Hieusach.Size = new System.Drawing.Size(195, 51);
            this.Hieusach.TabIndex = 5;
            this.Hieusach.Text = "Thư viện";
            // 
            // chuongtrinhquanly
            // 
            this.chuongtrinhquanly.AutoSize = true;
            this.chuongtrinhquanly.BackColor = System.Drawing.Color.PapayaWhip;
            this.chuongtrinhquanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold);
            this.chuongtrinhquanly.ForeColor = System.Drawing.Color.Black;
            this.chuongtrinhquanly.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chuongtrinhquanly.Location = new System.Drawing.Point(83, 138);
            this.chuongtrinhquanly.Name = "chuongtrinhquanly";
            this.chuongtrinhquanly.Size = new System.Drawing.Size(389, 44);
            this.chuongtrinhquanly.TabIndex = 4;
            this.chuongtrinhquanly.Text = "Chương trình quản lý";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhmuc,
            this.mnuHoso,
            this.mnuBaocao,
            this.mnuTimkiem,
            this.mnuThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDanhmuc
            // 
            this.mnuDanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThuthu,
            this.mnuSach,
            this.mnuThemuon,
            this.mnuNXB});
            this.mnuDanhmuc.Name = "mnuDanhmuc";
            this.mnuDanhmuc.Size = new System.Drawing.Size(90, 24);
            this.mnuDanhmuc.Text = "Danh mục";
            // 
            // mnuThuthu
            // 
            this.mnuThuthu.Name = "mnuThuthu";
            this.mnuThuthu.Size = new System.Drawing.Size(224, 26);
            this.mnuThuthu.Text = "Thủ Thư";
            this.mnuThuthu.Click += new System.EventHandler(this.mnuThuthu_Click);
            // 
            // mnuSach
            // 
            this.mnuSach.Name = "mnuSach";
            this.mnuSach.Size = new System.Drawing.Size(224, 26);
            this.mnuSach.Text = "Sách";
            this.mnuSach.Click += new System.EventHandler(this.mnuSach_Click);
            // 
            // mnuThemuon
            // 
            this.mnuThemuon.Name = "mnuThemuon";
            this.mnuThemuon.Size = new System.Drawing.Size(224, 26);
            this.mnuThemuon.Text = "Thẻ mượn";
            this.mnuThemuon.Click += new System.EventHandler(this.mnuThemuon_Click);
            // 
            // mnuNXB
            // 
            this.mnuNXB.Name = "mnuNXB";
            this.mnuNXB.Size = new System.Drawing.Size(224, 26);
            this.mnuNXB.Text = "NXB";
            this.mnuNXB.Click += new System.EventHandler(this.mnuNXB_Click);
            // 
            // mnuHoso
            // 
            this.mnuHoso.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHosomuon,
            this.mnuHosotra});
            this.mnuHoso.Name = "mnuHoso";
            this.mnuHoso.Size = new System.Drawing.Size(62, 24);
            this.mnuHoso.Text = "Hồ sơ";
            // 
            // mnuHosomuon
            // 
            this.mnuHosomuon.Name = "mnuHosomuon";
            this.mnuHosomuon.Size = new System.Drawing.Size(224, 26);
            this.mnuHosomuon.Text = "Hồ sơ mượn";
            this.mnuHosomuon.Click += new System.EventHandler(this.mnuHosomuon_Click);
            // 
            // mnuHosotra
            // 
            this.mnuHosotra.Name = "mnuHosotra";
            this.mnuHosotra.Size = new System.Drawing.Size(224, 26);
            this.mnuHosotra.Text = "Hồ sơ trả";
            this.mnuHosotra.Click += new System.EventHandler(this.mnuHosotra_Click);
            // 
            // mnuBaocao
            // 
            this.mnuBaocao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTongTienThuDuoc,
            this.mnuDanhsachchuatra,
            this.mnuDanhsachtheothemuon});
            this.mnuBaocao.Name = "mnuBaocao";
            this.mnuBaocao.Size = new System.Drawing.Size(77, 24);
            this.mnuBaocao.Text = "Báo cáo";
            // 
            // mnuTongTienThuDuoc
            // 
            this.mnuTongTienThuDuoc.Name = "mnuTongTienThuDuoc";
            this.mnuTongTienThuDuoc.Size = new System.Drawing.Size(396, 26);
            this.mnuTongTienThuDuoc.Text = "Tổng tiền thu được theo tháng, quý, năm";
            this.mnuTongTienThuDuoc.Click += new System.EventHandler(this.mnuTongTienThuDuoc_Click);
            // 
            // mnuDanhsachchuatra
            // 
            this.mnuDanhsachchuatra.Name = "mnuDanhsachchuatra";
            this.mnuDanhsachchuatra.Size = new System.Drawing.Size(396, 26);
            this.mnuDanhsachchuatra.Text = "Danh sách các sách đang được mượn chưa trả";
            this.mnuDanhsachchuatra.Click += new System.EventHandler(this.mnuDanhsachchuatra_Click);
            // 
            // mnuDanhsachtheothemuon
            // 
            this.mnuDanhsachtheothemuon.Name = "mnuDanhsachtheothemuon";
            this.mnuDanhsachtheothemuon.Size = new System.Drawing.Size(396, 26);
            this.mnuDanhsachtheothemuon.Text = "Danh sách hồ sơ mượn theo thẻ mượn";
            this.mnuDanhsachtheothemuon.Click += new System.EventHandler(this.mnuDanhsachtheothemuon_Click);
            // 
            // mnuTimkiem
            // 
            this.mnuTimkiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTimsach,
            this.mnuTimthuthu});
            this.mnuTimkiem.Name = "mnuTimkiem";
            this.mnuTimkiem.Size = new System.Drawing.Size(84, 24);
            this.mnuTimkiem.Text = "Tìm kiếm";
            // 
            // mnuTimsach
            // 
            this.mnuTimsach.Name = "mnuTimsach";
            this.mnuTimsach.Size = new System.Drawing.Size(224, 26);
            this.mnuTimsach.Text = "Sách";
            this.mnuTimsach.Click += new System.EventHandler(this.mnuTimsach_Click);
            // 
            // mnuTimthuthu
            // 
            this.mnuTimthuthu.Name = "mnuTimthuthu";
            this.mnuTimthuthu.Size = new System.Drawing.Size(224, 26);
            this.mnuTimthuthu.Text = "Thủ thư";
            this.mnuTimthuthu.Click += new System.EventHandler(this.mnuTimthuthu_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(61, 24);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Hieusach);
            this.Controls.Add(this.chuongtrinhquanly);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hieusach;
        private System.Windows.Forms.Label chuongtrinhquanly;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mnuThuthu;
        private System.Windows.Forms.ToolStripMenuItem mnuSach;
        private System.Windows.Forms.ToolStripMenuItem mnuThemuon;
        private System.Windows.Forms.ToolStripMenuItem mnuNXB;
        private System.Windows.Forms.ToolStripMenuItem mnuHoso;
        private System.Windows.Forms.ToolStripMenuItem mnuHosomuon;
        private System.Windows.Forms.ToolStripMenuItem mnuHosotra;
        private System.Windows.Forms.ToolStripMenuItem mnuBaocao;
        private System.Windows.Forms.ToolStripMenuItem mnuTongTienThuDuoc;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhsachchuatra;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhsachtheothemuon;
        private System.Windows.Forms.ToolStripMenuItem mnuTimkiem;
        private System.Windows.Forms.ToolStripMenuItem mnuTimsach;
        private System.Windows.Forms.ToolStripMenuItem mnuTimthuthu;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
    }
}
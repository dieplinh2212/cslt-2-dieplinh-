using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace quan_ly_thu_vien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Functions.Connect();
        }     
       
	 
        private void mnuNXB_Click(object sender, EventArgs e)
        {
            frmNXB f = new frmNXB();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();

        }

        private void mnuThuthu_Click(object sender, EventArgs e)
        {
            Thủ_Thư f = new Thủ_Thư();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();

        }

        private void mnuSach_Click(object sender, EventArgs e)
        {
            frmSach f = new frmSach();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuThemuon_Click(object sender, EventArgs e)
        {
            frmThemuon f = new frmThemuon();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuHosomuon_Click(object sender, EventArgs e)
        {
            frmHosomuon f = new frmHosomuon();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuHosotra_Click(object sender, EventArgs e)
        {
            frmHosotra f = new frmHosotra();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuTongTienThuDuoc_Click(object sender, EventArgs e)
        {
            frmTongtienthuduoc f = new frmTongtienthuduoc();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuDanhsachchuatra_Click(object sender, EventArgs e)
        {
            frmDanhsachchuatra f = new frmDanhsachchuatra();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuDanhsachtheothemuon_Click(object sender, EventArgs e)
        {
            frmDanhsachtheothemuon f = new frmDanhsachtheothemuon();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuTimsach_Click(object sender, EventArgs e)
        {
            frmTimsach f = new frmTimsach();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuTimthuthu_Click(object sender, EventArgs e)
        {
            frmtimkiemthuthu f = new frmtimkiemthuthu();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Functions.Disconnect();
            frmdangnhap f = new frmdangnhap();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}


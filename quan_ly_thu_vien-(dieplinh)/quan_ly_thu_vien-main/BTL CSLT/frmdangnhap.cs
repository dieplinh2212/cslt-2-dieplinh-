using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quan_ly_thu_vien
{
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            Functions.Connect();
            string sql;
            sql = "Select * from dangnhap where tendangnhap=N'" + txttendangnhap.Text +
                "'and matkhau=N'" + txtmatkhau.Text + "'";
            SqlCommand cmd=new SqlCommand(sql,Functions.Conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read()==true)
            {
                this.Hide();
                frmMain frm =new frmMain();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu. Mời bạn nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttendangnhap.Text = "";
                txtmatkhau.Text = "";
                txttendangnhap.Focus();

            }
           
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dlg = new DialogResult();
            dlg = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                this.Close();
            }

            Application.Exit();
            
        }

        private void frmdangnhap_Load(object sender, EventArgs e)
        {

        }
    }
    }


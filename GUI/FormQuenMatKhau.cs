using BLL;
using System.Net;
using System.Net.Mail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class FormQuenMatKhau : Form
    {
        //public FormQuenMatKhau()
        //{
        //    InitializeComponent();
        //    this.pictureBox_Thoat.Click += PictureBox_Thoat_Click;
        //    this.linkLabel_quaylaiLogin.LinkClicked += LinkLabel_quaylaiLogin_LinkClicked;
        //    this.btn_quenmatkhau.Click += btn_quenmatkhau_Click;
        //}

        //private void btn_quenmatkhau_Click(object sender, EventArgs e)
        //{
        //    string username = txt_username_quenmk.Text.Trim();
        //    string email = txt_email_quenmk.Text.Trim();

        //    UserBLL bll = new UserBLL();

        //    string password = bll.LayMatKhau(username, email);

        //    if (password == null)
        //    {
        //        MessageBox.Show("Tên đăng nhập hoặc email không khớp!",
        //                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    MessageBox.Show("Mật khẩu của bạn là: " + password,
        //                    "Lấy lại mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}


        //private void LinkLabel_quaylaiLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    this.Close();
        //}

        //private void PictureBox_Thoat_Click(object sender, EventArgs e)
        //{
        //    DialogResult result = MessageBox.Show(
        //        "Bạn có chắc muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question
        //    );

        //    if (result == DialogResult.Yes)
        //    {
        //        Application.Exit();
        //    }
        //}
    }
}

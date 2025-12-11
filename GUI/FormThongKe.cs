using BLL;
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
    public partial class FormThongKe : Form
    {
        //ThongKeBLL thongKe;
        //public FormThongKe()
        //{
        //    InitializeComponent();
        //    thongKe = new ThongKeBLL();
        //    this.Load += FormThongKe_Load;
        //}
        //private void loadBill()
        //{
        //    var query = thongKe.sortBillByTime().Select(t => new {
        //        t.BillCode,
        //        t.RoomID,
        //        t.PaymentDate,
        //        t.TotalAmount
        //    }).ToList();

        //    dgvBill.DataSource = query;
        //}

        //private void loadKhachHang()
        //{
        //    var query = thongKe.getKhachThueByTro().Select(t => new {
        //        t.TenantID,
        //        t.RoomId,
        //        t.FullName,
        //        t.BirthDate
        //    }).ToList();

        //    dgvKH.DataSource = query;
        //}
        //private void setThongKeLable()
        //{
        //    lbDayNha.Text = thongKe.CountDayNha().ToString();
        //    lbPhong.Text = thongKe.CountPhong().ToString();
        //    lbKhach.Text = thongKe.CountKhachHang().ToString();
        //    lbDoanhThu.Text = thongKe.SumDoanhThu().ToString("N0");
        //}
        //private void FormThongKe_Load(object sender, EventArgs e)
        //{
        //    setThongKeLable();
        //    loadBill();
        //    loadKhachHang();
        //}
    }
}

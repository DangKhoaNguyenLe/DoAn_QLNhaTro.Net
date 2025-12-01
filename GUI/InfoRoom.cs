using BLL;
using DTO;
using DTO.DTO;
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
    public partial class InfoRoom : UserControl
    {
        BillBLL bills;
        KhachThueBLL khachThueBLL;
        int idRoom;
        bool dsKhach;
        public InfoRoom(int idRoom,bool isdsKhach)
        {
            this.idRoom = idRoom;
            dsKhach = isdsKhach;
            InitializeComponent();
            dgvDsKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bills = new BillBLL();
            khachThueBLL = new KhachThueBLL();
            this.Load += InfoRoom_Load;
        }

        private void createTableBill()
        {
            dgvDsKH.Columns["BillID"].HeaderText = "Mã hoá đơn";
            dgvDsKH.Columns["BillCode"].HeaderText = "Mã code";
            dgvDsKH.Columns["RoomID"].HeaderText = "Phòng";
            dgvDsKH.Columns["BillMonth"].HeaderText = "Tháng";
            dgvDsKH.Columns["RoomPrice"].HeaderText = "Tiền phòng";
            dgvDsKH.Columns["ServicePrice"].HeaderText = "Tiền dịch vụ";
            dgvDsKH.Columns["Discount"].HeaderText = "Giảm trừ";
            dgvDsKH.Columns["PaidAmount"].HeaderText = "Đã trả";
            dgvDsKH.Columns["TotalAmount"].HeaderText = "Tổng tiền";
            dgvDsKH.Columns["RemainingAmount"].HeaderText = "Còn lại";
            dgvDsKH.Columns["PaymentDate"].HeaderText = "Ngày thanh toán";
            dgvDsKH.Columns["PaymentDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDsKH.Columns["CreatedBy"].HeaderText = "Người tạo";
            dgvDsKH.Columns["CreatedDate"].HeaderText = "Ngày tạo";
            dgvDsKH.Columns["Status"].HeaderText = "Trạng thái";
        }

        private void createTableKhachHang()
        {
            dgvDsKH.Columns["TenantID"].HeaderText = "Mã Khách hàng";
            dgvDsKH.Columns["FullName"].HeaderText = "Họ tên";
            dgvDsKH.Columns["BirthDate"].HeaderText = "Ngày sinh";
            dgvDsKH.Columns["Phone"].HeaderText = "Số điện thoại";
            dgvDsKH.Columns["Email"].HeaderText = "Gmail";
            dgvDsKH.Columns["Address"].HeaderText = "Địa chỉ";
            dgvDsKH.Columns["CCCD"].HeaderText = "CCCD";
        }
        private void LoadKhachHang()
        {
            dgvDsKH.Columns.Clear();
            List<KhachThueDTO> kh = khachThueBLL.getListById(idRoom);
            if (kh != null)
            {
                var query = kh.Select(b => new
                {
                    b.TenantID,
                    b.FullName,
                    b.BirthDate,
                    b.Phone,
                    b.Email,
                    b.Address,
                    b.CCCD
                }).ToList();
                dgvDsKH.DataSource = query;
                createTableKhachHang();
            }
        }

        private void LoadBill()
        {
            dgvDsKH.Columns.Clear();
            List<BillDTO> dt = bills.getBillByIdRoom(idRoom);
            if (dt != null)
            {
                var query = dt.Select(b => new
                {
                    b.BillID,
                    b.BillCode,
                    b.RoomID,
                    b.BillMonth,
                    b.RoomPrice,
                    b.ServicePrice,
                    b.Discount,
                    b.PaidAmount,
                    b.TotalAmount,
                    b.RemainingAmount,
                    b.Status,
                    b.PaymentDate,
                    b.CreatedBy,
                    b.CreatedDate,
                }).ToList();
                dgvDsKH.DataSource = query;
                createTableBill();
            }
        }
        private void InfoRoom_Load(object sender, EventArgs e)
        {
            
            if (!dsKhach) {
                LoadBill();
            }
            else
            {
                LoadKhachHang();
            }
        }
    }
}

using BLL;
using DTO;
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
        int idRoom;
        public InfoRoom(int idRoom)
        {
            InitializeComponent();
            bills = new BillBLL();
            this.Load += InfoRoom_Load;
            this.idRoom = idRoom;
        }
        private void LoadBillToGrid()
        {
            List<BillDTO> dt = bills.getBillByIdRoom(idRoom);
            if (dt != null)
            {
                dgvDsKH.DataSource = dt;
                dgvDsKH.Columns["BillID"].HeaderText = "Mã hoá đơn";
                dgvDsKH.Columns["BillCode"].HeaderText = "Mã code";
                dgvDsKH.Columns["ContractID"].HeaderText = "Hợp đồng";
                dgvDsKH.Columns["HostelID"].HeaderText = "Nhà trọ";
                dgvDsKH.Columns["RoomID"].HeaderText = "Phòng";
                dgvDsKH.Columns["TenantID"].HeaderText = "Người thuê";
                dgvDsKH.Columns["BillMonth"].HeaderText = "Tháng";
                dgvDsKH.Columns["RoomPrice"].HeaderText = "Tiền phòng";
                dgvDsKH.Columns["ServicePrice"].HeaderText = "Tiền dịch vụ";
                dgvDsKH.Columns["Discount"].HeaderText = "Giảm trừ";
                dgvDsKH.Columns["PaidAmount"].HeaderText = "Đã trả";
                dgvDsKH.Columns["TotalAmount"].HeaderText = "Tổng tiền";
                dgvDsKH.Columns["RemainingAmount"].HeaderText = "Còn lại";
                dgvDsKH.Columns["Status"].HeaderText = "Trạng thái";
                dgvDsKH.Columns["PaymentDate"].HeaderText = "Ngày thanh toán";
                dgvDsKH.Columns["PaymentDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvDsKH.Columns["CreatedBy"].HeaderText = "Người tạo";
                dgvDsKH.Columns["CreatedDate"].HeaderText = "Ngày tạo";
            }
        }
        private void InfoRoom_Load(object sender, EventArgs e)
        {
            LoadBillToGrid();
        }
    }
}

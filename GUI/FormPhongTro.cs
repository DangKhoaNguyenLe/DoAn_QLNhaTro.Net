using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GUI
{
    public partial class FormPhongTro : Form
    {
        DayNhaBLL DayNhaBLL;
        PhongTroBLL PhongTroBLL;
        InfoRoom uc;
        public FormPhongTro()
        {
            InitializeComponent();
            DayNhaBLL = new DayNhaBLL();
            PhongTroBLL = new PhongTroBLL();
            this.Load += PhongTro_Load;
            this.cmbDayNha.SelectionChangeCommitted += CmbDayNha_SelectionChangeCommitted;
            this.btnAddTro.Click += BtnAddTro_Click;
            this.btnSave.Click += BtnSave_Click;
            this.btnSua.Click += BtnSua_Click;
            this.btnXoa.Click += BtnXoa_Click;
            this.btnInfo.Click += BtnInfo_Click;
            this.btndsKhach.Click += BtndsKhach_Click;
            this.btndsHoaDon.Click += BtndsHoaDon_Click;

        }

        private void LoadInfoRoom(int id) { 
            uc = new InfoRoom(id);
            uc.Dock = DockStyle.Fill;
            pannelMain.Controls.Add(uc);
        }

        private void setEnableTag(bool i, bool ds)
        {
            tnplayoutInfoRoom.Visible = i;
           

        }

        private void BtndsHoaDon_Click(object sender, EventArgs e)
        {
         
        }

        private void BtndsKhach_Click(object sender, EventArgs e)
        {
            setEnableTag(false, true);
            LoadInfoRoom(int.Parse(txtIdRoom.Text));

        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            tnplayoutInfoRoom.Visible = true;
            uc.Visible = false;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (txtIdRoom.Text == string.Empty) {
                MessageBox.Show("Không thể xóa do bạn chưa chọn phòng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có muốn xóa?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                PhongTroBLL.delete(int.Parse(txtIdRoom.Text));
                loadPhong(int.Parse(cmbDsDayNha.SelectedValue.ToString()));
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            setEnableTxtCmb(true);
            btnSave.Visible = true;
            setButtonCUD(false, true, false);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string textmessage = string.Empty;
            try {
                // TH Them
                if (!btnSua.Enabled)
                {
                    textmessage = "Thêm thành công";
                    PhongTroDTO phong = new PhongTroDTO(
                        1
                        , int.Parse(cmbDsDayNha.SelectedValue.ToString())
                        , txtTenPhong.Text
                        , txtTang.Text
                        , decimal.Parse(txtDienTich.Text)
                        , int.Parse(txtMaxNguoi.Text)
                        , int.Parse(txtDaThue.Text)
                        , decimal.Parse(txtGiaPhong.Text)
                        , decimal.Parse(txtTienCoc.Text)
                        , txtTinhTrang.Text);
                    PhongTroBLL.add(phong);
                    loadPhong(phong.HostelID);
                }
                if (!btnAddTro.Enabled)
                {
                    textmessage = "Update thành công";
                    PhongTroDTO phong = new PhongTroDTO(
                        int.Parse(txtIdRoom.Text)
                        , int.Parse(cmbDsDayNha.SelectedValue.ToString())
                        , txtTenPhong.Text
                        , txtTang.Text
                        , decimal.Parse(txtDienTich.Text)
                        , int.Parse(txtMaxNguoi.Text)
                        , int.Parse(txtDaThue.Text)
                        , decimal.Parse(txtGiaPhong.Text)
                        , decimal.Parse(txtTienCoc.Text)
                        , txtTinhTrang.Text);
                    PhongTroBLL.update(phong);
                    loadPhong(phong.HostelID);
                }

                MessageBox.Show(textmessage, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            setButtonCUD(true, true, true);
        }

        private void setButtonCUD(bool c, bool u, bool d)
        {
            btnAddTro.Enabled = c;
            btnXoa.Enabled = d;
            btnSua.Enabled = u;
        }

        private void BtnAddTro_Click(object sender, EventArgs e)
        {
            resetInfoPhong();
            tnplayoutInfoRoom.Visible = true;
            setEnableTxtCmb(true);
            btnSave.Visible = true;
            setButtonCUD(true, false, false);
        }

        private void CmbDayNha_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = int.Parse(cmbDayNha.SelectedValue.ToString()); 
            loadPhong(id);
        }

        private void loadPhong(int id)
        {
           List<PhongTroDTO> phongTros = PhongTroBLL.getListByHostel(id);
            flowLayoutPanel1.Controls.Clear();
            foreach (var i in phongTros)
            {
                Button btn = new Button();
                btn.BackColor = SystemColors.Control;
                btn.Text = "Phòng " + i.RoomID;
                btn.Name = i.RoomID.ToString();
                btn.Size = new Size(100, 120);
                btn.Click += PhongButton_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void showInfoPhong(int id)
        {
            PhongTroDTO phongTro = PhongTroBLL.FindByID(id);
            DayNhaDTO daynha = DayNhaBLL.getList().FirstOrDefault(t => t.HostelID == phongTro.HostelID);
            txtIdRoom.Text = phongTro.RoomID.ToString();
            txtTenPhong.Text = phongTro.RoomName;
            cmbDsDayNha.Text = daynha.HostelName;
            txtDaThue.Text = phongTro.soNguoiDaThue.ToString();
            txtDienTich.Text = phongTro.Area.ToString();
            txtMaxNguoi.Text = phongTro.Capacity.ToString();
            txtTienCoc.Text = phongTro.Deposit.ToString();
            txtTinhTrang.Text = phongTro.Status;
            txtTang.Text = phongTro.Floor;
            txtGiaPhong.Text = phongTro.Price.ToString();

        }

        private void resetInfoPhong()
        {
            txtTenPhong.Clear();
            cmbDsDayNha.Text = "Chọn dãy nhà";
            txtIdRoom.Text = (PhongTroBLL.getList().Max(t => t.RoomID) + 1).ToString();
            txtDaThue.Clear();
            txtDienTich.Clear();
            txtMaxNguoi.Clear();
            txtTienCoc.Clear();
            txtTinhTrang.Clear();
            txtTang.Clear();
            txtGiaPhong.Clear();

        }

        private void PhongButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int roomId = int.Parse(btn.Name);
            ClearButtonSelection();
            btn.BackColor = Color.LightBlue;
            tnplayoutInfoRoom.Visible = true;
            showInfoPhong(roomId);
            btndsKhach.Enabled = true;


        }

        private void ClearButtonSelection()
        {
            foreach (Button b in flowLayoutPanel1.Controls.OfType<Button>())
            {
                b.BackColor = SystemColors.Control;
            }
        }

        private void setEnableTxtCmb(bool enable)
        {
            txtTenPhong.Enabled = enable;
            cmbDsDayNha.Enabled = enable;
            txtDaThue.Enabled = enable;
            txtDienTich.Enabled = enable;
            txtMaxNguoi.Enabled = enable;
            txtTienCoc.Enabled = enable;
            txtTinhTrang.Enabled = enable;
            txtTang.Enabled = enable;
            txtGiaPhong.Enabled = enable;
        }
        private void PhongTro_Load(object sender, EventArgs e)
        {
            cmbDayNha.DataSource = cmbDsDayNha.DataSource = DayNhaBLL.getListByAdmin();
            cmbDayNha.DisplayMember = cmbDsDayNha.DisplayMember = "HostelName";
            cmbDayNha.ValueMember = cmbDsDayNha.ValueMember = "HostelID"; 
            cmbDayNha.Text = "Chọn dãy nhà";
            cmbDayNha.SelectedIndex = 0;
            tnplayoutInfoRoom.Visible = false;
            setEnableTxtCmb(false); 
            btnSave.Visible = false;
            setEnableTag(true, false);
            btndsKhach.Enabled = false;

        }
    }
}

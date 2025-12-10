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
        //DayNhaBLL DayNhaBLL;
        //PhongTroBLL PhongTroBLL;
        //InfoRoom uc;
        //public FormPhongTro()
        //{
        //    InitializeComponent();
        //    DayNhaBLL = new DayNhaBLL();
        //    PhongTroBLL = new PhongTroBLL();
        //    this.Load += PhongTro_Load;
        //    this.cmbDayNha.SelectionChangeCommitted += CmbDayNha_SelectionChangeCommitted;
        //    this.btnAddTro.Click += BtnAddTro_Click;
        //    this.btnSave.Click += BtnSave_Click;
        //    this.btnSua.Click += BtnSua_Click;
        //    this.btnXoa.Click += BtnXoa_Click;
        //    this.btnInfo.Click += BtnInfo_Click;
        //    this.btndsKhach.Click += BtndsKhach_Click;
        //    this.btndsHoaDon.Click += BtndsHoaDon_Click;
        //    this.btnHuy.Click += BtnHuy_Click;

        //}

        //private void BtnHuy_Click(object sender, EventArgs e)
        //{
        //    setSaveClose(false);
        //    if (!btnSua.Enabled)
        //    {
        //        resetInfoPhong();
        //    }
        //    setButtonCUD(true, true, true);
        //    setEnableTxtCmb(false);
        //}

        //private void LoadInfoRoom(int id, bool c) { 
        //    uc = new InfoRoom(id, c);
        //    uc.Dock = DockStyle.Fill;
        //    pannelMain.Controls.Add(uc);
        //}


        //private void BtndsHoaDon_Click(object sender, EventArgs e)
        //{
        //   if(uc != null) pannelMain.Controls.Remove(uc);
        //    LoadInfoRoom(int.Parse(txtIdRoom.Text), false);
        //    tnplayoutInfoRoom.Visible = false;
        //    uc.Visible = true;
        //}

        //private void BtndsKhach_Click(object sender, EventArgs e)
        //{
        //    if (uc != null) pannelMain.Controls.Remove(uc);
        //    LoadInfoRoom(int.Parse(txtIdRoom.Text), true);
        //    tnplayoutInfoRoom.Visible = false;
        //    uc.Visible = true;
        //}

        //private void BtnInfo_Click(object sender, EventArgs e)
        //{
        //    tnplayoutInfoRoom.Visible = true;
           
        //    if(uc == null)
        //    {
        //        MessageBox.Show("Bạn chưa chọn phòng", "Lỗi");
        //    }
        //    else
        //    {
        //        uc.Visible = false;
        //    }
        //}

        //private void BtnXoa_Click(object sender, EventArgs e)
        //{
        //    if (txtTenPhong.Text == string.Empty) {
        //        MessageBox.Show("Không thể xóa do bạn chưa chọn phòng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    DialogResult result = MessageBox.Show("Bạn có muốn xóa?", "Xác nhận xóa",
        //        MessageBoxButtons.YesNo, MessageBoxIcon.Question
        //    );

        //    if (result == DialogResult.Yes)
        //    {
        //        PhongTroBLL.delete(int.Parse(txtIdRoom.Text));
        //        loadPhong(int.Parse(cmbDsDayNha.SelectedValue.ToString()));
        //    }
        //}

        //private void BtnSua_Click(object sender, EventArgs e)
        //{
        //    if(txtIdRoom.Text == string.Empty)
        //    {
        //        MessageBox.Show("Bạn chưa chọn phòng.", "Vui lòng chọn phòng"
        //            , MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    setSaveClose(true);
        //    setEnableTxtCmb(true);
        //    btnSave.Visible = true;
        //    setButtonCUD(false, true, false);
        //}

        //private void BtnSave_Click(object sender, EventArgs e)
        //{
        //    string textmessage = string.Empty;
        //    try {
        //        // TH Them
        //        if (!btnSua.Enabled)
        //        {
        //            textmessage = "Thêm thành công";
        //            PhongTroDTO phong = new PhongTroDTO(
        //                1
        //                , int.Parse(cmbDsDayNha.SelectedValue.ToString())
        //                , txtIdRoom.Text
        //                , txtTang.Text
        //                , decimal.Parse(txtDienTich.Text)
        //                , int.Parse(txtMaxNguoi.Text)
        //                , int.Parse(txtDaThue.Text)
        //                , decimal.Parse(txtGiaPhong.Text)
        //                , decimal.Parse(txtTienCoc.Text)
        //                , txtTinhTrang.Text);
        //            PhongTroBLL.add(phong);
        //            loadPhong(phong.HostelID);
        //        }
        //        if (!btnAddTro.Enabled)
        //        {
        //            textmessage = "Update thành công";
        //            PhongTroDTO phong = new PhongTroDTO(
        //                int.Parse(txtIdRoom.Text)
        //                , int.Parse(cmbDsDayNha.SelectedValue.ToString())
        //                , txtTenPhong.Text
        //                , txtTang.Text
        //                , decimal.Parse(txtDienTich.Text)
        //                , int.Parse(txtMaxNguoi.Text)
        //                , int.Parse(txtDaThue.Text)
        //                , decimal.Parse(txtGiaPhong.Text)
        //                , decimal.Parse(txtTienCoc.Text)
        //                , txtTinhTrang.Text);
        //            PhongTroBLL.update(phong);
        //            loadPhong(phong.HostelID);
        //        }
        //        MessageBox.Show(textmessage, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        setSaveClose(false);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    setEnableTxtCmb(false);
        //    setButtonCUD(true, true, true);
        //}

        //private void setButtonCUD(bool c, bool u, bool d)
        //{
        //    btnAddTro.Enabled = c;
        //    btnXoa.Enabled = d;
        //    btnSua.Enabled = u;
        //}

        //private void setSaveClose(bool i)
        //{
        //    btnSave.Visible = i;
        //    btnHuy.Visible  = i;

        //}

        //private void BtnAddTro_Click(object sender, EventArgs e)
        //{
        //    setSaveClose(true);
        //    resetInfoPhong();
        //    tnplayoutInfoRoom.Visible = true;
        //    setEnableTxtCmb(true);
        //    btnSave.Visible = true;
        //    txtIdRoom.Enabled = false;
        //    txtIdRoom.Text = (PhongTroBLL.getList().Last().RoomID + 1).ToString() ;
        //    setButtonCUD(true, false, false);
        //    pannelMain.Visible = true;
        //    resetButtonPhong();
        //}

        //private void CmbDayNha_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    int id = int.Parse(cmbDayNha.SelectedValue.ToString()); 
        //    loadPhong(id);
        //}

        //private void loadPhong(int id)
        //{
        //   List<PhongTroDTO> phongTros = PhongTroBLL.getListByHostel(id);
        //    flpPhong.Controls.Clear();
        //    foreach (var i in phongTros)
        //    {
        //        Button btn = new Button();
        //        btn.BackColor = SystemColors.Control;
        //        btn.Text = "Phòng " + i.RoomID;
        //        btn.Name = i.RoomID.ToString();
        //        btn.Size = new Size(100, 120);
        //        btn.Click += PhongButton_Click;
        //        flpPhong.Controls.Add(btn);
        //    }
        //}

        //private void showInfoPhong(int id)
        //{
        //    PhongTroDTO phongTro = PhongTroBLL.FindByID(id);
        //    DayNhaDTO daynha = DayNhaBLL.getList().FirstOrDefault(t => t.HostelID == phongTro.HostelID);
        //    txtIdRoom.Text = phongTro.RoomID.ToString();
        //    txtTenPhong.Text = phongTro.RoomName;
        //    cmbDsDayNha.SelectedItem = daynha;
        //    txtDaThue.Text = phongTro.soNguoiDaThue.ToString();
        //    txtDienTich.Text = phongTro.Area.ToString();
        //    txtMaxNguoi.Text = phongTro.Capacity.ToString();
        //    txtTienCoc.Text = phongTro.Deposit.ToString();
        //    txtTinhTrang.Text = phongTro.Status;
        //    txtTang.Text = phongTro.Floor;
        //    txtGiaPhong.Text = phongTro.Price.ToString();

        //}

        //private void resetInfoPhong()
        //{
        //    txtIdRoom.Clear();
        //    cmbDsDayNha.Text = "Chọn dãy nhà";
        //    txtTenPhong.Clear();
        //    txtDaThue.Clear();
        //    txtDienTich.Clear();
        //    txtMaxNguoi.Clear();
        //    txtTienCoc.Clear();
        //    txtTinhTrang.Clear();
        //    txtTang.Clear();
        //    txtGiaPhong.Clear();

        //}

        //private void resetButtonPhong()
        //{
        //    foreach (Control c in flpPhong.Controls)
        //    {
        //        if (c is Button btn)
        //        {
        //            if (btn.BackColor == Color.LightBlue)
        //            {
        //                btn.BackColor = SystemColors.Control;
        //            }

        //        }
        //    }
        //}


        //private void EnableInfoPhong(bool i)
        //{
        //    btndsKhach.Enabled = i;
        //    btnInfo.Enabled = i;
        //    btndsHoaDon.Enabled = i;
        //}

        //private void PhongButton_Click(object sender, EventArgs e)
        //{
        //    if(!btnSua.Enabled || !btnAddTro.Enabled) return;
        //    Button btn = sender as Button;
        //    int roomId = int.Parse(btn.Name);
        //    ClearButtonSelection();
        //    btn.BackColor = Color.LightBlue;
        //    tnplayoutInfoRoom.Visible = true;
        //    showInfoPhong(roomId);
        //    EnableInfoPhong(true);
        //    pannelMain.Visible = true;
        //}

        //private void ClearButtonSelection()
        //{
        //    foreach (Button b in flpPhong.Controls.OfType<Button>())
        //    {
        //        b.BackColor = SystemColors.Control;
        //    }
        //}

        //private void setEnableTxtCmb(bool enable)
        //{
        //    txtIdRoom.Enabled = enable;
        //    txtTenPhong.Enabled = enable;   
        //    cmbDsDayNha.Enabled = enable;
        //    txtDaThue.Enabled = enable;
        //    txtDienTich.Enabled = enable;
        //    txtMaxNguoi.Enabled = enable;
        //    txtTienCoc.Enabled = enable;
        //    txtTinhTrang.Enabled = enable;
        //    txtTang.Enabled = enable;
        //    txtGiaPhong.Enabled = enable;
        //}
        //private void PhongTro_Load(object sender, EventArgs e)
        //{
        //    cmbDayNha.DataSource = cmbDsDayNha.DataSource = DayNhaBLL.getListByAdmin();
        //    cmbDayNha.DisplayMember = cmbDsDayNha.DisplayMember = "HostelName";
        //    cmbDayNha.ValueMember = cmbDsDayNha.ValueMember = "HostelID"; 
        //    cmbDayNha.Text = "Chọn dãy nhà";
        //    cmbDayNha.SelectedIndex = 0;
        //    setEnableTxtCmb(false); 
        //    btnSave.Visible = false;
        //    tnplayoutInfoRoom.Visible = false;
        //    EnableInfoPhong(false);
        //    pannelMain.Visible = false;
        //    setSaveClose(false);

        //}
    }
}

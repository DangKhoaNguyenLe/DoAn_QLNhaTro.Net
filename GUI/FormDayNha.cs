using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
 
    public partial class FormDayNha : Form
    {
        UserBLL userBLL;
        DayNhaBLL daynha;
        GiaDienNuocBLL giaDienNuocBLL;
        string nameLable = string.Empty;
        string nameBtn = string.Empty;
        int idNha = 0;
        public FormDayNha(string nameLable, string nameBtn, int idNha)
        {
            InitializeComponent();
            userBLL = new UserBLL();
            daynha = new DayNhaBLL();
            this.nameLable = nameLable;
            this.nameBtn = nameBtn;
            this.idNha = idNha;
            giaDienNuocBLL = new GiaDienNuocBLL();
            this.Load += FormThemDayNha_Load;
            this.btnAddDayNha.Click += BtnAddDayNha_Click;
            this.btnSua.Click += BtnSua_Click;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string decr = getDataCheckedListBox();
                DayNhaDTO dn = new DayNhaDTO(
                    idNha,
                    txtNameDayNha.Text,
                    txtDiaChiDayNha.Text,
                    decr,
                    userBLL.getUserAdminLogin().UserID
                    );
                daynha.update(dn);

                GiaDienNuocDTO dgn = new GiaDienNuocDTO(
                    idNha,
                    decimal.Parse(txtGiaDien.Text),
                    decimal.Parse(txtGiaNuoc.Text),
                    DateTime.Now,
                    true
                    );
                giaDienNuocBLL.update(dgn);

                resetForm();
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetForm()
        {
            txtNameDayNha.Clear();
            txtDiaChiDayNha.Clear();
            txtGiaDien.Clear();
            txtGiaNuoc.Clear();

            for(int i = 0; i < clbTienIch.Items.Count; i++)
            {
                clbTienIch.SetItemChecked(i, false);
            }
        }
        private bool checkTxtNameAndAddress()
        {
            return txtNameDayNha.Text == string.Empty || txtDiaChiDayNha.Text == string.Empty;
        }
        private void BtnAddDayNha_Click(object sender, EventArgs e)
        {
            if (checkTxtNameAndAddress())
            {
                MessageBox.Show("Tên và địa chỉ không được trống", "Lỗi để trống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string decr = getDataCheckedListBox();
                DayNhaDTO dn = new DayNhaDTO(
                    txtNameDayNha.Text,
                    txtDiaChiDayNha.Text,
                    decr,
                    userBLL.getUserAdminLogin().UserID
                    );
                daynha.add(dn);

                GiaDienNuocDTO dgn = new GiaDienNuocDTO(
                    idNha,
                    decimal.Parse(txtGiaDien.Text),
                    decimal.Parse(txtGiaNuoc.Text),
                    DateTime.Now,
                    true
                    );
                giaDienNuocBLL.add(dgn);
    
                resetForm();
                MessageBox.Show("Thêm thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadDataFormEdit()
        {
            DayNhaDTO n = daynha.FindByID(idNha);
            GiaDienNuocDTO d = giaDienNuocBLL.FindByID(idNha);
            txtNameDayNha.Text = n.HostelName;
            txtDiaChiDayNha.Text = n.Address;
            if (n != null)
            {
                txtGiaDien.Text = d.GiaDien.ToString();
                txtGiaNuoc.Text = d.GiaDien.ToString();
            }

            string decr = n.Description;
            string[] nameSelect = decr.Split(',');
            for (int i = 0; i < clbTienIch.Items.Count; i++)
            {
                string item = clbTienIch.Items[i].ToString();
                foreach (var select in nameSelect)
                {
                    if (item == select)
                    {
                        clbTienIch.SetItemChecked(i, true);
                        break; 
                    }
                }

            }
        }
        private void modifyFormEdit()
        {
            btnAddDayNha.Visible = false;
            lbname.Text = nameLable;
            lbname.ForeColor = Color.Black;
            panel1.BackColor = Color.Gold;
            btnSua.Visible = true;
            loadDataFormEdit();
        }
        private void FormThemDayNha_Load(object sender, EventArgs e)
        {
            loadDatFrom();
            btnSua.Visible = false;
            if (nameLable != string.Empty || nameBtn != string.Empty)
            {
                modifyFormEdit();
            }
        }

        private void loadDatFrom()
        {
            UserDTO user = userBLL.getUserAdminLogin();
            txtNameUser.Text = user.FullName;
            txtPhoneUser.Text = user.Phone;
        }

        private string getDataCheckedListBox()
        {
            string decr = string.Empty;
            foreach(var i in clbTienIch.CheckedItems)
            {
                if (decr != string.Empty) decr += ",";
                decr += i.ToString();
            }

            return decr == string.Empty ? "Không có" : decr ;
        }

    }
}

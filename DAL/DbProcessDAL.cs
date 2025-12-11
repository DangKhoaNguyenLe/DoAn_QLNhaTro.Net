using DAL.DataNhaTroTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DbProcessDAL
    {
        protected NhaTroTableAdapter nhaTro_adapter;
        protected CocGiuChoTableAdapter cocGiuCho_adapter;
        protected ChiTietHoaDonTableAdapter chiTietHoaDon_adapter;
        protected ChotDienNuocTableAdapter chotDienNuoc_adapter;
        protected DanhMucTaiSanTableAdapter danhMucTaiSan_adapter;
        protected DichVuTableAdapter dichVu_adapter;
        protected HoaDonTableAdapter hoaDon_adapter;
        protected HopDongTableAdapter hopDong_adapter;
        protected HopDong_DichVuTableAdapter hopDong_DichVu_adapter;
        protected KhachHangTableAdapter khachHang_adapter;
        protected KhachOTableAdapter khachO_adapter;
        protected LoaiPhongTableAdapter loaiPhong_adapter;
        protected NguoiDungTableAdapter nguoiDung_adapter;
        protected PhieuChiTableAdapter phieuChi_adapter;
        protected PhongTableAdapter phong_adapter;
        protected SuCoTableAdapter suCo_adapter;
        protected TaiSan_PhongTableAdapter taiSan_phong_adapter;
        protected ThuVienAnhTableAdapter thuVienAnh_adapter;


        public DbProcessDAL()
        {
            nhaTro_adapter = new NhaTroTableAdapter();
            cocGiuCho_adapter = new CocGiuChoTableAdapter();
            chiTietHoaDon_adapter = new ChiTietHoaDonTableAdapter();
            chotDienNuoc_adapter = new ChotDienNuocTableAdapter();
            danhMucTaiSan_adapter = new DanhMucTaiSanTableAdapter();
            dichVu_adapter = new DichVuTableAdapter();
            hoaDon_adapter = new HoaDonTableAdapter();
            hopDong_adapter = new HopDongTableAdapter();
            hopDong_DichVu_adapter = new HopDong_DichVuTableAdapter();
            khachHang_adapter = new KhachHangTableAdapter();
            khachO_adapter = new KhachOTableAdapter();
            loaiPhong_adapter = new LoaiPhongTableAdapter();
            nguoiDung_adapter = new NguoiDungTableAdapter();
            phieuChi_adapter = new PhieuChiTableAdapter();
            phong_adapter = new PhongTableAdapter();
            suCo_adapter = new SuCoTableAdapter();
            taiSan_phong_adapter = new TaiSan_PhongTableAdapter();
            thuVienAnh_adapter = new ThuVienAnhTableAdapter();
        }
    }
}

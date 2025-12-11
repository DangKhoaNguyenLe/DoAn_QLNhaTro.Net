using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class NguoiDungDAL
    {
        private string connStr = Properties.Settings.Default.QL_nhaTroConnectionString1;

        public NguoiDungDTO KiemTraDangNhap(string user, string pass)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM NguoiDung WHERE TenDangNhap = @User AND MatKhau = @Pass";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@User", user);
                    cmd.Parameters.AddWithValue("@Pass", pass);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            NguoiDungDTO dto = new NguoiDungDTO();
                            dto.MaNguoiDung = int.Parse(reader["MaNguoiDung"].ToString());
                            dto.TenDangNhap = reader["TenDangNhap"].ToString();
                            dto.MatKhau = reader["MatKhau"].ToString();
                            dto.HoTen = reader["HoTen"].ToString();

                            dto.VaiTro = reader["VaiTro"] != DBNull.Value ? reader["VaiTro"].ToString() : "NHANVIEN";
           

                            return dto;
                        }
                    }
                }
                catch { }
            }
            return null; 
        }

        public List<NguoiDungDTO> LayDSNguoiDung()
        {
            List<NguoiDungDTO> list = new List<NguoiDungDTO>();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM NguoiDung";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NguoiDungDTO nd = new NguoiDungDTO();
                            nd.MaNguoiDung = int.Parse(reader["MaNguoiDung"].ToString());
                            nd.TenDangNhap = reader["TenDangNhap"].ToString();
                            nd.MatKhau = reader["MatKhau"].ToString(); // Nên ẩn đi ở tầng GUI
                            nd.HoTen = reader["HoTen"].ToString();
                            nd.VaiTro = reader["VaiTro"].ToString();
                            nd.SDT = reader["SDT"] != DBNull.Value ? reader["SDT"].ToString() : "";
                            list.Add(nd);
                        }
                    }
                }
                catch { }
            }
            return list;
        }
        public bool ThemNguoiDung(NguoiDungDTO nd)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string check = "SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap = @Ten";
                    SqlCommand cmdCheck = new SqlCommand(check, conn);
                    cmdCheck.Parameters.AddWithValue("@Ten", nd.TenDangNhap);
                    if ((int)cmdCheck.ExecuteScalar() > 0) return false;

                    string query = @"INSERT INTO NguoiDung (TenDangNhap, MatKhau, HoTen, VaiTro, SDT, TrangThai) 
                                     VALUES (@Ten, @MatKhau, @HoTen, @VaiTro, @SDT, 1)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Ten", nd.TenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhau", nd.MatKhau);
                    cmd.Parameters.AddWithValue("@HoTen", nd.HoTen);
                    cmd.Parameters.AddWithValue("@VaiTro", nd.VaiTro);
                    cmd.Parameters.AddWithValue("@SDT", nd.SDT);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch { return false; }
            }
        }

        public bool SuaNguoiDung(NguoiDungDTO nd)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE NguoiDung 
                                     SET HoTen = @HoTen, VaiTro = @VaiTro, SDT = @SDT, MatKhau = @MatKhau 
                                     WHERE MaNguoiDung = @Ma";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Ma", nd.MaNguoiDung);
                    cmd.Parameters.AddWithValue("@HoTen", nd.HoTen);
                    cmd.Parameters.AddWithValue("@VaiTro", nd.VaiTro);
                    cmd.Parameters.AddWithValue("@SDT", nd.SDT);
                    cmd.Parameters.AddWithValue("@MatKhau", nd.MatKhau);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch { return false; }
            }
        }

        public bool XoaNguoiDung(int maNguoiDung)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM NguoiDung WHERE MaNguoiDung = @Ma";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Ma", maNguoiDung);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch { return false; }
            }
        }
    }
} 
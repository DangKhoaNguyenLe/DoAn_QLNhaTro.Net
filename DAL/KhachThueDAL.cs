
using DAL.DataNhaTroTableAdapters;
using DTO;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class KhachThueDAL : DbProcessDAL
    {
        //public List<KhachThueDTO> GetListTenant()
        //{
        //    List<KhachThueDTO> list = new List<KhachThueDTO>();
        //    DataTable dt = khachthue.GetData();

        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        DataNhaTro.TENANTRow t = dr as DataNhaTro.TENANTRow;

        //        KhachThueDTO kt = new KhachThueDTO(
        //            t.TenantID,
        //            t.UserID,
        //            t.FullName,
        //            t.Phone,
        //            t.Email,
        //            t.BirthDate,
        //            t.Address,
        //            t.CCCD,
        //            t.NgayCap,
        //            t.NoiCap,
        //            t.Status,
        //            t.IsRoomIDNull() ? 0 : t.RoomID
        //        );

        //        list.Add(kt);
        //    }

        //    return list;
        //}
        //public bool Add(KhachThueDTO kh)
        //{
        //    try
        //    {
        //        khachthue.Insert(
        //            kh.UserID,
        //            kh.FullName,
        //            kh.Phone,
        //            kh.Email,
        //            kh.BirthDate,
        //            kh.Address,
        //            kh.CCCD,
        //            kh.NgayCap,
        //            kh.NoiCap,
        //            "",
        //            kh.Status,
        //            kh.RoomId);
        //        return true;
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw new Exception("Lỗi CSDL: " + ex.Message, ex);
        //    }
        //}

        //public bool delete(int id)
        //{
        //    try
        //    {
        //        khachthue.DeleteKH(id);
        //        return true;
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw new Exception("Lỗi CSDL: " + ex.Message, ex);
        //    }
        //}

        //public bool update(KhachThueDTO kh)
        //{
        //    try
        //    {
        //        khachthue.UpdateKH(
        //            kh.FullName,
        //            kh.Phone,
        //            kh.Email,
        //            kh.BirthDate.ToString(),
        //            kh.Address,
        //            kh.CCCD,
        //            kh.NgayCap.ToString(),
        //            kh.NoiCap,
        //            kh.Status,
        //            kh.RoomId,
        //            kh.TenantID);
        //        return true;
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw new Exception("Lỗi CSDL: " + ex.Message, ex);
        //    }
        //}

        public List<KhachThueDTO> GetListTenantByHostel(int hostelID)
        {
            List<KhachThueDTO> list = new List<KhachThueDTO>();

            string query = @"SELECT T.TenantID, T.UserID, T.FullName, T.Phone, T.Email, 
               T.BirthDate, T.Address, T.CCCD, T.NgayCap, T.NoiCap, T.Status, T.RoomID FROM TENANT T INNER JOIN ROOM R ON T.RoomID = R.RoomID  WHERE R.HostelID = @HostelID";

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.QL_nhaTroConnectionString1)) 
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@HostelID", hostelID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            KhachThueDTO kh = new KhachThueDTO();
                            kh.TenantID = reader.GetInt32(reader.GetOrdinal("TenantID"));
                            kh.UserID = reader.GetInt32(reader.GetOrdinal("UserID"));
                            kh.FullName = reader["FullName"].ToString();
                            kh.Phone = reader["Phone"].ToString();
                            kh.Email = reader["Email"].ToString();
                            kh.BirthDate = reader.GetDateTime(reader.GetOrdinal("BirthDate"));
                            kh.Address = reader["Address"].ToString();
                            kh.CCCD = reader["CCCD"].ToString();

                            if (!reader.IsDBNull(reader.GetOrdinal("NgayCap")))
                                kh.NgayCap = reader.GetDateTime(reader.GetOrdinal("NgayCap"));

                            kh.NoiCap = reader["NoiCap"].ToString();
                            kh.Status = reader["Status"].ToString();

                            if (!reader.IsDBNull(reader.GetOrdinal("RoomID")))
                                kh.RoomId = reader.GetInt32(reader.GetOrdinal("RoomID"));

                            list.Add(kh);
                        }
                    }
                }
            }
            return list;
        }

        public bool AddKhachThue(KhachThueDTO kh)
        {
            string query = @"
                INSERT INTO TENANT 
                (FullName, Phone, Email, BirthDate, Address, CCCD, NgayCap, NoiCap, Status, RoomID) 
                VALUES 
                (@FullName, @Phone, @Email, @BirthDate, @Address, @CCCD, @NgayCap, @NoiCap, @Status, @RoomID)";

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.QL_nhaTroConnectionString1))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", kh.FullName);
                        cmd.Parameters.AddWithValue("@Phone", kh.Phone ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Email", kh.Email ?? (object)DBNull.Value);

                        if (kh.BirthDate == DateTime.MinValue)
                            cmd.Parameters.AddWithValue("@BirthDate", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@BirthDate", kh.BirthDate);

                        cmd.Parameters.AddWithValue("@Address", kh.Address ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@CCCD", kh.CCCD ?? (object)DBNull.Value);

                        if (kh.NgayCap == DateTime.MinValue)
                            cmd.Parameters.AddWithValue("@NgayCap", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@NgayCap", kh.NgayCap);

                        cmd.Parameters.AddWithValue("@NoiCap", kh.NoiCap ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Status", kh.Status ?? "Đang ở");

                        if (kh.RoomId == null || kh.RoomId == 0)
                            cmd.Parameters.AddWithValue("@RoomID", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@RoomID", kh.RoomId);

                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm khách thuê: " + ex.Message);
            }

        }
        // Trong class KhachThueDAL
        public bool DeleteKhachThue(int tenantID)
        {
            string query = "DELETE FROM TENANT WHERE TenantID = @TenantID";

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.QL_nhaTroConnectionString1))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenantID", tenantID);
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi DAL khi xóa khách: " + ex.Message);
            }
        }
    }

}

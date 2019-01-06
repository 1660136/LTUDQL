using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DALTUDQL_1660007_1660010_1660136
{
    class QuanLyThuoc
    {
        public DataTable LoadListAvailable()    //hàm load các thuốc không có tick Xóa
        {
            Provider p = new Provider();
            string strQuery = "";   //chuỗi chứa strore proceduce để load
            DataTable dt = new DataTable();
            try
            {
                dt = p.Select(CommandType.StoredProcedure, strQuery);
                return dt;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                p.Disconnect();
            }
        }

        public void addMedicine(Thuoc t)
        {
            Provider p = new Provider();
            string strQuery = "";
            try
            {
                p.Connect();
                p.ExecuteNonQuery(CommandType.StoredProcedure, strQuery,
                    new SqlParameter { ParameterName = "@", Value = t.IDThuoc },
                    new SqlParameter { ParameterName = "@", Value = t.TenThuoc },
                    new SqlParameter { ParameterName = "@", Value = t.DonVi },
                    new SqlParameter { ParameterName = "@", Value = t.SoLuongTon },
                    new SqlParameter { ParameterName = "@", Value = t.Gia },
                    new SqlParameter { ParameterName = "@", Value = t.Xoa });
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                p.Disconnect();
            }
        }

        public void editMedicine(Thuoc t)
        {
            Provider p = new Provider();
            string strQuery = "";
            try
            {
                p.Connect();
                p.ExecuteNonQuery(CommandType.StoredProcedure, strQuery,
                    new SqlParameter { ParameterName = "@", Value = t.IDThuoc },
                    new SqlParameter { ParameterName = "@", Value = t.TenThuoc },
                    new SqlParameter { ParameterName = "@", Value = t.DonVi },
                    new SqlParameter { ParameterName = "@", Value = t.SoLuongTon },
                    new SqlParameter { ParameterName = "@", Value = t.Gia },
                    new SqlParameter { ParameterName = "@", Value = t.Xoa });
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                p.Disconnect();
            }
        }

        public void deleteMedicine(int m)
        {
            Provider p = new Provider();
            string strQuery = "";
            try
            {
                p.Connect();
                p.ExecuteNonQuery(CommandType.StoredProcedure, strQuery,
                    new SqlParameter { ParameterName = "@", Value = m });
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                p.Disconnect();
            }
        }

        public List<string> loadListMedicineName()
        {
            Provider p = new Provider();
            string strQuery = "";
            DataTable dt = new DataTable();
            List<string> MedicineList = new List<string> { };

            try
            {
                p.Connect();
                dt = p.Select(CommandType.StoredProcedure, strQuery);
                foreach(DataRow row in dt.Rows)
                {
                    MedicineList.Add(row[""].ToString());
                }
                return MedicineList;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                p.Disconnect();
            }
        }
    }
}

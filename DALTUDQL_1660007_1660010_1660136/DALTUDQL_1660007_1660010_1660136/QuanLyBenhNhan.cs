using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DALTUDQL_1660007_1660010_1660136
{
    class QuanLyBenhNhan
    {
        public DataTable LoadList()    //hàm load các thuốc không có tick Xóa
        {
            Provider p = new Provider();
            string strQuery = "";   //chuỗi chứa strore proceduce để load
            DataTable dt = new DataTable();
            try
            {
                p.Connect();
                dt = p.Select(CommandType.StoredProcedure, strQuery);
                return dt;
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

        public void addBN(BenhNhan bn)
        {
            Provider p = new Provider();
            string strQuery = "";
            try
            {
                p.Connect();
                p.ExecuteNonQuery(CommandType.StoredProcedure, strQuery,
                    new SqlParameter { ParameterName = "@", Value = bn.IDBN },
                    new SqlParameter { ParameterName = "@", Value = bn.TenBN },
                    new SqlParameter { ParameterName = "@", Value = bn.GioiTinh },
                    new SqlParameter { ParameterName = "@", Value = bn.NamSinh },
                    new SqlParameter { ParameterName = "@", Value = bn.DiaChi });
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

        public void editBN(BenhNhan bn)
        {
            Provider p = new Provider();
            string strQuery = "";
            try
            {
                p.Connect();
                p.ExecuteNonQuery(CommandType.StoredProcedure, strQuery,
                    new SqlParameter { ParameterName = "@", Value = bn.IDBN },
                    new SqlParameter { ParameterName = "@", Value = bn.TenBN },
                    new SqlParameter { ParameterName = "@", Value = bn.GioiTinh },
                    new SqlParameter { ParameterName = "@", Value = bn.NamSinh },
                    new SqlParameter { ParameterName = "@", Value = bn.DiaChi });
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

        public void deleteBN(int m)
        {
            Provider p = new Provider();
            string strQuery = "";
            try
            {
                p.Connect();
                p.ExecuteNonQuery(CommandType.StoredProcedure, strQuery,
                    new SqlParameter { ParameterName = "@", Value = m });
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
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPLITE.Models
{
    public class GrnMaster
    {
        public int SerialNumber { get; set; }
        public string SuppCd { get; set; }
        public string SuppNm { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime DateReceived { get; set; }
        public decimal VatAmount { get; set; }
        public decimal NetAmount { get; set; }
        public string UserName { get; set; }
    }
    public class GrnDetails
    {
        public int GrnSerialNumber { get; set; }
        public string ProdCd { get; set; }
        public string ProdNm { get; set; }
        public string Unitcd { get; set; }
        public decimal Quantity { get; set; }
        public decimal Cp { get; set; }
        public decimal LineVatAmount { get; set; }
        public decimal LineNetAmount { get; set; }
       
    }
    public class TransactionsRepository
    {
        public GrnMaster GetGrnMaster(int srno)
        {
            GrnMaster grnMaster = new GrnMaster();
            try
            {
                using (SqlConnection con=new SqlConnection(DbCon.connection))
                {
                    SqlCommand sql = new SqlCommand("Select * from GrnMaster where SrNo = @Srno", con);
                    sql.Parameters.AddWithValue("@srno", srno);
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlDataReader reader = sql.ExecuteReader();
                    
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            grnMaster.SerialNumber =(int) reader["SrNo"];
                            grnMaster.SuppCd = reader["SuppCd"].ToString();
                            grnMaster.SuppNm = reader["SuppNm"].ToString();
                            grnMaster.DateReceived = (DateTime)reader["GrnDate"];
                            grnMaster.InvoiceNumber = reader["InvoiceNumber"].ToString();
                            grnMaster.NetAmount = (decimal)reader["TotalAmount"];
                            grnMaster.VatAmount = (decimal)reader["VatAmount"];
                            grnMaster.UserName = reader["UserName"].ToString();
                        }
                    }
                    else
                        return null;
                }
            }
            catch (Exception exe)
            {

                return null;
            }
            return grnMaster;
        }
    }
   
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPLITE.Models
{
    public class SellingPrice
    {
        public string ProdCd { get; set; }
        public DateTime Chg_Dt { get; set; }
        public decimal Int_Sp { get; set; }
        public decimal New_Sp { get; set; }
        public string Usr_Nm { get; set; }
        public string Brch_Cd { get; set; }
        public string Cmpy_Cd { get; set; }
    }
    public class CostPrice
    {
        public string ProdCd { get; set; }
        public DateTime Chg_Dt { get; set; }
        public decimal Int_Cp { get; set; }
        public decimal New_Cp { get; set; }
        public string Usr_Nm { get; set; }
        public string Brch_Cd { get; set; }
        public string Cmpy_Cd { get; set; }
    }
    interface IPriceRepository
    {
        bool ChangeCP(CostPrice costPrice);
        bool ChangeSP(SellingPrice product);
        IEnumerable<CostPrice> GetCostPrices(DateTime fromdt, DateTime todt);
        IEnumerable<SellingPrice> GetSellingPrices(DateTime fromdt, DateTime todt);
    }
    public class PriceRepository : IPriceRepository
    {
        public bool ChangeCP(CostPrice product)
        {
            using (SqlConnection con =new SqlConnection(DbCon.connection))
            {
                try
                {
                    
                    string updateproduct = "Update tblprod set Cp =@cp where prodcd =@prodcd";
                    string updatecpchange = "insert into tblcphist (PROD_CD,INT_CP,NW_CP,USR_NM,CHG_DT,BRCH_CD,CMPY_CD) VALUES(@PROD_CD,@INT_CP,@NW_CP,@USR_NM,@CHG_DT,@BRCH_CD,@CMPY_CD)";
                   
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        SqlTransaction transaction = con.BeginTransaction();
                        SqlCommand sql1 = new SqlCommand(updateproduct, con);
                        sql1.Parameters.AddWithValue("@cp", product.New_Cp);
                        sql1.Parameters.AddWithValue("@prodcd",product.ProdCd);
                        sql1.Transaction = transaction;
                        SqlCommand sql2 = new SqlCommand(updatecpchange, con);
                        sql2.Parameters.AddWithValue("@PROD_CD",product.ProdCd);
                        sql2.Parameters.AddWithValue("@INT_CP",product.Int_Cp);
                        sql2.Parameters.AddWithValue("@NW_CP",product.New_Cp);
                        sql2.Parameters.AddWithValue("@USR_NM","ADMIN");
                        sql2.Parameters.AddWithValue("@BRCH_CD","NRK");
                        sql2.Parameters.AddWithValue("@CMPY_CD","TT");
                        sql2.Parameters.AddWithValue("@CHG_DT",DateTime.Now);
                        sql2.Transaction = transaction;

                    try
                    {
                        sql1.ExecuteNonQuery();
                        sql2.ExecuteNonQuery();
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception exe)
                    {

                        transaction.Rollback();
                        return false;
                    }
                }
                catch (Exception)
                {

                    return false;
                }
            }
            
        }

        public bool ChangeSP(SellingPrice product)
        {
            using (SqlConnection con = new SqlConnection(DbCon.connection))
            {
                try
                {

                    string updateproduct = "Update tblprod set sp =@sp where prodcd =@prodcd";
                    string updatecpchange = "insert into tblsphist (PROD_CD,INT_SP,NW_SP,USR_NM,CHG_DT,BRCH_CD,CMPY_CD) VALUES(@PROD_CD,@INT_SP,@NW_SP,@USR_NM,@CHG_DT,@BRCH_CD,@CMPY_CD)";

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlTransaction transaction = con.BeginTransaction();
                    SqlCommand sql1 = new SqlCommand(updateproduct, con);
                    sql1.Parameters.AddWithValue("@sp", product.New_Sp);
                    sql1.Parameters.AddWithValue("@prodcd", product.ProdCd);
                    sql1.Transaction = transaction;
                    SqlCommand sql2 = new SqlCommand(updatecpchange, con);
                    sql2.Parameters.AddWithValue("@PROD_CD", product.ProdCd);
                    sql2.Parameters.AddWithValue("@INT_SP", product.Int_Sp);
                    sql2.Parameters.AddWithValue("@NW_SP", product.New_Sp);
                    sql2.Parameters.AddWithValue("@USR_NM", "ADMIN");
                    sql2.Parameters.AddWithValue("@BRCH_CD", "NRK");
                    sql2.Parameters.AddWithValue("@CMPY_CD", "TT");
                    sql2.Parameters.AddWithValue("@CHG_DT", DateTime.Now);
                    sql2.Transaction = transaction;

                    try
                    {
                        sql1.ExecuteNonQuery();
                        sql2.ExecuteNonQuery();
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception exe)
                    {

                        transaction.Rollback();
                        return false;
                    }
                }
                catch (Exception)
                {

                    return false;
                }
            }
        }

        public IEnumerable<CostPrice> GetCostPrices(DateTime fromdt, DateTime todt)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SellingPrice> GetSellingPrices(DateTime fromdt, DateTime todt)
        {
            throw new NotImplementedException();
        }
    }

}

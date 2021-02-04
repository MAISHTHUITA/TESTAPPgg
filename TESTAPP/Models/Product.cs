using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SHOPLITE.Models
{
    public class Product
    {
        #region Properties 
        [Required, StringLength(20)]
        public string ProdCd { get; set; }
        [Required, StringLength(20)]
        public string ProdNm { get; set; }
        [StringLength(20)]
        public string UnitCd { get; set; }
        [StringLength(20)]
        public string DeptCd { get; set; }
        [StringLength(20)]
        public string SuppCd { get; set; }
        [Required]
        public decimal Cp { get; set; }
        [Required]
        public decimal Sp { get; set; }
        [Required]
        public decimal QtyOnOrder { get; set; }
        [Required]
        public decimal QtyAvble { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required, StringLength(20)]
        public string VatCd { get; set; }
        [Required, StringLength(20)]
        public string CreatedBy { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTime CreatedOn { get; set; }
        public string UploadFlag { get; set; }
        #endregion
    }
    #region repository
    interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        bool AddProduct(Product product);
        bool EditProduct(Product product);
        bool DeleteProduct(string Productcode);
        Product GetProduct(string Productcode);
        bool SaveScan(ScanCode ScanCode);
       
        IEnumerable<ScanCode> GetScanCodes();
        IEnumerable<ScanCode> ProdScans(string ProdCd);
        bool CheckScan(string Scancode);
        bool deletescan(string Scancode);

    }

    public class ScanCode
    {
        public string ScanCd { get; set; }
        public string ProdCd { get; set; }
        public string CreatedBy { get; set; }
        public string Unitcd { get; set; }

    }

    public class ProductRepository : IProductRepository
    {
        public bool AddProduct(Product product)
        {
            using (SqlConnection con = new SqlConnection(DbCon.connection))
            {
                try
                {

                    string query = "Insert into tblProd(ProdCd,ProdNm,UnitCd,DeptCd,SuppCd,Cp,Sp,VatCd,CreatedBy) values(@ProdCd,@ProdNm,@UnitCd,@DeptCd,@SuppCd,@Cp,@Sp,@VatCd,@CreatedBy)";
                    SqlCommand sql = new SqlCommand(query, con);
                    sql.Parameters.AddWithValue("@ProdCd", product.ProdCd.ToUpper());
                    sql.Parameters.AddWithValue("@ProdNm", product.ProdNm.ToUpper());
                    sql.Parameters.AddWithValue("@UnitCd", product.UnitCd.ToUpper());
                    sql.Parameters.AddWithValue("@DeptCd", product.DeptCd.ToUpper());
                    sql.Parameters.AddWithValue("@SuppCd", product.SuppCd.ToUpper());
                    sql.Parameters.AddWithValue("@Cp", product.Cp);
                    sql.Parameters.AddWithValue("@Sp", product.Sp);
                    sql.Parameters.AddWithValue("@VatCd", product.VatCd.ToUpper());
                    sql.Parameters.AddWithValue("@CreatedBy", product.CreatedBy.ToUpper());

                    try
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        SqlTransaction transaction = con.BeginTransaction();
                        sql.Transaction = transaction;
                        try
                        {
                            sql.ExecuteNonQuery();
                            transaction.Commit();
                            return true;
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            return false;
                        }
                    }
                    catch (Exception exe)
                    {
                        MessageBox.Show(exe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                }
                catch (Exception)
                {

                    throw;
                }

            }

        }

        public bool DeleteProduct(string Productcode)
        {
            throw new System.NotImplementedException();
        }

        public bool EditProduct(Product product)
        {
            using (SqlConnection con = new SqlConnection(DbCon.connection))
            {
                try
                {
                    string query = "update tblProd set ProdNm=@ProdNm,UnitCd=@UnitCd,DeptCd=@DeptCd,SuppCd=@SuppCd,VatCd=@VatCd,IsActive=@Isactive where ProdCd=@ProdCd ";
                    SqlCommand sql = new SqlCommand(query, con);
                    sql.Parameters.AddWithValue("@ProdCd", product.ProdCd.ToUpper());
                    sql.Parameters.AddWithValue("@ProdNm", product.ProdNm.ToUpper());
                    sql.Parameters.AddWithValue("@UnitCd", product.UnitCd.ToUpper());
                    sql.Parameters.AddWithValue("@DeptCd", product.DeptCd.ToUpper());
                    sql.Parameters.AddWithValue("@SuppCd", product.SuppCd.ToUpper());
                    sql.Parameters.AddWithValue("@Isactive", product.IsActive);
                    sql.Parameters.AddWithValue("@VatCd", product.VatCd.ToUpper());
                    try
                    {

                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        SqlTransaction transaction = con.BeginTransaction();
                        sql.Transaction = transaction;
                        try
                        {
                            sql.ExecuteNonQuery();
                            transaction.Commit();
                            return true;
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            return false;
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }


                }
                catch (Exception)
                {

                    return false;
                }
            }
        }

        public Product GetProduct(string Productcode)
        {
            Product product = new Product();
            using (SqlConnection con = new SqlConnection(DbCon.connection))
            {
                string query = "select * from TblProd left join TblScnCd on TblProd.ProdCd=TblScnCd.ProdCd where tblProd.ProdCd=@ProdCd or ScanCode=@ProdCd";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ProdCd", Productcode);
                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (!rdr.HasRows)
                    {
                        return null;
                    }
                    while (rdr.Read())
                    {

                        product.ProdCd = rdr["ProdCd"].ToString();
                        product.ProdNm = rdr["ProdNm"].ToString();
                        product.UnitCd = rdr["UnitCd"].ToString();
                        product.DeptCd = rdr["DeptCd"].ToString();
                        product.SuppCd = rdr["SuppCd"].ToString();
                        product.VatCd = rdr["VatCd"].ToString();
                        product.QtyAvble = Convert.ToDecimal(rdr["QtyAvble"].ToString());
                        product.QtyOnOrder = Convert.ToDecimal(rdr["QtyOnOrder"].ToString());
                        product.Cp = Convert.ToDecimal(rdr["Cp"].ToString());
                        product.Sp = Convert.ToDecimal(rdr["Sp"].ToString());
                        product.IsActive = Convert.ToBoolean(rdr["IsActive"].ToString());


                    }
                    return product;
                }
                catch (Exception exe)
                {
                    MessageBox.Show(exe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            using (SqlConnection con = new SqlConnection(DbCon.connection))
            {
                string query = "Select * from tblProd";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (!rdr.HasRows)
                    {
                        return null;
                    }
                    while (rdr.Read())
                    {
                        Product product = new Product();
                        product.ProdCd = rdr["ProdCd"].ToString();
                        product.ProdNm = rdr["ProdNm"].ToString();
                        product.UnitCd = rdr["UnitCd"].ToString();
                        product.DeptCd = rdr["DeptCd"].ToString();
                        product.SuppCd = rdr["SuppCd"].ToString();
                        product.VatCd = rdr["VatCd"].ToString();
                        product.QtyAvble = Convert.ToDecimal(rdr["QtyAvble"].ToString());
                        product.QtyOnOrder = Convert.ToDecimal(rdr["QtyOnOrder"].ToString());
                        product.Cp = Convert.ToDecimal(rdr["Cp"].ToString());
                        product.Sp = Convert.ToDecimal(rdr["Sp"].ToString());
                        product.IsActive = Convert.ToBoolean(rdr["IsActive"].ToString());
                        products.Add(product);

                    }
                    return products;
                }
                catch (Exception exe)
                {
                    MessageBox.Show(exe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
        public bool SaveScan(ScanCode ScanCode)
        {
            using (SqlConnection con = new SqlConnection(DbCon.connection))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Insert into tblscncd (Scancode,Prodcd,Unitcd,Createdby) values (@Scancode,@Prodcd,@Unitcd,@CreatedBy)", con);
                    cmd.Parameters.AddWithValue("@ScanCode", ScanCode.ScanCd);
                    cmd.Parameters.AddWithValue("@Prodcd", ScanCode.ProdCd);
                    cmd.Parameters.AddWithValue("@Unitcd", ScanCode.Unitcd);
                    cmd.Parameters.AddWithValue("@CreatedBy", ScanCode.CreatedBy);
                    if (con.State == ConnectionState.Closed) con.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception exe)
                {
                    return false;
                }
            }
        }
        public bool deletescan(string ScanCode)
        {
            using (SqlConnection con = new SqlConnection(DbCon.connection))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("delete from  tblscncd where  Scancode=@scancode", con);
                    cmd.Parameters.AddWithValue("@ScanCode", ScanCode);
                    
                    if (con.State == ConnectionState.Closed) con.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception exe)
                {
                    return false;
                }
            }
        }
        public IEnumerable<ScanCode> GetScanCodes()
        {
            List<ScanCode> scans = new List<ScanCode>();
            using (SqlConnection con = new SqlConnection(DbCon.connection))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("Select * From tblScnCd", con);

                    if (con.State == ConnectionState.Closed) con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            ScanCode scan = new ScanCode();
                            scan.ScanCd = rdr["Scancode"].ToString();
                            scan.ProdCd = rdr["Prodcd"].ToString();
                            scan.Unitcd = rdr["Unitcd"].ToString();
                            scans.Add(scan);
                        }

                    }

                    return scans;
                }
                catch (Exception exe)
                {
                    return null;
                }
            }
        }
        public bool CheckScan(string Scancode)
        {
            using (SqlConnection con = new SqlConnection(DbCon.connection))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("Select * From tblScnCd where Scancode=@Scancd", con);
                    cmd.Parameters.AddWithValue("@Scancd", Scancode);
                    if (con.State == ConnectionState.Closed) con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        return true;
                    }
                    else return false;

                }
                catch (Exception exe)
                {
                    return false;
                }
            }

        }
        public IEnumerable<ScanCode> ProdScans(string ProdCd)
        {
            List<ScanCode> scans = new List<ScanCode>();
            using (SqlConnection con = new SqlConnection(DbCon.connection))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("Select * From tblScnCd where prodcd=@prodcd", con);
                    cmd.Parameters.AddWithValue("@Prodcd", ProdCd);

                    if (con.State == ConnectionState.Closed) con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            ScanCode scan = new ScanCode();
                            scan.ScanCd = rdr["Scancode"].ToString();
                            scan.ProdCd = rdr["Prodcd"].ToString();
                            scan.Unitcd = rdr["Unitcd"].ToString();
                            scans.Add(scan);
                        }

                    }
                    else
                    {
                        return null;
                    }

                    return scans;
                }
                catch (Exception exe)
                {
                    return null;
                }

            }

        }
    }
    #endregion
}
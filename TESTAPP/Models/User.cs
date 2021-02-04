using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SHOPLITE.Models;

namespace SHOPLITE.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
       
    }
    public class UserRepository
    {
       public bool CreateUser(User user)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DbCon.connection))
                {

                    SqlCommand cmd = new SqlCommand("SpAddUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Uname", user.UserName);
                    cmd.Parameters.AddWithValue("@Fname", user.FullName);
                    cmd.Parameters.AddWithValue("@Pwd", GetPwd(user.Password));
                    cmd.Parameters.AddWithValue("@Createdby", "Admin");
                    if (con.State == ConnectionState.Closed) con.Open();
                    cmd.ExecuteNonQuery();
                    return true;

                }
            }
            catch (Exception exe)
            {

                return false;
            }
            
        }
        private string GetPwd(string input)
        {
            EncryptKey encryptKey = new EncryptKey();
            var pwd = encryptKey.Encypt(input);
            return pwd.ToString();
        }
       public bool Login(string username, string password)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DbCon.connection))
                {
                    string query = "Select Username,[Password] from tblusers where username = @uname and password=@pwd and isactive='true'";
                    SqlCommand cmd = new SqlCommand(query, con);
                  
                    cmd.Parameters.AddWithValue("@Uname", username);
                   
                    cmd.Parameters.AddWithValue("@Pwd", GetPwd(password));
                    
                    if (con.State == ConnectionState.Closed) con.Open();
                   SqlDataReader rdr= cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        return true;
                    }
                    else
                    return false;

                }
            }
            catch (Exception exe)
            {

                return false;
            }
        }
    }
}

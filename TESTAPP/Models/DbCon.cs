﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace SHOPLITE.Models
{
    class  DbCon
    {
       public static string connection 
       {
            get 
            {
                
                return conn(); 
            }
       }
        /// <summary>
        /// FOR EDWARD
        /// </summary>
        //public static string connection { get { return "Server=.;database=shoplitedb;user=sa;password=Rally2020"; } }
        private static string  conn()
        {
            string userRoot = "HKEY_CURRENT_USER" + "\\" + "SOFTWARE";
            string subKey = "ShopLite";
            string keyName = userRoot + "\\" + subKey;
            string server = (string)Registry.GetValue(keyName, "Server", "Localhost");
            string database = (string)Registry.GetValue(keyName, "Database", "ShopliteDb");
            string user = (string)Registry.GetValue(keyName, "User", "SA");
            string password = (string)Registry.GetValue(keyName, "Password", "*******");
            string conn = "Server=" + server + ";database=" + database + ";user=" + user + ";password=" + password;
            return conn;

        }
    }
}

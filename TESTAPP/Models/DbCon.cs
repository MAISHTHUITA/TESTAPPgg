using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPLITE.Models
{
    class  DbCon
    {
       public static string connection { get { return "Server=.\\wserver;database=shoplitedb;user=sa;password=Rally2020"; } }
        /// <summary>
        /// FOR EDWARD
        /// </summary>
        //public static string connection { get { return "Server=.;database=shoplitedb;user=sa;password=Rally2020"; } }
    }
}

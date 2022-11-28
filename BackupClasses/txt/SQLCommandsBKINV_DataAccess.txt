using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Windows.Forms;

namespace Capstone
{
    public class SQLCommandsBKINV_DataAccess
    {
        List<BKINV_DBRecords> bkinv = new List<BKINV_DBRecords>();
        public List<BKINV_DBRecords> LoadBookInventoryData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<BKINV_DBRecords>($"select *from book_inventory_data").ToList();
                return output;
            }
        }
    }
}

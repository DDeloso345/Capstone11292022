using Dapper;
using System;
using System.Data;

namespace Capstone
{
    public class SQLBackupAndRestoreCommandsClass
    {
        public void ManualBackUpButton(String directory)
        {
            String a = Convert.ToString(DateTime.Now);
            String newStr = a.Replace("/", "-").Replace(":", ".");
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                connection.Execute("USE Master");
                connection.Execute("BACKUP DATABASE lb_TestDB TO DISK = '" + directory + "lb_TestDB " + newStr + ".bak'");
                connection.Close();
                connection.Dispose();
            }
        }
        public void RestoreBackupButton(String directory)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                connection.Execute("USE MASTER RESTORE DATABASE [lb_TestDB] FROM DISK = '" + directory + "' WITH REPLACE;");
                connection.Close();
                connection.Dispose();
            }
        }
    }
}

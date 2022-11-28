using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Capstone
{
    public class SQLStaffCommandsClass
    {
        public List<AccountDetails_Get_Staff> LoadStaffData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<AccountDetails_Get_Staff>($"SELECT emp.id, emp.FirstName, emp.MiddleName, emp.LastName, s.Suffix, ep.Position, er.EmpRoles, emp.EMailAddress, emp.ContactNo, emp.Username, emp.ImgPath "
                            + "FROM emp_info_main emp "
                            + "INNER JOIN name_suffix s "
                            + "ON(emp.Suffix = s.id)"
                            + "INNER JOIN EmpRoles er "
                            + "ON(emp.EmpRoles = er.id) "
                            + "INNER JOIN EmpPosition ep "
                            + "ON(emp.Position = ep.id) "
                            + "where emp.EmpRoles = '2'").ToList();
                return output;
            }
        }
        public List<AccountDetails_Get> LoadStaffData_Admin()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionClass.ConnVal("lb_TestDB")))
            {
                var output = connection.Query<AccountDetails_Get>($"SELECT emp.id, emp.FirstName, emp.MiddleName, emp.LastName, s.Suffix, ep.Position, er.EmpRoles, emp.EMailAddress, emp.ContactNo, emp.Username, emp.Password, emp.ImgPath  "
                            + "FROM emp_info_main emp "
                            + "INNER JOIN name_suffix s "
                            + "ON(emp.Suffix = s.id)"
                            + "INNER JOIN EmpRoles er "
                            + "ON(emp.EmpRoles = er.id) "
                            + "INNER JOIN EmpPosition ep "
                            + "ON(emp.Position = ep.id) "
                            + "where emp.EmpRoles = '2' ").ToList();
                return output;
            }
        }
        //insert staff data
    }
}

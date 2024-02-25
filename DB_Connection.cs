using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GUI_CW
{

    public class DB_Connection
    {
        string connectoinSting = @"data source= KAVI09;" + "initial catalog = First_Bus;User Id = sa ;password = 646352";

        public SqlConnection GetSqlConnection()
        {
            SqlConnection sqlConnection = new SqlConnection(connectoinSting);
            sqlConnection.Open();

            return sqlConnection;
        }
    }

}

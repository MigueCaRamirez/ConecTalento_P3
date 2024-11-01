using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionString ;

        public ConnectionToSql()
        {
            connectionString = "server = LAPTOP-A5OSTLQJ; DataBase = MyCompany; integrated security = true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}

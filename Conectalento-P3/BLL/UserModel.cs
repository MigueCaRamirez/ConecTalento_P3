using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Common.Cache;

namespace BLL
{
    public class UserModel : ConnectionToSql
    {
        public string recoverPassword(string userRequesting)
        {
            return UserDao.recoverPassword(userRequesting);
        }

        public bool LoginUser(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT COUNT(*) FROM Users WHERE LoginName = @user AND Password = @pass", connection))
                {
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }


    }

}

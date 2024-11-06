using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class NRecuperarPassword
    {
        public bool LoginUser(string username, string password)
        {
            
            using (var connection = new SqlConnection(Conexion.conexion))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) FROM Usuarios WHERE login = @Login AND Password = @Password"; 
                    command.Parameters.AddWithValue("@Login", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.CommandType = System.Data.CommandType.Text;

                    
                    int result = (int)command.ExecuteScalar();
                    return result > 0; 
                }
            }
        }
    }
}

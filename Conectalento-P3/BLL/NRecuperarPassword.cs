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
            // Asegúrate de que la conexión a la base de datos esté correctamente configurada
            using (var connection = new SqlConnection(Conexion.conexion))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) FROM Usuarios WHERE login = @Login AND Password = @Password"; // Asegúrate de que esto coincida con tu base de datos
                    command.Parameters.AddWithValue("@Login", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.CommandType = System.Data.CommandType.Text;

                    // Ejecuta la consulta y verifica si hay coincidencias
                    int result = (int)command.ExecuteScalar();
                    return result > 0; // Retorna true si existe un usuario con esas credenciales
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DRecuperarPassword
    { // Método para validar el inicio de sesión
        public bool LoginUser(string username, string password)
        {
            using (var connection = new SqlConnection(Conexion.conexion))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT COUNT(*) FROM Usuario WHERE login = @Login AND Contraseña = @Password", connection))
                {
                    command.Parameters.AddWithValue("@Login", username);
                    command.Parameters.AddWithValue("@Password", password); // Asegúrate de que la contraseña se maneje de forma segura

                    int count = (int)command.ExecuteScalar();
                    return count > 0; // Devuelve true si hay un registro que coincide
                }
            }
        }

        public string recoverPassword(string usuarioSolicitado)
        {
                using (var connection = new SqlConnection(Conexion.conexion))
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT * FROM Usuarios WHERE login = @Login OR Correo = @Correo";
                        command.Parameters.AddWithValue("@Login", usuarioSolicitado);
                        command.Parameters.AddWithValue("@Correo", usuarioSolicitado);
                        command.CommandType = System.Data.CommandType.Text;

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            string nombreUsuario = reader.GetString(1);
                            string correoUsuario = reader.GetString(8);
                            string cuentaContraseña = reader.GetString(6);

                            var mailService = new DCorreoSoporte();
                            mailService.SendMail(
                                subject: "SOPORTE DE CONECTALENTO: solicitud de recuperación de contraseña",
                                body: $"Hola {nombreUsuario}\nUsted solicitó recuperar su contraseña.\n" +
                                      $"Su contraseña actual es:  { cuentaContraseña}"+
                                      "\nSin embargo le pedimos que cambie su contraseña una vez ingrese al sistema",
                                destinatarioCorreo: new List<string> { correoUsuario });

                            return $"Hola, {nombreUsuario}\nUsted solicitó recuperar su contraseña\n" +
                                   $"Por favor revise su correo: {correoUsuario}\n" +
                                   "Sin embargo le pedimos que cambie su contraseña una vez ingrese al sistema.";
                        }
                        else
                        {
                            return "Lo sentimos, no hay ninguna cuenta registrada con ese correo.";
                        }
                    }
                }
            }
        }
    }


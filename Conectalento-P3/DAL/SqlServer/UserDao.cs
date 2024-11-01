using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;

namespace DAL
{
    public class UserDao : ConnectionToSql
    {
        public bool Login(string user, string pass)
            
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Users where LoginName=@user and Password=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserCache.IdUser = reader.GetInt32(0);
                            UserCache.FirstName = reader.GetString(3);
                            UserCache.LastName = reader.GetString(4);
                            UserCache.Position = reader.GetString(5);
                            UserCache.Email = reader.GetString(6);

                        }
                        return true;
                    }
                    else
                    { return false; }
                }
            }
        }

        public bool editPassword(int user, string pass)
        {
            if (user == UserCache.IdUser)
            {
                
            }
            return true;
        }



            public string recoverPassword(string userRequesting)
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "Select * from Users where LoginName=@user or Email=@mail";
                        command.Parameters.AddWithValue("@user", userRequesting);
                        command.Parameters.AddWithValue("@mail", userRequesting);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read() == true)
                        {
                            string userName = reader.GetString(3) + ", " + reader.GetString(4);
                            string userMail = reader.GetString(6);
                            string accountPasword = reader.GetString(2);

                            var mailService = new MailServices.SystemSupportMail();
                            mailService.sendMail(
                                subject: "System : Solicitud de recuperación de contraseña",
                                body: "Hola, " + userName + " \nSolicitaste recuperar tu contraseña. \n " +
                                "Su contraseña actual es: " + accountPasword +
                                "\nSin embargo, le solicitamos que cambie su contraseña inmediatamente una vez que ingrese al sistema.",
                                recipientMail: new List<string> { userMail }

                                );
                            return "Hola, " + userName + " \nSolicitaste recuperar tu contraseña. \n " +
                                "Por favor revise su correo: " + userMail +
                                "\nSin embargo, le solicitamos que cambie su contraseña inmediatamente una vez que ingrese al sistema.";

                        }
                        else
                        {
                            return "Lo siento, no tienes una cuenta registrada con este nombre de usuario o correo";
                        }

                    }

                }

            }

        public void AnyMethod()
        {
            if (UserCache.Position == "administrator")
            {

            }
        }

        }
    }





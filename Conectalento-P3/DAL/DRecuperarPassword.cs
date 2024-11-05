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
    {
        private SmtpClient smtpClient;
        protected string remitenteCorreo {  get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl {  get; set; }

        protected void initializeSmtpClient()
        {
          smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(remitenteCorreo,password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;

        }

        public void sendMail(string subject, string body, List<string> destinatarioCorreo)
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(remitenteCorreo);
                foreach (string mail in destinatarioCorreo)
                {
                    mailMessage.To.Add(mail);
                }
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            { }

            finally
            {
                mailMessage.Dispose();
                smtpClient.Dispose();
            }

        }

        public string recoverPassword(string usuarioSolicitado)
        {
        using (var connection = new SqlConnection())
            {
                connection.ConnectionString = Conexion.conexion;  
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from Usuario where login=@Login or Correo=@Correo";
                    command.Parameters.AddWithValue("@Login", usuarioSolicitado);
                    command.Parameters.AddWithValue("@Correo", usuarioSolicitado);


                }

            }

        }


    }
}

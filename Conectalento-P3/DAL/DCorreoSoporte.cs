using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DCorreoSoporte
    {
        private string remitenteCorreo;
        private string password;
        private string host;
        private int port;
        private bool ssl;
        private SmtpClient smtpClient;

        public DCorreoSoporte()
        {
            remitenteCorreo = "conectalentosoporte@gmail.com";
            password = "ajwxtzkuzykglozi";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            InitializeSmtpClient();
        }

        private void InitializeSmtpClient()
        {
            smtpClient = new SmtpClient
            {
                Credentials = new NetworkCredential(remitenteCorreo, password),
                Host = host,
                Port = port,
                EnableSsl = ssl
            };
        }

        public void SendMail(string subject, string body, List<string> destinatarioCorreo)
        {
            using (var mailMessage = new MailMessage())
            {
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
                {
                    // Manejo de errores, log o lanzar la excepción según tus necesidades
                    Console.WriteLine("Error al enviar el correo: " + ex.Message);
                }
            }
        }
    }
}

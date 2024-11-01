using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace DAL.MailServices
{
    public abstract class MasterMailServer
    {
        private SmtpClient smtpClient;

        protected string SenderMail { get; set; }
        protected string Password { get; set; }
        protected string Host { get; set; }
        protected int Port { get; set; }
        protected bool ssl { get; set; }

        protected void initializeSmtpClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(SenderMail, Password);
            smtpClient.Host = Host;
            smtpClient.Port = Port;
            smtpClient.EnableSsl = ssl;

        }

        public void sendMail(string subject, string body, List<string> recipientMail)
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(SenderMail);
                foreach (string mail in recipientMail)
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

    }
}

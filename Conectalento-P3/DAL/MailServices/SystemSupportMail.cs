using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MailServices
{
     class SystemSupportMail : MasterMailServer
    {
        public SystemSupportMail() {

            SenderMail = "conectalentosoporte@gmail.com";
            Password = "1066870427cris";
            Host = "smtp.gmail.com";
            Port = 587;
            ssl = true;
            initializeSmtpClient();

        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace H09_LabMocking02
{
    public class Email
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public bool Send(MailService mailService) {
            return mailService.SendMail(this);
        }
    }
}

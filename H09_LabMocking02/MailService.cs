using System;
using System.Collections.Generic;
using System.Text;

namespace H09_LabMocking02
{
    public class MailService : IMailService {
        public bool SendMail(Email email) {

            //maybe the address is wrong, or the body is too long
            //or who knows.... the point is that this class
            //may return true or false

            Random r = new Random();
            return r.Next(0, 2) == 1;
        }
    }
}

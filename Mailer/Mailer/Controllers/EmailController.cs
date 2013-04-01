using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActionMailer.Net.Mvc;

namespace Mailer.Controllers
{
    public class EmailController : MailerBase
    {
        public EmailResult VerificationEmail()
        {
            To.Add("user@email.com");
            From = "no-reply@test.com";
            Subject = "TestTestTest";
            return Email("VerificationEmail");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit;
using MailKit.Net.Smtp;
using MimeKit;

namespace WebsiteForAsa.Services
{
    public class MailService
    {
        private static MailService uniqueInstance;
        private static readonly object locker = new object();
        private MailService()
        {

        }
        public static MailService GetInstance()
        {
            if (uniqueInstance == null)
            {
                lock (locker)
                {
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new MailService();
                    }
                }
            }
            return uniqueInstance;
        }

        public void SendMail()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("firfly","qweasdz76@live.com"));
            message.To.Add(new MailboxAddress("Mr.qq", "919605043@qq.com"));
            message.Subject = "主题";
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = "测试1";
            message.Body = bodyBuilder.ToMessageBody();
            using (var client=new SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.Connect("smtp-mail.outlook.com", 587,false);
                client.Authenticate("qweasdz76@live.com", "qwe12345as123");
                client.Send(message);
                client.Disconnect(true);
            }
        }

    }
}

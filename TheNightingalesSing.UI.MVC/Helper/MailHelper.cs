using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace TheNightingalesSing.UI.MVC.Helper
{
    public static class MailHelper
    {
        public static bool SendActivationCode(string userName,string eMail,Guid code)
        {
            MailMessage msg = new MailMessage();
            msg.To.Add(eMail);
            msg.Subject = "The Nightingale Sing Activation";
            msg.IsBodyHtml = true;
            msg.Body = string.Format("<!DOCTYPE html><html><head><title>LiveInCircle</title></head><body><h2>Merhaba {0} sitemize hoşgeldin</h2><p>Hesabınızı aktifleştirmek için lütfen <a href='http://localhost:53234/Account/ActivationUser/{1}'>link</a>'e tıklayınız</p></body></html>", userName,code);
            msg.From = new MailAddress("YMS5170Coder@outlook.com", "TheNightingaleSing");

            SmtpClient client = new SmtpClient("smtp.office365.com", 587);
            client.EnableSsl = true;
            client.UseDefaultCredentials = true;
            NetworkCredential credential = new NetworkCredential("......@outlook.com", ".....");
            client.Credentials = credential;

            try
            {
                client.Send(msg);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

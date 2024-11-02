using MimeKit.Text;
using MailKit.Security;
using System.Net.Mail;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;


using System.Threading.Tasks;

namespace FoodBoot.Writ_json
{
    public static class EmailSender
    {
        public static string possword;
        public static async void EmailSend(this string emailSender)
        {

            Random random = new Random();
            int otp = random.Next(100000, 999999);
            possword = otp.ToString();
            var email = new MimeMessage();

            email.From.Add(MailboxAddress.Parse("samadovxusan9013@gmail.com"));
            email.To.Add(MailboxAddress.Parse(emailSender));
            email.Subject = "Your verification code";
            email.Body = new TextPart(TextFormat.Html) { Text = "Your verification code is " + otp };

            var smpt = new SmtpClient();
            await smpt.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            await smpt.AuthenticateAsync("samadovxusan9013@gmail.com", "dixaxlwqasgetqlb");
            await smpt.SendAsync(email);
            await smpt.DisconnectAsync(true);


        }

    }


}

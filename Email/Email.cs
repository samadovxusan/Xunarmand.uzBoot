using Microsoft.AspNetCore.Identity;
using static System.Net.Mime.MediaTypeNames;
using System.Net.Mail;

namespace Email
{
    public class Email
    {

        Random random = new Random();
        int otp = random.Next(10000000, 99999999);
        var email = new MimeMessage();
        var existUser = await _userManager.FindByEmailAsync(emailSenderDto.Email);

        email.From.Add(MailboxAddress.Parse("samadovxusan9013@gmail.com"));
            email.To.Add(MailboxAddress.Parse(emailSenderDto.Email));
            email.Subject = "Your verification code";
            email.Body = new TextPart(TextFormat.Html) { Text = "Your verification code is " + existUser.PhoneNumber};

        var smpt = new SmtpClient();
        await smpt.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
        await smpt.AuthenticateAsync("samadovxusan9013@gmail.com", "dixaxlwqasgetqlb");
        await smpt.SendAsync(email);
        await smpt.DisconnectAsync(true);
    }
}

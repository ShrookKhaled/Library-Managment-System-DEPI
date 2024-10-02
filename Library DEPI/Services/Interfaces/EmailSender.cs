using System.Net.Mail;
using System.Net;

namespace Library_DEPI.Services.Interfaces
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var EmailFrom = " ";
            var PasswordFrom = " ";
            var message = new MailMessage();
            message.From = new MailAddress(EmailFrom);
            message.Subject = subject;
            message.To.Add(email);
            message.Body = $"<html><body><div class=\"text-center\"> " +
                $"<p>Comfirm Your Email</p>" +
                $"<p class='text-center'>{htmlMessage}</p>" +
                $"</div>" +
                $"</body>" +
                $"</html>";
            message.IsBodyHtml = true;
            var smtpClient = new SmtpClient("smtp.office365.com", 587)
            {
                UseDefaultCredentials = false,
                EnableSsl = true,
                Credentials = new NetworkCredential(EmailFrom, PasswordFrom),


            };
            try
            {
                smtpClient.Send(message);
            }
            catch (SmtpException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

using Microsoft.AspNetCore.Identity;
using Pri.Api.Pe.Core.Entities;
using Pri.Api.Pe.Core.Interfaces.Services;
using Pri.Api.Pe.Core.Services.Models;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using System.Text;
using Microsoft.AspNetCore.WebUtilities;

namespace Pri.Api.Pe.Core.Services
{
    public class MailService : IMailService
    {
        public async Task<ResultModel<bool>> SendValidationEmail(UserManager<ApplicationUser> userManager, ApplicationUser user, string sender, string apikey)
        {
            var token = await userManager.GenerateEmailConfirmationTokenAsync(user);

            var encodedToken = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));
            var confirmationLink = $"https://localhost:44382/api/auth/confirm-email/{user.Id}/{encodedToken}";

            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(sender));
            email.To.Add(MailboxAddress.Parse(user.Email));
            email.Subject = "Confirm your emailaddress";
            email.Body = new TextPart(TextFormat.Html)
            {
                Text = $"<h5>Please confirm your emailadress</h5>" +
                $"<p>Please confirm your emailadress by clicking " +
                $"<a href='{confirmationLink}'>here</a></p>",
            };
            using var smtpClient = new SmtpClient();
            await smtpClient.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            await smtpClient.AuthenticateAsync(sender, apikey);
            var result = await smtpClient.SendAsync(email);
            await smtpClient.DisconnectAsync(true);
            return new ResultModel<bool>
            {
                Value = true,
                IsSucces = true
            };
        }
    }
}

using System.Net;
using System.Net.Mail;

namespace ElektronikaWebLayihe.Services;

public class MailService : IMailService
{
    readonly IConfiguration _configuration;

    public MailService(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    public Task SendMessageAsync(string to, string body)
    {
        MailMessage mail = new();
        mail.To.Add(to);
        mail.From = new(_configuration["Mail:Username"],"Admin", System.Text.Encoding.UTF8);
        SmtpClient smtp = new();
        smtp.Credentials = new NetworkCredential(_configuration["Mail:Username"], _configuration["Mail:Password"]);
        smtp.Port = 587;
        smtp.EnableSsl = true;
        smtp.Host = _configuration["Mail:Host"];
        return smtp.SendMailAsync(mail); 
    }
}
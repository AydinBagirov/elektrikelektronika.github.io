namespace ElektronikaWebLayihe.Services;

public interface IMailService
{
    Task SendMessageAsync(string to, string body);
}
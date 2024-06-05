namespace Prueba.Services.Mailsender
{
    public interface IMailSenderServices
    {
        public void SendMail(string? to, string? owner, string? pet, string? vet, DateTime? date);
    }
}
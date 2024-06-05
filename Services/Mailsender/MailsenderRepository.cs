using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Services.Mailsender
{
    public class MailSenderServices : IMailSenderServices
    {
        private readonly HttpClient _httpClient;
        public MailSenderServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.Timeout = TimeSpan.FromSeconds(100); // Ajusta el tiempo de espera a 100 segundos (No es tan necesario pero aja pa que no se de cuenta que puede fallar C:)
        }

        public void SendMail(string? to, string? owner, string? pet, string? vet, DateTime? date)
        {
            try
            {
                var requestBody = new
                {
                    from = new
                    {
                        email = "MS_PmYp6t@trial-0p7kx4x8r12g9yjr.mlsender.net"
                    },
                    to = new[]
                    {
                        new {
                            email = to
                        }
                    },
                    subject = "Recuerda tu cita",
                    text = $"Hola {owner}, recuerda la cita de tu mascota {pet} con el veterinario {vet}, el día {date?.ToString("dd/MM/yyyy")}."
                };

                var body = System.Text.Json.JsonSerializer.Serialize(requestBody);

                var request = new HttpRequestMessage(HttpMethod.Post, "https://api.mailersend.com/v1/email")
                {
                    Content = new StringContent(body, Encoding.UTF8, "application/json")
                };

                request.Headers.Add("Authorization", $"Bearer mlsn.9a2354296918d178648519363440bccb6d9be99c6a8ea0b913bbd1de93a680ad");
                HttpResponseMessage response =  _httpClient.Send(request);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error al enviar el correo: {e.Message}");
            }
        }
    }
}

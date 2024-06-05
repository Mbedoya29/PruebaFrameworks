using System.Text.Json.Serialization;

namespace Prueba.Models
{
    public class Vet
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }

        [JsonIgnore]
        public List<Quote>? Quotes { get; set; }
    }
}
using System.Text.Json.Serialization;

namespace Prueba.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Specie { get; set; }
        public string? Race { get; set; }
        public DateTime? DateBirth { get; set; }
        public int OwnerId { get; set; }
        public string? Photo { get; set; }

        [JsonIgnore]
        public Owner? Owner { get; set; }

        [JsonIgnore]
        public List<Quote>? Quotes { get; set; }

    }
}
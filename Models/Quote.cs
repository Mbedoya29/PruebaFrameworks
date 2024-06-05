using System.Text.Json.Serialization;

namespace Prueba.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int PetId { get; set; }
        public int VetId { get; set; }
        public string? Description { get; set; }

        [JsonIgnore]
        public Pet? Pet { get; set; }

        [JsonIgnore]
        public Vet? Vet { get; set; }
    }
}
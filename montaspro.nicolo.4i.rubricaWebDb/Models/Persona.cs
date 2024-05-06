using System.ComponentModel.DataAnnotations;

namespace montaspro.nicolo._4i.rubricaWebDb.Models
{
    public class Persona
    {
        
        public int? Id { get; set; }
        public string? nome { get; set; }
        public string? cognome { get; set; }
        public string? email { get; set; }

    }
}

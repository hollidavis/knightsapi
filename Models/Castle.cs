using System.ComponentModel.DataAnnotations;

namespace knightsapi.Models
{
    public class Castle
    {
        public int Id {get; set;}
        [Required]
        public string Name {get; set;}
    }
}
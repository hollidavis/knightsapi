using System.ComponentModel.DataAnnotations;

namespace knightsapi.Models
{
    public class Knight
    {
        public int Id {get; set;}
        [Required]
        public string Name {get; set;}
        public int CastleId {get; set;}
    }
}
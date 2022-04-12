using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResturantRaterAPI.Models
{
    public class Ratings
    {
        [Key]
        public int Id{get; set;}
        
        [Required]
        [ForeignKey("Resturaunt")]
        public int ResturauntId {get; set;}
        [Required]
        public double Score{get; set;}
    }
}
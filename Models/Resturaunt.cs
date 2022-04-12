using System;
using System.ComponentModel.DataAnnotations;

namespace ResturantRaterAPI.Models
{
    public class Resturaunt
    {
        [Key]
        public int Id {get; set;}

        [Required]
        [MaxLength(100)]
        public string Name {get; set;}

        [Required]
        [MaxLength(100)]
        public string Location {get; set;}

    }
}
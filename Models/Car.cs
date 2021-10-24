using System.ComponentModel.DataAnnotations;

namespace FinalGregsList.Models
{
    public class Car
    {


        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        public string make { get; set; }
        [Required]
        [Range(0,5000000)]
        public int price { get; set; }
        [Required]
        [Range(1900, 3000)]
        public int year { get; set; }
        [Required]
        public string description { get; set; }
        public string img { get; set; }





    }
}
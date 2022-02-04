using System.ComponentModel.DataAnnotations;

namespace TwitterKristinAnna.Models
{
    public class Tweet
    {

        [Key]

        public int Id { get; set; }
        [Required]

        public string Main { get; set; }




    }
}


using System.ComponentModel.DataAnnotations;

namespace SchoolProject1.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public byte[] Picture { get; set; }

    }
}

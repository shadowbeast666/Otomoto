using System.ComponentModel.DataAnnotations;

namespace Otomoto.Models
{
    public class CarBrand
    {
        public int CarBrandId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}

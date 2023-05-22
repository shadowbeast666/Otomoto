using System.ComponentModel.DataAnnotations;

namespace Otomoto.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }

        [Required]
        public string Opis { get; set; }

        [Required]
        public string Marka { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string Typ { get; set; }

        [Required]
        public string Pojemnosc { get; set; }

        [Required]
        public string SkrzyniaBiegow { get; set; }

        [Required]
        public int RokProdukcji { get; set; }


        [Required]
        public decimal Cena { get; set; }

        public int Vin { get; set; }

        [Required]
        public decimal Przebieg { get; set; }

        [Required]
        public string RodzajPaliwa { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsAdActive { get; set; }

        public bool IsAdPaid { get; set; }

        public byte[]? CarPicture { get; set; }

    }
}


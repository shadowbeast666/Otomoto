using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Otomoto.Models
    
{
    public class ChangeUserPasswordViewModel
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }
    }

}

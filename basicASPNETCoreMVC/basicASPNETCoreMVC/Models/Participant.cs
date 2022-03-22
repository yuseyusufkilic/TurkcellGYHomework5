using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace basicASPNETCoreMVC.Models
{
    public class Participant
    {
        [Required(ErrorMessage ="Mail alanı boş bırakılamaz.")]
        [EmailAddress(ErrorMessage ="E-Posta hatalı girildi.")]
        public string Email { get; set; }

        [MinLength(2,ErrorMessage ="İsim çok kısa.")]
        [Required(ErrorMessage = "İsim alanı boş bırakılamaz.")]
        public string Name { get; set; }
    }
}

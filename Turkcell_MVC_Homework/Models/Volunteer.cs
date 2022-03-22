using System.ComponentModel.DataAnnotations;

namespace Turkcell_MVC_Homework.Models
{
    public class Volunteer
    {
        [Required(ErrorMessage ="Lütfen İsminizi Giriniz:")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz:")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen Email Hesabınızı Giriniz:")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen Yaşınızı Giriniz:")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Lütfen Telefon No Giriniz:")]
        public string Telephone { get; set; }  

    }
}

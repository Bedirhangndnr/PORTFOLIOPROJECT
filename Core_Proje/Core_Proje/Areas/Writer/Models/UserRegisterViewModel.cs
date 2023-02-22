using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen adınızı adınızı giriniz...")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soyadınızı adınızı giriniz...")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen Kullanıcı adını giriniz...")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen görsel için url adını giriniz...")]
        public string ImagegUrl{ get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi giriniz...")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz...")]
        [Compare("Password", ErrorMessage = "Şifreler Uyumlu değil...")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen bir mail adresi giriniz...")]
        public string Mail { get; set; }
    }
}

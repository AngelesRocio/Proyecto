using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Proyecto.Models
{
    public class User
    {
        public int idUser { get; set; }
        [Display(Name = "Nombres")]
        public string? name { get; set; }
        [Required]
        [Display(Name ="Contraseña")]
        [PasswordPropertyText]
        [Compare("passwordConfirm")]
        public string? password { get; set; }
        [Required]
        [Display(Name ="Confirme contraseña")]
        [PasswordPropertyText]
        public string? passwordConfirm { get; set; }
        [Display(Name ="Fecha de registro")]
        public DateTime registerDate { get; set; }
        [Display(Name ="Fecha de nacimiento")]
        public DateTime birthDate { get; set; }
        public int status { get; set; }
        [Required]
        [Display(Name ="Correo electrónico")]
        [EmailAddress]
        public string? email { get; set; }
        public int flag { get; set; }
        [Required]
        [Display(Name ="Apellido paterno")]

        public string? lastFirstName { get; set; }
        [Required]
        [Display(Name ="Apellido materno")]
        public string? lastSecondName { get; set; }
        [Required]
        [Display(Name ="DNI")]
        [RegularExpression("[0-9]{8}",ErrorMessage= "Ingrese un DNI válido")]
        public string? dni { get; set; }
        [Required]
        [Display(Name ="Teléfono")]
        [RegularExpression("9[0-9]{8}",ErrorMessage ="Ingrese un número de celular válido")]
        public string? phone { get; set;}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity.Spatial;
using System.ComponentModel.DataAnnotations.Schema;


namespace Client.Models
{
    public class RegistrationModel
    {
        [Key]
        public string Id { get; set; }

        [Display(Name = "Логин*")]
        //[StringLength(15, MinimumLength = 3,
        //    ErrorMessage = "Длина логина должна быть в диапазоне от {2} до {1} символов!")]
        //[Required(ErrorMessage = "Логин не может быть пустым!")]
        public string Login { get; set; }

        [Display(Name = "Пароль*")]
        [DataType(DataType.Password)]
        //[Required]
        //[StringLength(50, MinimumLength = 5,
        //    ErrorMessage = "Длина пароля должна быть в диапазоне от {2} до {1} символов!")]
        //[RegularExpression(@"(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).*",
        //    ErrorMessage = "В пароле должны быть буквы с верхним и нижним регистром, цифры, а также символ '_'!")]
        public string Password { get; set; }

        //[RegularExpression(@"[a-zA-Zа-яА-яёЁ][a-zA-Zа-яА-яёЁ0-9-_\.]{1,20}",
        //    ErrorMessage = "Некорректное имя!")]
        //[StringLength(30, MinimumLength = 1,
        //    ErrorMessage = "Длина имени должна быть в диапазоне от {2} до {1} символов!")]
        //[Required(ErrorMessage = "Имя не может быть пустым!")]
        [Display(Name = "Имя*")]
        public string Name { get; set; }

        
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }

        [Display(Name = "Email*")]
        //[RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string VUZ { get; set; }

        
        public string Position { get; set; }

    }
}
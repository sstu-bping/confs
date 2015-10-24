using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Client.Models
{
    public class RegistrationModel
    {
        public string Id { get; set; }

        [Display(Name = "Логин*")]
        [StringLength(15, MinimumLength = 3,
            ErrorMessage = "Длина логина должна быть в диапазоне от {2} до {1} символов!")]
        [Required(ErrorMessage = "Логин не может быть пустым!")]
        public string Login { get; set; }

        [Display(Name = "Пароль*")]
        [DataType(DataType.Password)]
        [Required]
        [StringLength(50, MinimumLength = 5,
            ErrorMessage = "Длина пароля должна быть в диапазоне от {2} до {1} символов!")]
        [RegularExpression(@"(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).*",
            ErrorMessage = "В пароле должны быть буквы с верхним и нижним регистром, цифры, а также символ '_'!")]
        public string Password { get; set; }

        [RegularExpression(@"[a-zA-Zа-яА-яёЁ][a-zA-Zа-яА-яёЁ0-9-_\.]{1,20}",
            ErrorMessage = "Некорректное имя!")]
        [StringLength(30, MinimumLength = 1,
            ErrorMessage = "Длина имени должна быть в диапазоне от {2} до {1} символов!")]
        [Required(ErrorMessage = "Имя не может быть пустым!")]
        [Display(Name = "Имя*")]
        public string Name { get; set; }

        [RegularExpression(@"[а-яА-яёЁ]{0,40}",
          ErrorMessage = "Некорректная фамилия!")]
        [StringLength(40, MinimumLength = 0,
            ErrorMessage = "Длина фамилии должна быть меньше {1} символов!")]
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }

        [Display(Name = "Email*")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        [DataType(DataType.EmailAddress)]
        public int Email { get; set; }

        [Display(Name = "ВУЗ*")]
        [StringLength(15, MinimumLength = 3,
            ErrorMessage = "Длина ВУЗа должна быть в диапазоне от {2} до {1} символов!")]
        [Required(ErrorMessage = "ВУЗ не может быть пустым!")]
        public string VUZ { get; set; }

        [Display(Name = "Должность*")]
        [StringLength(20, MinimumLength = 3,
            ErrorMessage = "Длина должности должна быть в диапазоне от {2} до {1} символов!")]
        [Required(ErrorMessage = "Должность не может быть пустой!")]
        public string Position { get; set; }


        //public static bool Add(RegistrationModel model)
        //{

        //}
        //public static bool ExistAccountWithLogin(string login)
        //{

        //}
    }
}
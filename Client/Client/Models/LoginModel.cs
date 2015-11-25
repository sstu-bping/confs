using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Client.Models
{
    public class LoginModel
    {
        [Display(Name = "Логин")]
        //[StringLength(15, MinimumLength = 3)]
        [Required(AllowEmptyStrings = false)]
        public string  Login { get; set; }

        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        [Required]
        //[StringLength(50, MinimumLength = 5,
        //    ErrorMessage = "Длина пароля должна быть в диапазоне от {2} до {1} символов!")]
        //[RegularExpression(@"(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).*",
        //    ErrorMessage = "В пароле должны быть цифры, буквы с верхним и нижним регистром, а также символ '_'!")]
        public string Password { get; set; }

    }
}
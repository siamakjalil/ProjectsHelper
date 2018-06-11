using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyEshop.Models
{
    public class RegisterViewModel
    {
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string UserName { get; set; }
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
        public string Email { get; set; }
        [Display(Name = "کلمه عبور")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Pass { get; set; }
        [Display(Name = "تکرار کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Compare("Pass", ErrorMessage = "کلمه های عبور مغایرت دارند")]
        [DataType(DataType.Password)]
        public string RePass { get; set; }

    }


    public class LoginViewModel
    {
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "کلمه عبور")]
        [DataType(DataType.Password)]
        public string Pass { get; set; }
        [Display(Name = "مرا به خاطر بسپار")]
        public bool Remember { get; set; }

    }

    #region تغییر کلمه عبور
    public class ChangePasswordViewModel
    {

        [Display(Name = "کلمه عبور فعلی")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string oldPassword { get; set; }

        [Display(Name = "کلمه عبور")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Pass { get; set; }
        [Display(Name = "تکرار کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Compare("Pass", ErrorMessage = "کلمه های عبور مغایرت دارند")]
        [DataType(DataType.Password)]
        public string RePass { get; set; }

    }

#endregion

    public class RecoveryPassViewModel
    {
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
        public string Email { get; set; }
    }


    public class ChangePassViewModel
    {
        public string ActiveCode { get; set; }


        [Display(Name = "کلمه عبور")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Pass { get; set; }
        [Display(Name = "تکرار کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Compare("Pass", ErrorMessage = "کلمه های عبور مغایرت دارند")]
        [DataType(DataType.Password)]
        public string RePass { get; set; }
    }

}
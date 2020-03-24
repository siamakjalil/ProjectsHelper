using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public static class ErrorTitle
    {
        public static string Create(this string msg)
        {
            return msg + " با موفقیت ثبت شد.";
        }
        public static string Edit(this string msg)
        {
            return msg + " با موفقیت ویرایش شد.";
        }
        public static string Delete(this string msg)
        {
            return msg + " با موفقیت حذف شد.";
        }
        public static string CreateError { get; } = "خطا در ثبت اطلاعات.";
        public static string EditError { get; } = "خطا در ویرایش اطلاعات.";
        public static string DeleteError { get; } = "خطا در حذف اطلاعات.";
        public static string Imgerror { get; } = "تصویر معتبر نیست.";
    }
}

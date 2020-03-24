using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helper
{
    //Developed by SIAMAK JALILI
    //www.Siamakjalili.com
    public static class ResponseManager
    {
        public static ServiceMessage ServerError()
        {
            return (new ServiceMessage()
            {
                ErrorId = -1,
                ErrorTitle = "خطای سیستمی رخ داده، مجددا تلاش کنید.",
            });
        }

        public static ServiceMessage SessionExpire()
        {
            return (new ServiceMessage()
            {
                ErrorId = -21,
                ErrorTitle = "مدت زمان مجاز شما برای حضور در نرم افزار به پایان رسیده است لطفا مجددا وارد شوید.",
            });
        }

        public static ServiceMessage DataError(string title)
        {
            return (new ServiceMessage()
            {
                ErrorId = -2,
                ErrorTitle = title,
            });
        }
        public static ServiceMessage FillObject(dynamic obj)
        {
            return (new ServiceMessage()
            {
                ErrorId = 0,
                Result = obj
            });
        }
        public static ServiceMessage ActivationError()
        {
            return (new ServiceMessage()
            {
                ErrorId = -2,
                ErrorTitle = "کد فعالسازی اشتباه وارد شده است.",
            });
        }
        public static ServiceMessage UserNotFound()
        {
            return (new ServiceMessage()
            {
                ErrorId = -2,
                ErrorTitle = "کاربر یافت نشد",
            });
        }
        public static ServiceMessage LoginWithPass()
        {
            return (new ServiceMessage()
            {
                ErrorId = 22,
                ErrorTitle = null,
                Result = null
            });
        }

        public static ServiceMessage CustoMessage(int id, string title, string res)
        {
            return (new ServiceMessage()
            {
                ErrorId = id,
                ErrorTitle = title,
                Result = res
            });
        }
        public static ServiceMessage CustoMessage(int id, string title, dynamic res)
        {
            return (new ServiceMessage()
            {
                ErrorId = id,
                ErrorTitle = title,
                Result = res
            });
        }


    }
    #region --ServiceMessageModel--
    public class ServiceMessage
    {
        public int? ErrorId { get; set; }
        public string ErrorTitle { get; set; }
        public dynamic Result { get; set; }
    }
    #endregion
}
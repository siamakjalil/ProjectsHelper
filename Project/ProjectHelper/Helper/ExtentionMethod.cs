using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public static class ExtentionMethod
    {
        public static string ToMobileNumber(this string mobileNumber)
        {
            if (mobileNumber.Length > 11)
            {
                var mobile = mobileNumber.Substring(mobileNumber.Length - 10);
                return "0" + mobile;
            }

            return mobileNumber;

        }
        public static string ToShamsi(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(value) + "/" + pc.GetMonth(value).ToString("00") + "/" + pc.GetDayOfMonth(value).ToString("00");
        }

        public static string ToPersianDay(this DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Saturday:
                    return "شنبه";
                case DayOfWeek.Sunday:
                    return "یکشنبه";
                case DayOfWeek.Monday:
                    return "دوشنبه";
                case DayOfWeek.Tuesday:
                    return "سه شنبه";
                case DayOfWeek.Wednesday:
                    return "چهارشنبه";
                case DayOfWeek.Thursday:
                    return "پنجشنبه";
                case DayOfWeek.Friday:
                    return "جمعه";
                default:
                    return null;

            }

        }
        public static string ToPersianMonth(this int month)
        {
            switch (month)
            {
                case 1:
                    return "فروردین";
                case 2:
                    return "اردیبهشت";
                case 3:
                    return "خرداد";
                case 4:
                    return "تیر";
                case 5:
                    return "مرداد";
                case 6:
                    return "شهریور";
                case 7:
                    return "مهر";
                case 8:
                    return "آبان";
                case 9:
                    return "آذر";
                case 10:
                    return "دی";
                case 11:
                    return "بهمن";
                case 12:
                    return "اسفند";
                default:
                    return null;

            }

        }
        public static string ToTime(this double time)
        {

            return ((time < 10) ? "0" + time + ":" + "00" : time + ":" + "00");
        }
        public static string ToRial(this double value)
        {
            return value.ToString("#,0 تومان");
        }
        public static string ToRial(this float value)
        {
            return value.ToString("#,0 تومان");
        }
        public static string ToRial(this int value)
        {
            return value.ToString("#,0 تومان");
        }

        public static DateTime? ShamsiToMiladi(this string ShamsiDate)
        {
            try
            {
                PersianCalendar Persian = new PersianCalendar();
                if (ShamsiDate.Substring(2, 1) == "/")
                {
                    int year1 = int.Parse(ShamsiDate.Substring(6, 4).ToEnglishNumber());
                    int month1 = int.Parse(ShamsiDate.Substring(0, 2).ToEnglishNumber());
                    int day1 = int.Parse(ShamsiDate.Substring(3, 2).ToEnglishNumber());
                    DateTime dt1 = Persian.ToDateTime(year1, month1, day1, 0, 0, 0, 0);
                    return dt1;
                }
                var y = ShamsiDate.Substring(0, 4).ToEnglishNumber();
                var m = ShamsiDate.Substring(5, 2).ToEnglishNumber();
                var d = ShamsiDate.Substring(8, 2).ToEnglishNumber();
                int year = int.Parse(ShamsiDate.Substring(0, 4).ToEnglishNumber());
                int month = int.Parse(ShamsiDate.Substring(5, 2).ToEnglishNumber());
                int day = int.Parse(ShamsiDate.Substring(8, 2).ToEnglishNumber());
                DateTime dt = Persian.ToDateTime(year, month, day, 0, 0, 0, 0);
                return dt;
            }
            catch (Exception e)
            {
                return null;
            }

        }
        public static string ToEnglishNumber(this string number)
        {
            return number.Replace("۱", "1").Replace("۲", "2").Replace("۳", "3")
                         .Replace("۴", "4").Replace("۵", "5").Replace("۶", "6")
                         .Replace("۷", "7").Replace("۸", "8").Replace("۹", "9")
                         .Replace("۰", "0").ToString();
        }

        public static string ToPersianNumber(this string number)
        {
            return number.Replace("1", "۱").Replace("2", "۲").Replace("3", "۳")
                         .Replace("4", "۴").Replace("5", "۵").Replace("6", "۶")
                         .Replace("7", "۷").Replace("8", "۸").Replace("9", "۹")
                         .Replace("0", "۰").ToString();
        }
        public static int GetPersianYear(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(value);
        }
        public static int GetPersianDay(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetDayOfMonth(value);
        }
        public static int GetPersianMonth(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetMonth(value);
        }
        public static string GetDateInfo()
        {
            var year = DateTime.Now.GetPersianYear();
            var month = DateTime.Now.GetPersianMonth();
            var day = DateTime.Now.GetPersianDay();
            var dayval = DateTime.Now.DayOfWeek.ToPersianDay();
            var monthval = month.ToPersianMonth();
            return dayval + " " + day.ToString().ToPersianNumber() + " " + monthval + " " + year.ToString().ToPersianNumber();

        }
        public static string ToShamsiDateTime(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(value) + "/" + pc.GetMonth(value).ToString("00") + "/" + pc.GetDayOfMonth(value).ToString("00") + " " + value.Hour + ":" + value.Minute + ":" + value.Second;
        }

        public static string GetStatusVal(this int value)
        {
            switch (value)
            {
                case 1: return "فعال";
                case 2: return "غیرفعال";
                case 3: return "حذف شده";
                default: return "";
            }
        }

        public static DateTime? ToMiladiDateTime(this string value)
        {
            try
            {
                PersianCalendar Persian = new PersianCalendar();
                var array = value.Split(' ');
                var strDate = array[0].Split('/');
                var time = array[1].Split(':');
                int year = int.Parse(strDate[0].ToEnglishNumber());
                int month = int.Parse(strDate[1].ToEnglishNumber());
                int day = int.Parse(strDate[2].ToEnglishNumber());
                int h = int.Parse(time[0].ToEnglishNumber());
                int m = int.Parse(time[1].ToEnglishNumber());
                int s = int.Parse(time[2].ToEnglishNumber());
                DateTime dt = Persian.ToDateTime(year, month, day, h, m, s,0);
                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static string KeyePersian(this string input)
        {
            return input.Replace("ي", "ی").Replace("ك", "ک");
        }
    }
}

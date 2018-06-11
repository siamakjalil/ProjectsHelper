using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
   public static class ZarinPal
    {
        public static string GetPaymentRequestStatusVal(this int status)
        {
            switch (status)
            {
                case -1:
                    return "اطلاعات ارسال شده ناقص است.";
                case -2:
                    return "و يا مرچنت كد پذيرنده صحيح نيست. IP";
                case -3:
                    return "با توجه به محدوديت هاي شاپرك امكان پرداخت با رقم درخواست شده ميسر نمي باشد";
                case -4:
                    return "سطح تاييد پذيرنده پايين تر از سطح نقره اي است.";
                case -11:
                    return "درخواست مورد نظر يافت نشد.";
                case -12:
                    return "امكان ويرايش درخواست ميسر نمي باشد.";
                case -21:
                    return "هيچ نوع عمليات مالي براي اين تراكنش يافت نشد.";
                case -22:
                    return "تراكنش نا موفق ميباشد.";
                case -33:
                    return "رقم تراكنش با رقم پرداخت شده مطابقت ندارد.";
                case -34:
                    return "سقف تقسيم تراكنش از لحاظ تعداد يا رقم عبور نموده است";
                case -40:
                    return "اجازه دسترسي به متد مربوطه وجود ندارد.";
                case -41:
                    return "غيرمعتبر ميباشد. AdditionalData اطلاعات ارسال شده مربوط به";
                case -42:
                    return "مدت زمان معتبر طول عمر شناسه پرداخت بايد بين 30 دقيه تا 45 روز مي باشد.";
                case -54:
                    return "درخواست مورد نظر آرشيو شده است.";
                case -100:
                    return "معمليات با موفقيت انجام گرديده است.";
                case -101:
                    return "تراكنش انجام شده است. PaymentVerification عمليات پرداخت موفق بوده و قبلا";
                    default: return "";
            }
        }
    }
}

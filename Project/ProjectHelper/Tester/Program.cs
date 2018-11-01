using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Parse("2018-05-21 15:05:05.097");
            Helper.ExtentionMethod.DayDifference("1397/07/01 10:22:20", 15);
        }
    }
}

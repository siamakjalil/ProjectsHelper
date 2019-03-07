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
            var date = DateTime.Now;
          var model=  Helper.ExtentionMethod.ToTime(date);
        }
    }
}

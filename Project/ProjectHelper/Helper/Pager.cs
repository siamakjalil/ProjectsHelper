using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helper
{
    //Developed by SIAMAK JALILI
    //www.Siamakjalili.com
    public static class Pager
    {
        public class Page
        {
            public int Skip { get; set; }
            public int PageCount { get; set; }
            public int Take { get; set; }
        }

        public static Page Paging(int pageId, int count)
        {
            var div = count / 10;
            var check = count - (div * 10);
            return new Page()
            {
                Skip = (pageId - 1) * 10,
                PageCount = (check == 0) ? div : div + 1,
                Take = 10
            };
           
           
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    //Developed by SIAMAK JALILI
    //www.Siamakjalili.com
    public static class HelperClass
    {
        public static List<IdTitle> StatusList()
        {
            return new List<IdTitle>() 
            {
                new IdTitle()
                {
                    Id = (int)Status.Active,
                    Title = ((int)Status.Active).GetStatusVal()
                },
                new IdTitle()
                {
                    Id = (int)Status.Deactive,
                    Title = ((int)Status.Deactive).GetStatusVal()
                }
            };
        }
        public static List<IdTitle> GenderList()
        {
            return new List<IdTitle>() 
            {
                new IdTitle()
                {
                    Id = (int)Gender.Male,
                    Title = ((int)Gender.Male).GetGenderVal()
                },
                new IdTitle()
                {
                    Id = (int)Gender.Female,
                    Title = ((int)Gender.Female).GetGenderVal()
                }
            };
        }

        public static List<IdTitle> NumberDropDown(int val)
        {
            var list = new List<IdTitle>();
            for (int i = 1; i <= val; i++)
            {
                list.Add(new IdTitle()
                {
                    Id = i,
                    Title = i.ToString()
                });
            }
            return list;
        }
    }
}

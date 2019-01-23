using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatDay
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("When is your Birthday?");
            String oDate = Console.ReadLine();
            DateTime nDate = DateTime.Parse(oDate);
            Console.WriteLine("You are born on a {0}", nDate.DayOfWeek);
            Console.Read(); 

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_TestS1
{
    class Program
    {
        static void Main(string[] args)
        {
            SharedLogging.Logger logger = new SharedLogging.Logger();
            logger.WriteToFile("D:\\test.log", "I'm testing local logging from Solution M1");

            Helper.SharedHelper helper = new Helper.SharedHelper();
            Console.WriteLine(helper.GetLength("hello"));
        }
    }
}

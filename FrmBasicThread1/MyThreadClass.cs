﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FrmBasicThread1
{

    internal class MyThreadClass
    {
        public static void Thread1()
        {

            for (int loopCount = 0; loopCount <= 2; loopCount ++)
            {

                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);
                Thread.Sleep(1000);
            }

        }
        public static void Thread2()
        {
            for (int loopCount = 0; loopCount <= 5; loopCount++)
            {

                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);
                Thread.Sleep(2000);
            }


        }


    }
}

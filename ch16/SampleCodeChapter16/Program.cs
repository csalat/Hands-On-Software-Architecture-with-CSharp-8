﻿using System;

namespace SampleCodeChapter16
{
    class Program
    {
        static void Main()
        {
            try
            {
                int variable = 10;

                if (variable == 10)
                {
                    Console.WriteLine("variable equals 10");
                }
                else
                {
                    switch (variable)
                    {
                        case 0:
                            Console.WriteLine("variable equals 0");
                            break;
                    }
                }
            }
            catch
            {

            }
        }
    }
}

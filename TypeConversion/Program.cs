﻿using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(number);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }
            
        }
    }
}

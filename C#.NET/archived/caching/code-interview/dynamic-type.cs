using System;
public class Program
    {
        public static void Main(string[] args)
        {
            byte num = 100;
            dynamic val = num;
            Console.WriteLine(val.GetType());
            val += 100;
            Console.WriteLine(val.GetType());
        }
    }
//System.Byte
//System.Int32

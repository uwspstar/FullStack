// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/

using System;
using System.Collections.Generic;
namespace TechBeamers
{
    delegate string del(string str);
    class sample
    {
        public static string DelegateSample(string a)
        {
            return a.Replace(',', '*');
        }
    }
    public class InterviewProgram
    {
        public static void Main(string[] args)
        {
            del str1 = new del(sample.DelegateSample);
            string str = str1("Welcome,,friends,,to,,TechBeamers");
            Console.WriteLine(str);
        }
    }
}

// Welcome**friends**to**TechBeamers

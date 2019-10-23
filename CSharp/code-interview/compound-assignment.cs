# compound assignment

bool test = true;
test &= false;
Console.WriteLine(test);  // output: False

test |= true;
Console.WriteLine(test);  // output: True

test ^= false;
Console.WriteLine(test);  // output: True


using System;
public class Program
{

    public static void Main(string[] args)
    {
        int num1 = 20;
        int num2 = 30;

        Console.WriteLine(num1 ^= num2); // 10
        Console.WriteLine(num2 ^= num1); // 20
        Console.WriteLine(num1 ^= num2); // 30
        Console.WriteLine(num1 + ","+ num2); //30, 20

        num1 ^= num2 ^= num1 ^= num2;
        Console.WriteLine(num1 + ","+ num2); //0, 30
    }
}

public static void Main(string[] args)
    {
        int x = 0;
        int y = 0;
 
        for (short z = 0; z < 3; z++)
        {
            if ((++x > 1) || (++y > 1))
            {
                x++;
            }
        }
        Console.WriteLine(x + "" + y);
}

// output is "51"

/*

Z: 0, 1, 2
x: 1, 3, 5
y: 1, 1, 1


1)  ++x i.e. pre-increment operator uses the principle ‘change-then-use’ 
while, x++ i.e. post-increment operator uses the principle ‘use-then-change’.

2) "||" if first is true , not run rest

3) int + string is string

*/

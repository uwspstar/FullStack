public static void Main(string[] args)
{
    int[] i = new int[0];
    
    Console.WriteLine(i[0]);
}

/*
Unhandled Exception:
System.IndexOutOfRangeException: Index was outside the bounds of the array.
  at Program.Main (System.String[] args) [0x00007] in <041d915e6e174053b4aceb06c0b6df00>:0
[ERROR] FATAL UNHANDLED EXCEPTION: System.IndexOutOfRangeException: Index was outside the bounds of the array.
  at Program.Main (System.String[] args) [0x00007] in <041d915e6e174053b4aceb06c0b6df00>:0
exit status 1
*/

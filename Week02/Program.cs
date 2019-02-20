using System;

namespace Week02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create variables and do things with them!
            int i = 1;
            Convert.ToInt64(i);
            while (i <= 1000000000 || i >= 1000000000){
                
                System.Console.WriteLine("$"+ i++);
            }
        }
    }
}

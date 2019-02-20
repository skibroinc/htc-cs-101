using System;  
public class Exercise8  
{  
        public static void Main()
    {
        System.Console.WriteLine("make sure that the numbers are not the same");
        int num1;
        System.Console.WriteLine("type a num : ");
        num1 = Convert.ToInt32(Console.ReadLine());
        int num2;
        System.Console.WriteLine("type a num : ");
        num2 = Convert.ToInt32(Console.ReadLine());
        int num3;
        System.Console.WriteLine("type a num : ");
        num3 = Convert.ToInt32(Console.ReadLine());
        if(num1 > num2 && num1 > num3){
            System.Console.WriteLine("the num are placed in order");
            System.Console.WriteLine(num1 + "-" + num2 + "-" + num3);
        }
        else if(num1 < num2 && num1 > num3){
            System.Console.WriteLine(num2 + "-" + num1 + "-" + num3);
        }
        else if(num1 > num2 && num1 > num3 && num2 > num3){
            System.Console.WriteLine(num2 + "-" + num3 + "-" + num1);
        }
        else if(num1 > num2 && num1 > num3 && num3 > num2){
            System.Console.WriteLine(num3 + "-" + num2 + "-" + num1);
        }
    }
}

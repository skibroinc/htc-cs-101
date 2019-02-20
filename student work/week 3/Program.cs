using System;

namespace week_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whomesta grade r u in?!?!?!?!?!!?!??!??!??!?");
            uint studentgrade = Convert.ToUInt32(Console.ReadLine());

            if(studentgrade <= 5){
                System.Console.WriteLine("U r a puney elementary schooler");
            }
            else if(studentgrade < 9){
                System.Console.WriteLine("U r a weird middle schooner");
            }
            else if(studentgrade == 9){
                System.Console.WriteLine("U r a freshie");
            }
            else if(studentgrade == 10){
                System.Console.WriteLine("U r a sophie");
            }
            else if(studentgrade == 11){
                System.Console.WriteLine("U r a junior mint");
            }
            else if(studentgrade == 12){
                System.Console.WriteLine("U r a seinor sedison");
            }
            else{
                System.Console.WriteLine("U r an idiot");
            }
        }
    }
}

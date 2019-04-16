using System;

namespace week10
{
    class Program
    {
        static bool win = true;
        static void Main(string[] args)
        {
            System.Console.WriteLine("please type in EXACTLY what I type as the choices!!!!!!!!!!!!!!!!!!!!!!!");
            int killCount = 0;
            int money = 0;
         while(win){
            System.Console.WriteLine("the obj is to live past 100");
            System.Console.WriteLine("Choose your gender \n man \n woman \n attack helicopter \n or \n whamen");
           string gender = Console.ReadLine();
           if(gender == "time to respek whamen"){
               System.Console.WriteLine("you win");
               win = false;
               break;
           }
           System.Console.WriteLine("what is your name?");
           string playername = Console.ReadLine();
           if(playername == "Ethan"){
                die();
                break;
            }
           System.Console.WriteLine("you will be living at \n28500 Clemens Rd Westlake OH, 44145 USA");
            System.Console.WriteLine("you are now 1 year old \nwhat do you want to do");
            System.Console.WriteLine("speak, crawl on coutch, do the high jump at peterson pool?");
            string year1 = Console.ReadLine();
            if(year1 == "speak"){
                System.Console.WriteLine("your pairents will question you");
            }
            else if(year1 == "crawl on couch"){
                System.Console.WriteLine("you have crawled on the couch");
            }
            else if(year1 == "do the high jump at peterson pool"){
                die();
                break;
            }
            else{
                die();
                break;
            }
            System.Console.WriteLine("you are now 2 years old \nnothing happens");
            System.Console.WriteLine("you are now 3 years old \nyour dog spock dies at the age of 8 \nhe was run over by the millennium falcon");
            System.Console.WriteLine("you are now 4 years old");
            System.Console.WriteLine("you are pushed on the play ground what do u do");
            System.Console.WriteLine("push back, cry to mom, or nothing");
            string year4 = Console.ReadLine();
            if(year4 == "push back"){
                System.Console.WriteLine("you have killed the todler because his head fell on a knife sticking out of the ground and his mom reeeeeee on your mom \n but your mom backhands his mom \n your mom is now your role model");
                killCount = killCount + 1;
            }
            else if(year4 == "cry to mom"){
                System.Console.WriteLine("your mom comforts you");
            }
            else if(year4 == "nothing"){
                System.Console.WriteLine("you are laughed at");
            }
            else{
                die();
                break;
            }
            System.Console.WriteLine("you are now 5 years old\nnothing happens");
            System.Console.WriteLine("you are now 6 years old\nnothing happens");
            System.Console.WriteLine("you are now 7 years old\nyou are being bullied because you have fallen in poop");
            System.Console.WriteLine("what do you do?\nlaugh with them, cry, kill him with school spoon, or nothing");
            string year7 = Console.ReadLine();
            if(year7 == "laugh with them"){
                System.Console.WriteLine("they are confused");
            }
            else if(year7 == "cry"){
                System.Console.WriteLine("they continue to bully you");
            }
            else if(year7 == "kill him with a school spoon"){
                System.Console.WriteLine("you are now feared\n on the plus side they will never bully you again");
                killCount = killCount + 1;
            }
            else if(year7 == "nothing"){
                System.Console.WriteLine("they question your existance");
            }
            else{
                die();
                break;
            }
            System.Console.WriteLine("you are now 8 years old\nnothing happens");
            System.Console.WriteLine("yor are now 9 years old\nyou are asked to be in a school play by your teatcher");
            System.Console.WriteLine("what do you do?\n say yes, say ok, say no, don't answer, or rage");
            string year9 = Console.ReadLine();
            if(year9 == "say yes"){
                System.Console.WriteLine("you are now in the school play");
            }
            else if(year9 == "say ok"){
                System.Console.WriteLine("you are now in the school play \nbut you teatcher thinks that u don't want to be in it");
            }
            else if(year9 == "say no"){
                System.Console.WriteLine("you are not in the school play");
            }
            else if(year9 == "don't answer"){
                System.Console.WriteLine("the teatcher asks again");
                while(year9 == "don't answer"){
                    System.Console.WriteLine("what do you do?\n say yes, say ok, say no, don't answer, or rage");
                    year9 = Console.ReadLine();
                }
            }
            else{
                die();
                break;
            }
            System.Console.WriteLine("you are now 10 years old\nyou are given $10 for turning 10");
            money = money + 10;
            }
            System.Console.WriteLine("you are now 11 years old\nnothing happens");
            System.Console.WriteLine("you are now 12 years old\nnothing happens");
            System.Console.WriteLine("you are now 13 years old\nnothing happens");
            System.Console.WriteLine("you are now 14 years old\nyou have entred high school");
            System.Console.WriteLine("you are offred a juul\nwhat do you do");
            System.Console.WriteLine("take the offer, decline, run");
            string year14 = Console.ReadLine();
            if(year14 == "take the offer"){
                System.Console.WriteLine("you are cought in the bathroom by a teatcher");
                die();
                break;
            }
            else if(year14 == "decline"){
                System.Console.WriteLine("the kid understands");
            }
            else if(year14 == "run"){
                System.Console.WriteLine("the kid chaces you down\n the kid asks you why you ran");
                System.Console.WriteLine("your choices are because i was scared or i was going to tell the teacher");
                string year14a = Console.ReadLine();
                if(year14a == "i was scared"){
                    System.Console.WriteLine("the kid understands");
                }
                else if(year14a == "i was going to tell the teacher"){
                    System.Console.WriteLine("the kid...");
                    die();
                    break;
                }
                else{
                    die();
                    break;
                }
            }
            System.Console.WriteLine("you are now 15 years old\nyou are offered to get a temps");
            System.Console.WriteLine("yes or no");
            string year15 = Console.ReadLine();
            if(year15 == "yes"){
                System.Console.WriteLine("you are asked a question");
            }
            else if(year15 == "no"){
                System.Console.WriteLine("you don't take your temps");
            }
        }
        public static void die(){
            System.Console.WriteLine("you die");
            win = false;
        }
    }
}

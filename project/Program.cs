using System;

namespace week10
{
    class Program
    {
        static bool win = true;
        static bool driversLicens = false;
        static bool jobans = false;
        static int money = 0;
        static void Main(string[] args)
        {
            System.Console.WriteLine("please type in EXACTLY what I type as the choices!!!!!!!!!!!!!!!!!!!!!!!");
            int killCount = 0;
         while(win){
            System.Console.WriteLine("the obj is to live past 100");
            System.Console.WriteLine("Choose your gender \n man \n woman \n attack helicopter \n or \n whamen");
           string gender = Console.ReadLine();
           if(gender == "time to respek whamen"){
               System.Console.WriteLine("you win");
               win = false;
           }
           System.Console.WriteLine("what is your name?");
           string playername = Console.ReadLine();
           if(playername == "Ethan"){
                die();
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
            }
            else{
                die();
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
            else if(year9 == "rage"){
                System.Console.WriteLine("you kill the teatcher");
                killCount = killCount + 1;
            }
            else{
                die();
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
                }
                else{
                    die();
                }
            }
            System.Console.WriteLine("you are now 15 years old\nyou are offered to get a temps");
            driversTest();
            System.Console.WriteLine("you are now 16 years old\nyou are offred to play poker\nwhat do you do");
            System.Console.WriteLine("play or don't play");
            string year16 = Console.ReadLine();
            if(year16 == "play"){
                System.Console.WriteLine("you loose all of your money gambeling");
                money = 0;
            }
            else if(year16 == "don't play"){
                System.Console.WriteLine("you saved yourself a lot of money!");
            }
            driversTest();
            System.Console.WriteLine("you are now 17 years old\nnothing happens");
            driversTest();
            System.Console.WriteLine("you are now 18 years old\nyou graduated high school\nyou can also vote");
            driversTest();
            System.Console.WriteLine("do you want a job?\ntheir is no college");
            string jobanss = Console.ReadLine();
            if(jobanss == "yes"){
                System.Console.WriteLine("which job do you want?");
                System.Console.WriteLine("painter, engineer, computer programmer, researcher, or apple pie");
                string year18 = Console.ReadLine();
                if(year18 == "painter"){
                    System.Console.WriteLine("your job is painting\n you paint an apple and sell it for $1000000");
                    money = money + 1000000;
                }
                else if(year18 == "engineer"){
                    System.Console.WriteLine("you now work for apple making the next iphone");
                }
                else if(year18 == "computer programmer"){
                    System.Console.WriteLine("you win");
                }
                else if(year18 == "researcher"){
                    System.Console.WriteLine("you research the big bang at cal tech");
                }
                else if(year18 == "apple pie"){
                    System.Console.WriteLine("you are weird");
                    die();
                }
                else{
                    die();
                }
                jobans = true;
            }
            else if(jobanss == "no"){
                System.Console.WriteLine("that sucks\nseems like you are going to live in your mothers basement for the rest of your life");
            }
            else{
                die();
            }
            System.Console.WriteLine("you are now 19 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are asked to go on a vacation with your friends\nwould you go");
            System.Console.WriteLine("yes,no");
            string year19 = Convert.ToString(Console.ReadLine());
            if(year19 == "yes"){
                System.Console.WriteLine("you are going to the grand caynon and white water rafting for 2 days");
                System.Console.WriteLine("the cost is $720 for the white water rafting with the room");
                System.Console.WriteLine("and 350 for the flight");
                money = money - 1070;
            }
            else if(year19 == "no"){
                System.Console.WriteLine("your friends are bumbed");
            }
            else{
                die();
            }
            System.Console.WriteLine("you are now 20 years old");
            driversTest();
            income();
            System.Console.WriteLine("you meet a person from another gender\ndo you go out on a date with him or her");
            System.Console.WriteLine("yes or no");
            string year20 = Convert.ToString(Console.ReadLine());
            if(year20 == "yes"){
                System.Console.WriteLine("you guys hit it off\ndo you want to merry her?");
                System.Console.WriteLine("yes or no");
                string year20a = Convert.ToString(Console.ReadLine());
                if(year20a == "yes"){
                    System.Console.WriteLine("it agrees");
                }
                else if(year20a == "no"){
                    System.Console.WriteLine("you guys break up and that was  your only chance at love");
                }
                else{
                    die();
                }
            }
            else if(year20 == "no"){
                System.Console.WriteLine("too bad that was your only chance.");
            }
            else{
                die();
            }
            System.Console.WriteLine("you are now 21 years old");
            System.Console.WriteLine("you can now drink!!");
            driversTest();
            income();
            System.Console.WriteLine("you are now 22 years old");
            driversTest();
            income();
            System.Console.WriteLine("your friends ask you to go to calarado to go snowboarding");
            System.Console.WriteLine("yes or no");
            string year22 = Console.ReadLine();
            if(year22 == "yes"){
                System.Console.WriteLine("you have a blast snowboarding");
                System.Console.WriteLine("cost you $1000");
                money = money - 1000;
            }
            else if( year22 == "no"){
                System.Console.WriteLine("your friends question you");
            }
            else{
                die();
            }
            System.Console.WriteLine("you are now 23 years old");
            driversTest();
            income();
            System.Console.WriteLine("you ask your boss for a raise");
            System.Console.WriteLine("you are now 24 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 25 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 26 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 27 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 28 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 29 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 30 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 31 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 32 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 33 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 34 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 35 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 36 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 37 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 38 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 39 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 40 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 41 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 42 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 43 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 44 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 45 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 46 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 47 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 48 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 49 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 50 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 51 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 52 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 53 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 54 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 55 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 56 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 57 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 58 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 59 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 60 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 61 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 62 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 63 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 64 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 65 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 66 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 67 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 68 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 69 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 70 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 71 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 72 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 73 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 74 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 75 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 76 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 77 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 78 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 79 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 80 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 81 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 82 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 83 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 84 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 85 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 86 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 87 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 88 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 89 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 90 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 91 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 92 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 93 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 94 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 95 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 96 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 97 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 98 years old");
            driversTest();
            income();
            System.Console.WriteLine("you are now 99 years old");
            driversTest();
            income();
            Random testTemp = new Random();
            int asdf = testTemp.Next(1,11);            
                if(asdf ==  1){
                    System.Console.WriteLine("you die boi");
                    die();
                }
                else if(asdf == 2){
                    System.Console.WriteLine("you die boi");
                    die();
                }
                else if(asdf == 3){
                    System.Console.WriteLine("you die boi");
                    die();
                }
                else if(asdf == 4){
                    System.Console.WriteLine("you die boi");
                    die();
                }
                else if(asdf == 5){
                    System.Console.WriteLine("you die boi");
                    die();
                }
                else if(asdf == 6){
                    System.Console.WriteLine("you die boi");
                    die();
                }
                else if(asdf == 7){
                    System.Console.WriteLine("you die boi");
                    die();
                }
                else if(asdf == 8){
                    System.Console.WriteLine("you die boi");
                    die();
                }
                else if(asdf == 9){
                    System.Console.WriteLine("you die boi");
                    die();
                }
                else if(asdf == 10){
                    System.Console.WriteLine("you are almost there");
                }
            System.Console.WriteLine("you are 1 day till 100 years old");
            System.Console.WriteLine("while out to buy a birthday cake\nand you slip and fall on a banana and die");
            die();
            System.Console.WriteLine("you are now 100 years old");
            System.Console.WriteLine("you win");
        }
        public static void die(){
            System.Console.WriteLine("you die");
            win = false;
            
        }
        public static void income(){
            if(jobans = true){
                money = money + 44564;
            }
        }
        public static void driversTest(){
            if(driversLicens == false){
                System.Console.WriteLine("you are offred to get a drivers licens\nwill u accept\nyes or no");
                string ans = Console.ReadLine();
                if(ans == "yes"){
                    Random rnd = new Random();
                    int num  = rnd.Next(1, 13);
                    if(num == 1){
                        System.Console.WriteLine("you are asked a question");
                        System.Console.WriteLine("can you turn left from a one way street on to another one way street when the light is green?\n yes/no question");
                        string year15a = Console.ReadLine();
                        if(year15a == "yes"){
                            System.Console.WriteLine("you passed");
                            driversLicens = true;
                        }
                        else if(year15a == "no"){
                            System.Console.WriteLine("you fail");
                        }
                        else{
                            die();
                        }
                    }
                    if(num == 2){
                        System.Console.WriteLine("when 2 cars reach an intrection who was the right away\nit is a 4 way stopsign and the car is to your left");
                        System.Console.WriteLine("the car on the left or the right");
                        string num2 = Console.ReadLine();
                        if(num2 == "left"){
                            System.Console.WriteLine("wrong\nyou don't have your licens");
                        }
                        else if(num2 == "right"){
                            System.Console.WriteLine("correct\nyou passed");
                            driversLicens = true;
                        }
                        else{
                            die();
                        }
                    }
                    if(num == 3){
                        System.Console.WriteLine("how old do you have to be to get a temps in Ohio");
                        System.Console.WriteLine("a:16 years\nb:14 years\nc:15.5 years\nd:14.5 years\nor\ne:15 years");
                        string num3 = Console.ReadLine();
                        if(num3 == "c"){
                            System.Console.WriteLine("correct");
                            driversLicens = true;
                        }
                        else if(num3 == "a" || num3 == "b" || num3 == "d" || num3 == "e"){
                            System.Console.WriteLine("you fail");
                        }
                        else{
                            die();
                        }
                    }
                    if(num == 4){
                        System.Console.WriteLine("In a school zone, the speed limit when children are going to or leaving school is?");
                        System.Console.WriteLine("15,20,25, or 10");
                        string num4 = Convert.ToString(Console.ReadLine());
                        if(num4 == "15"){
                            System.Console.WriteLine("incorrect");
                        }
                        else if(num4 == "20"){
                            System.Console.WriteLine("correct");
                            driversLicens = true;
                        }
                        else if(num4  == "25"){
                            System.Console.WriteLine("incorrect");
                        }
                        else if(num4 == "10"){
                            System.Console.WriteLine("incorrect");
                        }
                        else{
                            die();
                        }
                    }
                    if(num == 5){
                        System.Console.WriteLine("Within a city or town, the speed limit in alleys is?");
                        System.Console.WriteLine("15,25,30,40");
                        string num5 = Convert.ToString(Console.ReadLine());
                        if(num5 == "15"){
                            System.Console.WriteLine("correct");
                            driversLicens = true;
                        }
                        else if(num5 == "25"){
                            System.Console.WriteLine("incorrect");
                        }
                        else if(num5 == "30"){
                            System.Console.WriteLine("incorrect");
                        }
                        else if(num5 == "40"){
                            System.Console.WriteLine("incorrect");
                        }
                        else{
                            die();
                        }
                    }
                    if(num == 6){
                        System.Console.WriteLine("You must use your headlights whenever you can't see objects __________ ahead clearly.");
                        System.Console.WriteLine("3000ft,4000ft,1000ft,2000ft");
                        string num6 = Convert.ToString(Console.ReadLine());
                        if(num6 == "3000ft"){
                            System.Console.WriteLine("incorrect");
                        }
                        else if(num6 == "4000ft"){
                            System.Console.WriteLine("incorrect");
                        }
                        else if(num6 == "1000ft"){
                            System.Console.WriteLine("correct");
                            driversLicens = true;
                        }
                        else if(num6 == "2000ft"){
                            System.Console.WriteLine("incorrect");
                        }
                        else{
                            die();
                        }
                    }
                    if(num == 7){
                        System.Console.WriteLine("On a one-way street, you may park your vehicle parallel to and not more than__________ from the right or left curb.");
                        System.Console.WriteLine("15in,12in,24in,18in");
                        string num7 = Convert.ToString(Console.ReadLine());
                        if(num7 == "15in"){
                            System.Console.WriteLine("incorrect");
                        }
                        else if(num7 == "12in"){
                            System.Console.WriteLine("correct");
                            driversLicens = true;
                        }
                        else if(num7 == "24in"){
                            System.Console.WriteLine("incorrect");
                        }
                        else if(num7 == "18in"){
                            System.Console.WriteLine("incorrect");
                        }
                        else{
                            die();
                        }
                    }
                    if(num == 8){
                        System.Console.WriteLine("What must you do at a flashing yellow traffic signal?");
                        System.Console.WriteLine("yeild,speed up,slow down, or stop");
                        string num8 = Convert.ToString(Console.ReadLine());
                        if(num8 == "yeild"){
                            System.Console.WriteLine("incorrect");
                        }
                        else if(num8 == "speed up"){
                            System.Console.WriteLine("incorrect");
                        }
                        else if(num8 == "slow down"){
                            System.Console.WriteLine("correct");
                            driversLicens = true;
                        }
                        else if(num8 == "stop"){
                            System.Console.WriteLine("incorrect");
                        }
                        else{
                            die();
                        }
                    }
                    if(num == 9){
                        System.Console.WriteLine("It is illegal to drive with a blood alcohol concentration (BAC) of _______ or higher.");
                        System.Console.WriteLine("0.10%,0.12%,0.08%,0.06%");
                        string num9 = Convert.ToString(Console.ReadLine());
                        if(num9 == "0,10%"){
                            System.Console.WriteLine("incorrect");
                        }
                        else if(num9 == "0.12%"){
                            System.Console.WriteLine("incorrect");
                        }
                        else if(num9 == "0.08%"){
                            System.Console.WriteLine("correct");
                            driversLicens = true;
                        }
                        else if(num9 == "0.06%"){
                            System.Console.WriteLine("incorrect");
                        }
                        else{
                            die();
                        }
                    }
                    if(num == 10){
                        System.Console.WriteLine("To maintain a safe following distance behind the vehicle ahead of you, use?");
                        System.Console.WriteLine("the four second rule, the three second rule, the two second rule, or the five second rule");
                        string num10 = Convert.ToString(Console.ReadLine());
                        if(num10 == "the four second rule"){
                            System.Console.WriteLine("incorrect");
                        }
                        else if(num10 == "the three second rule"){
                            System.Console.WriteLine("correct");
                            driversLicens = true;
                        }
                        else if(num10 == "the two second rule"){
                            System.Console.WriteLine("incorrect");
                        }
                        else if(num10 == "the five second rule"){
                            System.Console.WriteLine("incorrect");
                        }
                        else{
                            die();
                        }
                    }
                    if(num == 11){
                        System.Console.WriteLine("If your vehicle stalls on railroad tracks when a train is approaching, what should you do?");
                        System.Console.WriteLine("try to restart your vehicle,turn on your flashers to try to warn the train,call 911 and wait for assistance, or get everyone out of the vehicle");
                        string num11 = Convert.ToString(Console.ReadLine());
                        if(num11 == "try to restart your vehicle"){
                            System.Console.WriteLine("incorrect");
                        }
                        else if(num11 == "turn on your flashers to try to warn the train"){
                            System.Console.WriteLine("incorrect");
                        }
                        else if(num11 == "call 911 and wait for assistance"){
                            System.Console.WriteLine("incorrect");
                        }
                        else if(num11 == "get everyone out of the vehicle"){
                            System.Console.WriteLine("correct");
                            driversLicens = true;
                        }
                        else{
                            die();
                        }
                    }
                    if(num == 12){
                        System.Console.WriteLine("If you want to make a turn, you must start to signal at least ________ before you turn.");
                        System.Console.WriteLine("50,70,80,100");
                        string num12 = Convert.ToString(Console.ReadLine());
                        if(num12 == "50"){
                            System.Console.WriteLine("incorrect");
                        }
                        else if(num12 == "70"){
                            System.Console.WriteLine("incorrect");
                        }
                        else if(num12 == "80"){
                            System.Console.WriteLine("incorrect");
                        }
                        else if(num12 == "100"){
                            System.Console.WriteLine("correct");
                            driversLicens = true;
                        }
                        else{
                            die();
                        }
                    }
                }
                else if(ans == "no"){
                    System.Console.WriteLine("ok");
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2deliverableFunPlaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            double select1, select2;
            Console.WriteLine("Please tell me your name.");
            userName = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Hello " + userName + " what are you in the mood for?");
            Console.WriteLine("Please select the number of your choice from this list:");
            Console.WriteLine("");
            Console.WriteLine("1. Action");
            Console.WriteLine("2. Chill");
            Console.WriteLine("3. Danger");
            Console.WriteLine("4. Food");
            select1 = Convert.ToDouble(Console.ReadLine());


            switch (select1)
            {
                case 1:
                    Console.WriteLine("Aaaaaand ACTION!!");
                    Console.WriteLine("You should go Stock Car Racing!");
                    break;

                case 2:
                    Console.WriteLine("Lets' Chill");
                    Console.WriteLine("You should go hiking.");
                    break;

                case 3:
                    Console.WriteLine("DANGER Will Robinson!");
                    Console.WriteLine("You should go skydiving!");
                    break;

                case 4:
                    Console.WriteLine("I see...");
                    Console.WriteLine("You should go to Taco Bell.");
                    break;
                default:
                    Console.WriteLine("Does not compute, please try again");
                    break;
            }      

                                                                                          
                    Console.WriteLine(" ");
                    Console.WriteLine("And how many people excluding yourself are going?");
                    Console.WriteLine("Please enter the number of your choice from this list:");
                    Console.WriteLine(" ");
                    Console.WriteLine(" 1. 0");
                    Console.WriteLine("2. 1-4");
                    Console.WriteLine("3. 5-10");
                    Console.WriteLine("4. 11+");

                    select2 = Convert.ToDouble(Console.ReadLine());

                    switch (select2)
                    {
                        case 1:

                            Console.WriteLine("Well you should also go via sneakers, aka, walking there.");
                            break;

                        case 2:
                            Console.WriteLine("You could also go via sedan, or maybe a Jeep!");
                            break;

                        case 3:
                            Console.WriteLine("You should also definitely take a Volkswagen bus, not a clown car.");
                            break;

                        case 4:
                            Console.WriteLine("You should also take an airplane, you baller.");
                            break;

                        default:
                            Console.WriteLine("Does not compute, please try again");
                            break;




                    }
                    Console.WriteLine("");
                    Console.WriteLine("So long, farewell, Auf Wiedersehen, goodbye!  And have a great time!");
                    Console.ReadKey();
            }
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karl_axels_cmd_adventure
{
    class Program
    {
        static Boolean gameover;
        static Boolean gamecomplete;
        static Boolean harYxa;
        static Boolean träd;
        static Boolean ljus;
        static string input;
        static void Main(string[] args)
        {
            while (true)
            {
                gamecomplete = false;
                gameover = false;
                harYxa = false;

                Console.WriteLine("---Välkommen till Panda försvunna äventyr---");
                Console.WriteLine("\nDu vaknar upp i en jungle. Det enda som finns är träd och ett temple bakom träden. Det ligger en yxa på marken");
                skog();
                if (gameover)
                    Console.WriteLine("\nDu förlorade!!! Vill du spela igen? y/n");
                else
                    Console.WriteLine("\nDu vann!!! Vill du spela igen? y/n");
                input = Console.ReadLine();
                if (input == "n" || input == "no" || input == "nej")
                {
                    Console.WriteLine("Spelet stängs av...");
                    break;
                }
                Console.WriteLine("Spelet startas om...");
                Console.ReadLine();
            }
        }


        private static void skog()
        {
            while (true)
            {
                Console.Write("\n>");
                input = Console.ReadLine();

                if (input == "träd" || input == "gå fram" || input == "gå fram till träd")
                {
                    if (harYxa)
                    {
                        Console.WriteLine("hugga ner träden");
                        träd = true;
                    }
                    else
                        Console.WriteLine("Träden i vägen");
                }
                //test//
                else if (input == "gå fram" || input == "gå" || input == "gå fram till tempel")
                {

                    if (träd)
                    {
                        Console.WriteLine("du gick fram till tempeln");
                        break;
                    }
                    else
                        Console.WriteLine("Träden i vägen");
                }
                //test//
                else if (input == "plocka upp yxa" || input == "ta yxan")
                {
                    Console.WriteLine("Du tog upp yxan använd den för att hugga ner träden");
                    harYxa = true;
                }
                else
                    Console.WriteLine("Icke gilltigt eller felstavat commando!");


            }
            tempel();
        }

        private static void tempel()
        {
            while (true)
            {
                Console.WriteLine("du är i templet och det är mörkt");
                Console.Write("\n");
                input = Console.ReadLine();
                if (input == "gå fram")
                    ljus = false;
                {
                    if (input == "ta fakla")
                    {
                        ljus = true;
                    }


                    if (ljus)
                    {
                        Console.WriteLine("du kan gå vidare");
                    }
                    else
                    {
                        Console.WriteLine("Det är för mörkt, försök att hitta någon fakla ");
                    }

                }
            }
        }
    }
}



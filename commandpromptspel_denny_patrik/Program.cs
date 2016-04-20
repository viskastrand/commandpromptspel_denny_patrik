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
        static string input;
        static void Main(string[] args)
        {
            Boolean harYxa = false;
            Boolean träd = false;
            string input;


            Console.WriteLine("---Välkommen till Panda försvunna äventyr---");
            Console.WriteLine("\nDu vaknar upp i en jungle. Det enda som finns är träd och ett temple bakom träden. Det ligger en yxa på marken");

            while (true) //oändlig loop
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
                    {
                        
                    }
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

            }
        }
    }
}



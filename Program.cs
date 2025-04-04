using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LexiconEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meny();
        }
        private const string item1 = "1";
        private const string item2 = "2";
        private const string item3 = "3";
        private const string item0 = "0";

        private static void Meny()
        {
            bool run = true;
            string input;
            Console.WriteLine("Wälkomen till menyn.");

            while (run) {
                Console.WriteLine("Skriv " + item1 + " för att köpa bio biljet.\nSkriv " + item2 + " för eco.\nSkriv " + item3 + " för tredje ordet i mening.\nSkriv " + item0 + " för att avsluta.");
                try
                {
                    input = Console.ReadLine();
                }
                catch
                {
                    Fell();
                    continue;
                }
                switch (input)
                {
                    case item1:
                        Bio();
                        break;
                    case item2:
                        break;
                    case item3:
                        break;
                    case item0:
                        run = false;
                        break;
                    default:
                        Fell();
                        break;
                }
            }
        }
        private static void Fell() {
            Console.WriteLine("Fell input.");
        }
        private static void Bio()
        {
            
            
            Console.Write("Hur många personer är i erat selskap?: ");

            uint number=HowMenyPeople();
            uint[] ages=WhatAreTheAges(number);




            int summe = 0;
            foreach (uint i in ages) {

                if (i > 100 || i < 5)
                {

                }
                else if (i < 20)
                {
                    summe += 80;
                }
                else if (i > 64)
                {
                    summe += 90;
                }
                else {
                    summe += 120;
                }
            }

            Console.WriteLine("Slut summan är " + summe + "kr");

        }
        private static uint HowMenyPeople(){
            Console.Write("Hur många personer är i erat selskap?: ");
            while (true)
            {
                try
                {
                   uint number = uint.Parse(Console.ReadLine());
                    
                    if (number > 0) return number;
                    Fell();
                }
                catch
                {
                    Fell();
                }
            }
        }
        private static uint[] WhatAreTheAges( uint number) {
            uint[] ages= new uint[number];
            for (int i = 0; i < number; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Hur gammal är perskonen" + ((number > 1) ? " nummer " + (i + 1) : "") + " i selskapet?: ");
                        ages[i] = uint.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {

                        Fell();
                    }

                }

            }
            return ages;
        }
        private static void FinalSumme( uint[] ages)
        {
            int summe = 0;
            foreach (uint i in ages)
            {

                if (i > 100 || i < 5)
                {

                }
                else if (i < 20)
                {
                    summe += 80;
                }
                else if (i > 64)
                {
                    summe += 90;
                }
                else
                {
                    summe += 120;
                }
            }

            Console.WriteLine("Slut summan är " + summe + "kr");
        }
    }
}

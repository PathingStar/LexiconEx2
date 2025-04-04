namespace LexiconEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meny();
        }
        private const string item1="1";
        private const string item2="2";
        private const string item3="3"; 
        private const string item0="0";
       
        private static void Meny()
        {
            bool run = true;
            string input;
            Console.WriteLine("Wälkomen till menyn.");

                while (run) { 
                    Console.WriteLine("Skriv "+ item1+" för att köpa bio biljet.\nSkriv " + item2+ " för eco.\nSkriv " + item3+ " för tredje ordet i mening.\nSkriv "+item0+" för att avsluta.");
                    try
                    {
                        input = Console.ReadLine();
                    }
                    catch
                    {
                        Console.WriteLine("Fell input");
                        continue;
                    }
                    switch (input)
                    {
                        case item1:
                            break;
                        case item2:
                             break;
                        case item3:
                            break;
                        case item0:
                            run = false;
                            break;
                        default:
                            Console.WriteLine("Fell input");
                            break;
                    }
            }
        }
    }
}

namespace ReferenceAndClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant Lucek = new Elephant( "Lucek",100);
            Elephant Laura = new Elephant("Laura",80);
            while (true)
            {
                Console.WriteLine("Wcisnij 1 (Lucek) Wcisnij 2 (Laura) Wcisnij 3 (prezstawienie)");
                char presedKey = Console.ReadKey(true).KeyChar;
                Console.WriteLine("Wcisnoles przycisk: " +  presedKey);
                if (presedKey == '1')
                {
                    Console.WriteLine("Wywolanie Lucek.WhoAmI");
                    Lucek.WhoAmI();
                }
                else if(presedKey == '2')
                {
                    Console.WriteLine("Wywolanie Laura.WhoAmI");
                    Laura.WhoAmI();
                }
                else if(presedKey == '3')
                {
                    Elephant teporary = Lucek;
                    Laura = Lucek;
                    Lucek = teporary;
                    Console.WriteLine("Referencje zostaly przestawione");
                }

                Console.WriteLine("Wcisnij K aby kontynulowac lub inny klawisz aby zakonczyć");
                presedKey = Console.ReadKey(true).KeyChar;
                if (presedKey == 'K' || presedKey == 'k') { }
                else return;


            }
        }
    }
}
namespace MyLittlePlant
{
    using System;
    using Collections.Adidas;
    using Collections.Nike;
    using Collections.Puma;
    using Collections.Reebok;
    using Plant;

    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to a small clothing factory !!!");

            Console.WriteLine(new string('-', 15));

            while (true)
            {
                Console.WriteLine("Select brand:");

                ConsoleColor color = Console.ForegroundColor;

                Console.ForegroundColor = ConsoleColor.DarkGreen;

                Console.WriteLine("1. Adidas \t 2. Nike \t 3. Puma \t 4. Reebok");

                Console.WriteLine("Check, please:");

                Console.ForegroundColor = color;

                int command = Convert.ToInt32(Console.ReadLine());

                switch (command)
                {
                    case 1:
                        AdidasColl();
                        break;
                    case 2:
                        NikeColl();
                        break;
                    case 3:
                        PumaColl();
                        break;
                    case 4:
                        ReebokColl();
                        break;
                    default:
                        continue;
                }
            }
        }

        private static void AdidasColl()
        {
            foreach (string adk in AdidasBase.Model())
            {
                Console.WriteLine(adk);
            }

            Iproducts factory = new Adidas();

            Console.WriteLine(factory.GetNew().NameCollection() + factory.GetSale().NameCollection());
        }

        private static void NikeColl()
        {
            foreach (string nk in NikeBase.Model())
            {
                Console.WriteLine(nk);
            }

            Iproducts factory = new Nike();

            Console.WriteLine(factory.GetNew().NameCollection() + factory.GetSale().NameCollection());
        }

        private static void ReebokColl()
        {
            foreach (string rbk in ReebokBase.Model())
            {
                Console.WriteLine(rbk);
            }

            Iproducts factory = new Reebok();

            Console.WriteLine(factory.GetNew().NameCollection() + factory.GetSale().NameCollection());
        }

        private static void PumaColl()
        {
            foreach (string pm in PumaBase.Model())
            {
                Console.WriteLine(pm);
            }

            Iproducts factory = new Puma();

            Console.WriteLine(factory.GetNew().NameCollection() + factory.GetSale().NameCollection());
        }
    }
}

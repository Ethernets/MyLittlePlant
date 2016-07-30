namespace MyLittlePlant.Products
{
    using System;

    using Enum;

    public abstract class ProductBase : IProductBase
    {
        public void Colour()
        {
            Console.WriteLine("Standart colour Black");
        }

        public void MadeIn(CountryType countryType)
        {
            switch (countryType)
            {
                case CountryType.China:
                    Console.WriteLine("China");
                    break;
                case CountryType.Germany:
                    Console.WriteLine("Germany");
                    break;
                case CountryType.Vietnam:
                    Console.WriteLine("Vietnam");
                    break;
            }
        }

        public void Material(int ctn, int pol)
        {
            if (ctn == 90 && pol == 10)
            {
                Console.WriteLine("Cotton{0} + Polyester {1}", ctn, pol);
            }
            else if (ctn == 50 && pol == 50)
            {
                Console.WriteLine("Cotton{0} + Polyester {1}", ctn, pol);
            }
            else if (ctn == 100 && pol == 0)
            {
                Console.WriteLine("Cotton{0} + Polyester {1}", ctn, pol);
            }
        }

        public void Size(int s)
        {
            if (s == 44 || s == 46)
            {
                Console.WriteLine("Size M");
            }
            else if (s == 48 || s == 50)
            {
                Console.WriteLine("Size L");
            }
            else if (s == 52 || s == 54)
            {
                Console.WriteLine("Size XXL");
            }
        }

        public void WashingTemperature(int temp)
        {
            if (temp == 40)
            {
                Console.WriteLine("Washing Temperature {0}C", temp);
            }
            else if (temp == 55)
            {
                Console.WriteLine("Washing Temperature {0}C", temp);
            }
        }
    }
}

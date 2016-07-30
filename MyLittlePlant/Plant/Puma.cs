namespace MyLittlePlant.Plant
{
    using Collections.Puma;

    public class Puma : Iproducts
    {
        public INewCollection GetNew()
        {
            return new PumaBMW();
        }

        public ISale GetSale()
        {
            return new PumaFerrari();
        }
    }
}

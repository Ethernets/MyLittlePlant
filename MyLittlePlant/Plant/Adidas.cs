namespace MyLittlePlant.Plant
{
    using System;
    using Collections.Adidas;

    public class Adidas : Iproducts
    {
        public INewCollection GetNew()
        {
            return new AdidasOriginal();
        }

        public ISale GetSale()
        {
            return new AdidasPureboostX();
        }
    }
}

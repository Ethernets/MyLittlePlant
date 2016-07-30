namespace MyLittlePlant.Plant
{
    using Collections.Reebok;

    public class Reebok : Iproducts
    {
        public INewCollection GetNew()
        {
            return new ReebokFootwear(); 
        }

        public ISale GetSale()
        {
            return new ReebokApparel();
        }
    }
}

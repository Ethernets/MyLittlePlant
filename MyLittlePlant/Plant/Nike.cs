namespace MyLittlePlant.Plant
{
    using Collections.Nike;

    public class Nike : Iproducts
    {
        public INewCollection GetNew()
        {
            return new NikeAirMax();
        }

        public ISale GetSale()
        {
            return new NikeRosheRun();
        }
    }
}

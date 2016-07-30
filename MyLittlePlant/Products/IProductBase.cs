namespace MyLittlePlant.Products
{
    using Enum;

    public interface IProductBase
    {
        void Size(int s);

        void Colour();

        void Material(int ctn, int pol);

        void MadeIn(CountryType countryType);

        void WashingTemperature(int temp);
    }
}

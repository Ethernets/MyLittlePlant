namespace MyLittlePlant.Collections.Adidas
{
    using System.Collections;
    using Products;

    public abstract class AdidasBase : ProductBase
    {
        public static IEnumerable Model()
        {
            yield return "Model Adidas F50";

            yield return "Model Adidas Total 90";

            yield return "Model Adidas Original sports";
        }
    }
}

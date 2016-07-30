namespace MyLittlePlant.Collections.Nike
{
    using System.Collections;
    using Products;

  public abstract class NikeBase : ProductBase
    {
        public static IEnumerable Model()
        {
            yield return "Nike Air Max F50";

            yield return "Nike Roshe Run W340";

            yield return "Nike Air sports";
        }
    }
}

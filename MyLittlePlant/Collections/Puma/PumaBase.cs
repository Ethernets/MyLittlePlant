namespace MyLittlePlant.Collections.Puma
{
    using System.Collections;
    using Products;

  public abstract class PumaBase : ProductBase
    {
        public static IEnumerable Model()
        {
            yield return "Puma BMW FX10";

            yield return "Puma BMW W150";

            yield return "Puma Ferrari F1";
        }
    }
}

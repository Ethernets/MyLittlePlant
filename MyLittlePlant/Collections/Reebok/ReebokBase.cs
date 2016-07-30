namespace MyLittlePlant.Collections.Reebok
{
    using System.Collections;
    using Products;

    public abstract class ReebokBase : ProductBase
    {
        public static IEnumerable Model()
        {
            yield return "Reebok Apparel A12";

            yield return "Reebok Apparel A190";

            yield return "Reebok Footwear FR10";
        }
    }
}

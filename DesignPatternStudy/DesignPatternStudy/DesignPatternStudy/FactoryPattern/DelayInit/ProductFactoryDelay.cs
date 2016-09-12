using DesignPatternStudy.ProductGroup;
using System.Collections.Generic;

public class ProductFactoryDelay
{
    private static Dictionary<string, Product> prMap = new Dictionary<string, Product>();
    public static Product createProduct(string type)
    {
        Product product = null;
        if (prMap.ContainsKey(type))
        {
            product = prMap[type];
        }
        else
        {
            if (type.Equals("ConcreteProduct1"))
            {
                product = new ConcreteProduct1();
            }
            else
            {
                product = new ConcreteProduct2();
            }
            prMap.Add(type, product);
        }

        return product;
    }
}

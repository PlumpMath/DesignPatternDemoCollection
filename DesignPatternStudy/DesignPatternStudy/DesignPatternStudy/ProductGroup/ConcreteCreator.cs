using DesignPatternStudy.FactoryPattern;
using System;

namespace DesignPatternStudy.ProductGroup
{
    public class ConcreteCreator : Creator
    {
        //public override Product createProduct<Product>() 
        //{
        //    Product product = default(Product);
        //    try
        //    {
        //        product = (Product)Activator.CreateInstance(typeof(Product));
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("excep=" + e.ToString());
        //    }
        //    return product; 
        //}

        public override Human createProduct<Human>()
        {
            Human product = default(Human);
            try
            {
                product = (Human)Activator.CreateInstance(typeof(Human));
            }
            catch (Exception e)
            {
                Console.WriteLine("excep=" + e.ToString());
            }
            return product;
        }
    }
}

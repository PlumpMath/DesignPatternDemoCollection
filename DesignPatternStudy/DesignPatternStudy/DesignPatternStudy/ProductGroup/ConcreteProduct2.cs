using DesignPatternStudy.ProductGroup;
using System;

public class ConcreteProduct2 : Product
{
    static int index = 0;
    public ConcreteProduct2()
    {
        index++;
    }

    public override void method2()
    {
        Console.WriteLine("ConcreteProduct2 的method2 index=" + index);
    }
}
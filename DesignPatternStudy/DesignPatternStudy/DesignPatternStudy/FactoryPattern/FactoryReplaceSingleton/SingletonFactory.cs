using System;
using System.Reflection;

public class SingletonFactory
{
    private static Singleton singleton;
    static SingletonFactory()
    {
        try
        {
            Type type = typeof(Singleton);

            System.Reflection.ConstructorInfo[] constructorInfoArray = type.GetConstructors(System.Reflection.BindingFlags.Instance
                        | System.Reflection.BindingFlags.NonPublic
                        | System.Reflection.BindingFlags.Public);
            System.Reflection.ConstructorInfo noParameterConstructorInfo = null;

            foreach (System.Reflection.ConstructorInfo constructorInfo in constructorInfoArray)
            {
                System.Reflection.ParameterInfo[] parameterInfoArray = constructorInfo.GetParameters();
                if (0 == parameterInfoArray.Length)
                {
                    noParameterConstructorInfo = constructorInfo;
                    break;
                }
            }

            if (null == noParameterConstructorInfo)
            {
                throw new NotSupportedException("No constructor without 0 parameter");
            }
            singleton = (Singleton)noParameterConstructorInfo.Invoke(null);
        }
        catch (Exception e)
        {
            Console.WriteLine("e=" + e.ToString());
        }
    }

    public static Singleton getSingleton()
    {
        return singleton;
    }
}
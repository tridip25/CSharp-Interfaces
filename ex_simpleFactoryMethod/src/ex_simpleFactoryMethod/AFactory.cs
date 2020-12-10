using System;
namespace ex_simpleFactoryMethod
{
    public class AFactory
    {
        public static A getObjOfA()
        {
            return new A();
        }
    }
}
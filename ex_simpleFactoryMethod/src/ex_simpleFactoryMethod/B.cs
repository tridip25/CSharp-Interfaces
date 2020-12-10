using System;

namespace ex_simpleFactoryMethod
{
    public class B
    {
        public static void displayValues()
        {
            A obj = AFactory.getObjOfA();
            Console.WriteLine(obj.Name);
            obj.Id = "DC2019BTE909";
            Console.WriteLine(obj.Id);

        }
    }
}
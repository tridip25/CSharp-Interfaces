using System;

namespace ex_DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //ioc obj = new ioc();
         //   dip obj = new dip();
          //  obj.func();

          InjectorClass a = new InjectorClass();
         // DependencyInjection b = new DependencyInjection();
          a.func();
        }
    }
}

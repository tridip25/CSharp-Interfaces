using System;
//Example of Dependency Injection using constructor
namespace ex_DependencyInjection
{
    public interface IB
    {
        void displayMessage();
    } 
    public class B : IB
    {
    
        public void displayMessage()
        {
            Console.WriteLine("Hiiii");
        }
    }

    public class DependencyInjection
    {
        IB obj;
        public DependencyInjection(IB objb)
        {
            obj = objb;
        }
        // public DependencyInjection()
        // {
        //     obj = new B();
        // }
        
         
        public void func()
        {
           // obj = BFactory.GetBobj();
            obj.displayMessage();
        }   
    }

    
    public class InjectorClass
     {
       DependencyInjection _AAA;

       public InjectorClass()
       {
         _AAA = new DependencyInjection(new B());
       }

          public void func()
          {
              _AAA.func();
          }

     }
    
}
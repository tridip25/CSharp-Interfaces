// using System;

// namespace ex_DependencyInjection
// {
//     public interface IB
//     {
//         void displayMessage();
//     } 
//     public class B : IB
//     {
//         public void displayMessage()
//         {
//             Console.WriteLine("Hiiii");
//         }
//     }

//     public class BFactory
//     {
//         public static IB GetBobj()
//         {
//             return new B();
//         }
//     }

//     public class dip
//     {
//         IB obj;
//         public void func()
//         {
//             obj = BFactory.GetBobj();
//             obj.displayMessage();
//         }   
//     }
// }
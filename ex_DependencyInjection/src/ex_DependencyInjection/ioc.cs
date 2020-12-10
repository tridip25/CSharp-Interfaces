// using System;

// namespace ex_DependencyInjection
// {
//     public class ioc
//     {
//         public void func()
//         {
//             B obj = BFactory.GetBObj();
//             obj.displayMessage();
//         }
//     }

//     public class BFactory
//     {
//         public static B GetBObj()
//         {
//             return new B();
//         }
//     }

//     public class B
//     {
//           public void displayMessage()
//         {
//             Console.WriteLine("Hello brother !!!");
//         }
//     }
// }
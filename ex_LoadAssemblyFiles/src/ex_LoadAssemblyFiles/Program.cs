using System;
using System.Reflection;

namespace ex_LoadAssemblyFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string dllFile = @"D:\loadDll.dll";
            var assembly = Assembly.LoadFile(dllFile);

            var type = assembly.GetType("loadDll.HelloWorld");
            
            var obj = Activator.CreateInstance(type);

            var method = type.GetMethod("SayHello");

            var result = method.Invoke(obj, new object[] {"Brad"});

            Console.WriteLine(result);
            Console.Read();

        }
    }
}

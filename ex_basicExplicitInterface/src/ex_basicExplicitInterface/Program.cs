using System;

namespace ex_basicExplicitInterface
{

    public interface ISaveable
    {
        void Save();
    } 

    public interface IDbSaver
    {
        void Save();
    }

//Since we have conflicting methods , we set the methods as explicit
    public class Catalog : ISaveable , IDbSaver
    {
        void ISaveable.Save()
        {
            Console.WriteLine("Saved from ISaveable interface");
        }

        void IDbSaver.Save()
        {
            Console.WriteLine("Saved from IDbsaver interface");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ISaveable obj = new Catalog();
            obj.Save();
            IDbSaver obj1 = new Catalog();
            obj1.Save();
        }
    }
}

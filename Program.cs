using System.Security.Cryptography;
using ConstructvsClass;



namespace StructvsClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarStruct car1;
            //Structs are value type, and it has different memory locations when changed
            car1.CarName = "Mercedes";
            Console.WriteLine(car1.GetHashCode()); // has memory location/ HashCode: -658697507
            car1.CarName = "BMW";
            Console.WriteLine(car1.GetHashCode()); //has memory location/ HashCode: - 1411530255

            CarClass car2 = new CarClass();// Classes are reference type, has the same memory location and does not change.
            car2.CarName = "Fiat";
            Console.WriteLine(car2.GetHashCode());//has memory location/ HashCode: 54267293
            car2.CarName = "Maruti";
            Console.WriteLine(car2.GetHashCode());//has memory location/ HashCode: 54267293








        }
    }
}

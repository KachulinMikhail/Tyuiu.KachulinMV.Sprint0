using Tyuiu.KachulinMV.Sprint0.Task4.V1.Lib;

namespace Tyuiu.KachulinMV.Sprint0.Task4.V1

{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DataService.Addition(1, 5));

            Console.WriteLine(DataService.Substraction(15, 5));

            Console.WriteLine(DataService.Multiplication(1, 10));

            Console.WriteLine(DataService.Division(5, 5));

            Console.ReadKey();
        }
    }
}
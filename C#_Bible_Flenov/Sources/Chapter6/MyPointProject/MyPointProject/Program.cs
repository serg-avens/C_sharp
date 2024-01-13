// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace MyPointProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPoint p1 = new MyPoint(10, 10);
            MyPoint p2 = new MyPoint(20, 20);
            Console.WriteLine("Точка 1 ->" +p1);
            Console.WriteLine("Точка 2 ->" + p2);
        }
    }
}
using dotnet_poo.src.Entities;

namespace dotnet_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            var arus = new Knight("Arus", 23, "Knight");
            var jennica = new Wizard("Jennica", 24, "White Wizard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(jennica.Attack(3));
        }
    }
}
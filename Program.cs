using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1 for Veg restaurant and 2 for Non veg restaurant: ");
            int input = int.Parse(Console.ReadLine());
            switch (input) {
                case 1:
                    Veg.vegres();
                    break;
                case 2:
                    Nonveg.nonvegres();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            Console.WriteLine("Enter your order: ");
            var order = Console.ReadLine();

        }
    }
}

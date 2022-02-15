using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPage
{
    internal class Nonveg
    {
        public static void nonvegres()
        {
            List<string> nvhotelname = new List<string>();
            nvhotelname.Add("SS Biryani");
            nvhotelname.Add("Thalapakatty");
            nvhotelname.Add("Chettinadu");
            foreach(string j in nvhotelname)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("Enter Non veg restaurant name: ");
            string nvhotelnames = Console.ReadLine();
            string hotel4 = "ss biryani";
            string hotel5 = "thalapakatty";
            string hotel6 = "chettinadu";
            switch (nvhotelnames)
            {
                case "ss biryani":
                    Console.WriteLine("Chicken Biryani" + "           100 Rs");
                    Console.WriteLine("Plain Biryani" + "             80 Rs");
                    Console.WriteLine("chicken mix" + "               90 Rs");
                    break;
                case "thalapakatty":
                    Console.WriteLine("Mutton biryani" + "            100 Rs");
                    Console.WriteLine("Tandoori masala" + "           90 Rs");
                    Console.WriteLine("Chicken butter masala" + "     90 Rs");
                    break ;
                case "chettinadu":
                    Console.WriteLine("Chappati & chicken curry" + "  80 Rs");
                    Console.WriteLine("Chicken rice" + "              90 Rs");
                    Console.WriteLine("chicken tikka" + "             80 Rs");
                    break;
                default:
                    Console.WriteLine("No such hotel found. Please enter a valid hotel name :)");
                    break;
            }
        }
    }
}

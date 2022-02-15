using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPage
{
    internal class Veg
    {
        public static void vegres()
        {
            List<string> hotelnames = new List<string>();
            hotelnames.Add("Aryaas");
            hotelnames.Add("Sathya");
            hotelnames.Add("Ananda bhavan");
            foreach (string i in hotelnames)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Enter the name of the restaurant to view the dishes and price: ");
            string hotelname =Console.ReadLine();
            string hotel1 = "aryaas";
            string hotel2 = "sathya";
            string hotel3 = "ananda bhavan";
            switch (hotelname)
            {
                case "aryaas":
                    Console.WriteLine("Chappati, 2 nos"+"           40 Rs");
                    Console.WriteLine("Dosa, 2 nos" + "             30 Rs");
                    Console.WriteLine("Parota, 2 nos" + "           50 Rs");
                    break;
                case "sathya":
                    Console.WriteLine("Idly, 2 nos" + "             20 Rs");
                    Console.WriteLine("Pongal" + "                  40 Rs");
                    Console.WriteLine("Idiyappam, 2 nos" + "        30 Rs");
                    Console.WriteLine("Mix veg" + "                 70 Rs");
                    break;
                case "ananda bhavan":
                    Console.WriteLine("Aloo palak" + "              60 Rs");
                    Console.WriteLine("Mushroom Mattar" + "         70 Rs");
                    Console.WriteLine("Jeera aloo" + "              60 Rs");
                    Console.WriteLine("Rajma Masala" + "            80 Rs");
                    
                    break;
                default:
                    Console.WriteLine("No such hotel found. Please enter a valid hotel name :)");
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program171
{
    internal class Program
    {
        static void Main()
        {

            Console.Write("Номер планеты от Солнца (1–8): ");
            if (!int.TryParse(Console.ReadLine(), out int planet))
            {
                Console.WriteLine("Ошибка.");
                return;
            }

            string planetName;
            switch (planet)
            {
                case 1: planetName = "Меркурий"; break;
                case 2: planetName = "Венера"; break;
                case 3: planetName = "Земля"; break;
                case 4: planetName = "Марс"; break;
                case 5: planetName = "Юпитер"; break;
                case 6: planetName = "Сатурн"; break;
                case 7: planetName = "Уран"; break;
                case 8: planetName = "Нептун"; break;
                default:
                    Console.WriteLine("Нет такой планеты.");
                    return;
            }
            Console.WriteLine(planetName);
        }
    }
}
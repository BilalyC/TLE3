using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Jeudi", "Samedi", "Dimanche" };
            for (int i = 0; i < week.Length; i++)
            {
                Console.WriteLine(week[i]);
            }

            week[4] = "Vendredi";

            for (int i = 0; i < week.Length; i++)
            {
                Console.WriteLine(week[i]);
            }
        }
    }
}

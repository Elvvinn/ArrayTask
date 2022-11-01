using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] regemler = { 4, 6, 9, 12, 24 };
            int cem = 0;

            for (int i = 0; i < regemler.Length; i++)
            {
                if (regemler[i] > 0 && regemler [i] % 6 == 0)
                {
                    cem += regemler[i];

                }
            }
            Console.WriteLine( " cemi :" +(cem));
        }

    }
}

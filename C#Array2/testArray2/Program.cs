using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testArray2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] regemler = { 34, 23, 48, 55, 70 };
            int boyuk = regemler[0];
            for (int i = 0; i < regemler.Length; i++)
            {
                if (regemler[i] > boyuk)
                {
                    boyuk = regemler[i];
                }
            }
            Console.WriteLine("en boyuk eded  : {0}", boyuk);

        }
    }
}

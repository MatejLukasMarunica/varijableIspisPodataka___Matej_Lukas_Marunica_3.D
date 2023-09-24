using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace varijableIspisPodataka___Matej_Lukas_Marunica_3.D
{
    internal class Program
    {
       
        
        static void Main(string[] args)
        {
            int a, b, x, y;

            a = 100;
            b = 3;
            x = a / b;
            y = a % b;



            Console.WriteLine(a + " dijeljen sa " + b + " iznosi " + x + " a ostatak ispada " + y);
            Console.ReadKey();
        }
    }
}

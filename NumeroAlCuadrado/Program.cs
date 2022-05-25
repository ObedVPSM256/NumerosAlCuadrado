using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroAlCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int nume;
            try
            {
                Console.Write("Introduzca el número que desea elevar al cuadrado: ");
                nume = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(nume * nume);
                Console.ReadLine();
            }
            catch (FormatException e)
            {
                Console.Write(e.Message);
            }
            catch (OverflowException e)
            {
                Console.Write(e.Message);
            }
        }
    }
}

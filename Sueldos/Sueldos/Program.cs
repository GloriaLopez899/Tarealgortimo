using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    class Salario
    {
        private int[] sueldos;

        public void Cargar()
        {
            sueldos = new int[5];
            for (int f = 0; f < 5; f++)
            {
                Console.Write("Ingrese valor de la componente:");
                String linea;
                linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea);
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < 5; f++)
            {
                Console.WriteLine(sueldos[f]);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Salario pv = new Salario();
            pv.Cargar();
            pv.Imprimir();
        }
    }
}
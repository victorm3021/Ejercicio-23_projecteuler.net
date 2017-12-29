/*
 * Número de Fibonacci de 1000 dígitos
Problema 25 
La secuencia de Fibonacci se define por la relación de recurrencia:

F n = F n -1 + F n -2 , donde F 1 = 1 y F 2 = 1.
Por lo tanto, los primeros 12 términos serán:

F 1 = 1 
F 2 = 1 
F 3 = 2 
F 4 = 3 
F 5 = 5 
F 6 = 8 
F 7 = 13 
F 8 = 21 
F 9 = 34 
F 10 = 55 
F 11 = 89 
F 12 = 144
El 12º término, F 12 , es el primer término que contiene tres dígitos.

¿Cuál es el índice del primer término en la secuencia de Fibonacci que contiene 1000 dígitos?
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_25
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger f = 0, f1 = 0, f2 = 1;
            int indice = 2, cuentadigito = 0,digito = 1000;
            string fstring;
            while (cuentadigito <= digito)
            {
                
                f = f1 + f2;                 
                f1 = f2;
                f2 = f;
                fstring = f.ToString();
                cuentadigito = fstring.Count();
                if (cuentadigito == digito)
                {
                    Console.WriteLine($"El numero que tiene {digito} digitos esta en el indice {indice}");
                    break;
                }

                indice++;
            }
            Console.ReadLine();
        }
    }
}

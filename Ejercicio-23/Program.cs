/*
 Problema 23 
Un número perfecto es un número para el cual la suma de sus divisores es exactamente igual al número. 
Por ejemplo, la suma de los divisores adecuados de 28 sería 1 + 2 + 4 + 7 + 14 = 28, 
lo que significa que 28 es un número perfecto.

Un número n se llama deficiente si la suma de sus divisores propios es menor que n y se llama abundante 
si esta suma excede n .

Como 12 es el número más pequeño y abundante, 1 + 2 + 3 + 4 + 6 = 16, el número más pequeño que puede 
escribirse como la suma de dos números abundantes es 24. 
Mediante análisis matemático, se puede demostrar que todos los enteros superiores a 28123 
se puede escribir como la suma de dos números abundantes. 
Sin embargo, este límite superior no puede reducirse más mediante el análisis, 
aunque se sabe que el mayor número que no se puede expresar como la suma de dos números 
abundantes es menor que este límite.

Encuentre la suma de todos los enteros positivos que no pueden escribirse como la suma de dos números abundantes.
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int divisor = 0,suma = 1;
            int limite = 28124;
            List<int> abundante = new List<int>();
            List<int> sumadeabundantes = new List<int>();            

            for (int i = 1; i <= limite; i++)
            {
                divisor = 0;
               
                for (int a = 1; a <= (i / 2); a++)     
                {
                    if (i % a == 0)     //buscamos los divisores del numero
                    {
                        divisor += a;
                    }
                }
                if (divisor > i)  //si divisor, que es la suma de los divisores del numero, es mayor que el numero
                {
                    abundante.Add(i);   //agrega el numero a la lista ya que es un numero abundante                 
                }
            }
            
                foreach (int num1 in abundante)
                {
                    foreach (int num2 in abundante)
                    {
                        suma = num2 + num1;     //suma todos los numero abundantes
                        if (suma < limite)
                            {
                                sumadeabundantes.Add(suma);     //agrega a la lista la suma de los numeros abundantes
                            }
                    }

                }
            sumadeabundantes = sumadeabundantes.Distinct().ToList(); //elimina numero repetidos de la lista
            sumadeabundantes.Sort();    //ordena los numeros

            List<int> enteros = new List<int>(); //declaramos otra lista para almacenar los numeros naturales 
            int contador = 1,sumanumeros = 0;
            for (int i = 1; i < limite; i++)
            {
                enteros.Add(i);         //agregamos a la lista todos los numeros del 1 hasta el limite(28124)
            }
            foreach (int unico in sumadeabundantes) //recorremos uno a uno los elementos de la lista sin repetidos
            {
                enteros.Remove(unico);       //eliminamos de la lista de numeros naturales los elementos de la lista sin repetidos 
            }
            foreach (int numero in enteros)       //recorremos la lista con los elementos resultantes
            {
                sumanumeros += numero;            //sumamos los elementos
                Console.WriteLine($"{numero}          {contador}       suma total {sumanumeros}");
                contador++;
            }

            Console.ReadLine();
        }
    }
}

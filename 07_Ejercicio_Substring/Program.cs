/*
 * Escribe un programa que dada una cadena identifique los caracteres del 5 al 10, ambos inclusive.
 */
using System;

namespace _07_Ejercicio_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "helicopterovolador";

            string subcadena = nombre.Substring(5, 10);

            Console.WriteLine(subcadena);

            //Introduce aquí tu código
        }
    }
}

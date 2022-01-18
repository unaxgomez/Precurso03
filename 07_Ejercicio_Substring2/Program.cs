/*
 * Escribe un programa que recupere una subcadena de un string en otra variable usando una función.
 */
using System;

namespace _07_Ejercicio_Substring2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Unax";

            string subcadena = nombre.Substring(0);

            Console.WriteLine("El nombre " + nombre + " tiene " + subcadena + " caracteres.");

           //Introduce aquí tu código
        }
    }
}

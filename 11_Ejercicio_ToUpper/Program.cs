/*
 * Escribe un programa que convierta a mayúsculas una frase que pides al usuario por consola. 
 */
using System;

namespace _11_Ejercicio_ToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe una frase para pasarla a mayúsculas");

            string fraseusuario = Console.ReadLine();

            string fraseusuariomayus = fraseusuario.ToUpper();

            Console.WriteLine(fraseusuariomayus);

            //Introduce aquí tu código
        }
    }
}

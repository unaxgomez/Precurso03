/*
 * Escribe un programa que te calcule la largura de un string que pides por consola.
 */
using System;

namespace _04_Ejercicio_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esto es un contador de palabras");

            string nombre = "   Unax    ";

            string nombresinespacios = nombre.Trim();

            int numeroletras = nombresinespacios.Length;

            Console.WriteLine("El nombre " + nombre + " tiene " + numeroletras + " letras.");//Introduce aquí tu código
        }
    }
}

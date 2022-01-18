/*
 * Escribe un programa que reemplace una cadena por otra (Por ejemplo “Hola Arrate” por “Hola Iker”).
 */
using System;

namespace _15_Ejercicio_Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Hola Arrate";

            string reemplazado = nombre.Replace("Arrate", "Iker");

            Console.WriteLine("Este es el string inicial         " + nombre);
            Console.WriteLine("Este es el string reemplazado     " + reemplazado);//Introduce aquí tu código
        }
    }
}

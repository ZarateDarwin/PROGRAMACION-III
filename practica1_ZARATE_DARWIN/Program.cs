using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1_ZARATE_DARWIN
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] nombre = new string[3];
            int[] edad = new int[3];
            int edadC = 0;

            for (int i = 0; i < nombre.Length; i++) 
            {
                Console.WriteLine("ingrese su nombre " + (i + 1));
                nombre[i] = Console.ReadLine();

                while(!int.TryParse(Console.ReadLine(), out edadC))
                    Console.WriteLine("ingrese su edad " + nombre[i]);
                edad[i] = edadC;
                Console.Clear();
            }
            //for (int i = 0; i < nombre.Length; i++)
            //{
            //    Console.WriteLine("ingrese su edad " + (i + 1));
            //    edad[i] = edadC;
            //}

            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("[" + nombre[i] + "]" + "[" + edad[i] + "]");
            }



            Console.WriteLine("personas con menor edad");
            for (int j = 0; j < nombre.Length; j++)
            {
                if (edad[j] <= 18)
                {
                    Console.WriteLine(nombre[j] + "edad" + edad[j]);
                }
                Console.ReadLine();
            }
               
        }
    }
}

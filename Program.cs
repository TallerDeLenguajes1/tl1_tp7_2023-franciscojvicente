using EspacioCalculadora;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculadora calcular = new calculadora();

            string? resp = "";
            do {
            Console.WriteLine("Presione el simbolo para realizar la operacion:");
                Console.WriteLine("+ para sumar");
                Console.WriteLine("- para restar");
                Console.WriteLine("* para multiplicar");
                Console.WriteLine("/ para dividir");
                Console.WriteLine("L para limpiar");
                Console.Write("Eliga Una Opcion: "); //Aqui es donde indicaremos que operacion vamos a realizar
                resp = Console.ReadLine();
                string? eleccion = Convert.ToString(resp);
                //Aqui se agregaran los mensajes para poder ingresar los datos.
                double termino = 0;

                bool anda = false;

                string? num1 = "";

                while (!anda)
                {
                    Console.WriteLine("Ingrese un número válido");
                    num1 = Console.ReadLine();
                    anda = double.TryParse(num1, out termino);
                    if (!anda)
                    {
                        Console.WriteLine(num1 + " no es un n° válido.");
                    }
                }

                switch (eleccion)
                {
                    case "+":
                        calcular.sumar(termino);
                        Console.WriteLine("El resultado es: " +  calcular.Resultado);
                        break;
                    case "-":
                        calcular.restar(termino);
                        Console.WriteLine("El resultado es:" + calcular.Resultado);
                        break;
                    case "*":
                        calcular.multiplicar(termino);
                        Console.WriteLine("El resultado es: " + calcular.Resultado);
                        break;
                    case "/":
                        calcular.dividir(termino);
                        Console.WriteLine("El resultado es: " + calcular.Resultado);
                        break;
                    case "L":
                        calcular.limpiar();
                        Console.WriteLine("El resultado de limpiar es: " + calcular.Resultado);
                        break;
                }
                Console.Write("¿Desea Continuar? s/n: "); //Si para realizarlo de nuevo y no para salir.
                resp = Console.ReadLine();
            }
            while (resp == "s" || resp == "s");
        }
    }
}
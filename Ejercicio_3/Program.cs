using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cree un programa de consola que solicite una distancia en kilómetros para ser recorrida en 6 horas, el script debe
            //calcular a qué velocidad se desplazará el vehículo en recorrer la distancia ingresada por el cliente, debe mostrar el
            //resultado por pantalla.

            int Velocidad;
            int Distancia;
            int Tiempo = 6;

            Console.WriteLine("Ingrese la distancia que desea recorrer: ");
            Distancia = int.Parse(Console.ReadLine());

            Velocidad = Distancia / Tiempo;

            Console.WriteLine("Usted se desplazara a esta velocidad: "+Velocidad+(" Km"));

            Console.ReadLine();
        }
        
    }
}

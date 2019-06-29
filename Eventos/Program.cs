using System;

namespace Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Numeros numeros = new Numeros();
            numeros.EventoPar += DeteccionNumeroPar;
            numeros.EventoPar += () => Console.WriteLine($"EL NUMERO {numeros.Num} ES PAR");
            numeros.EventoPar += delegate(){Console.WriteLine("EVENTO PAR");};
            Console.WriteLine("Ingrese un Nº por favor:");
            numeros.Num = int.Parse(Console.ReadLine());
            //numeros.Num = Convert.ToInt32(Console.ReadLine());
            while(numeros.Num > 0)
            {
                numeros.Num--;
            }
            Console.WriteLine("Fin del programa");
        }

        static void DeteccionNumeroPar()
        {
            Console.WriteLine($"El numero es par.");
        }
    }
}

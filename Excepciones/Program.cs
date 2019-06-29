using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese una operacion");
            string operacion = Console.ReadLine();

            var calculadora = new Calculadora();
            try
            {
                int resultado = calculadora.Calcular(numero1, numero2, operacion);
                //int resultado = calculadora.Calcular(1, 1, "/");
                Console.WriteLine($"El resultado es {resultado}");
            }
            catch(ArgumentNullException ex) when (ex.ParamName == "operacion")
            {
                //Log.(ex.ToString())
                Console.WriteLine("Debe ingresar una operación");
                Console.WriteLine(ex.ToString());
            }
            catch(ArgumentNullException ex)
            {
                //Log.(ex.ToString())
                Console.WriteLine("Debe ingresar dos numeros enteros");
                Console.WriteLine(ex.ToString());
            }
            catch(OperacionIncorrectaException ex)
            {
                Console.WriteLine("Operación incorrecta");
            }
            catch(Exception ex)
            {
                throw ex;
                //Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Fin del programa.");
            }
        }
    }
}

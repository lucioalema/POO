using System;

namespace Excepciones
{
    public class Calculadora
    {
        public int Calcular(int numero1, int numero2, string operacion)
        {
            if (string.IsNullOrEmpty(operacion))
            {
                throw new ArgumentNullException(nameof(operacion), "El valor no puede ser nulo.");
            }
            // if (numero1 == null || numero2 == null)
            //     throw new ArgumentNullException(nameof(numero1));
            if (operacion == "/")
            {
                try
                {
                    return Division(numero1, numero2);
                }
                catch(DivideByZeroException ex)
                {
                    throw new ArithmeticException("Ocurrió una excepcion durante el cálculo", ex);
                }
            }
            else
            {
                throw new OperacionIncorrectaException();
                //throw new ArgumentOutOfRangeException(nameof(operacion), operacion, "El operador matemático no es soportado.");
            }
        }

        private int Division(int numero1, int numero2)
        {
            return numero1 / numero2;
        }
    }
}
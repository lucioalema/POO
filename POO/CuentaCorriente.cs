using System;
namespace POO
{
    public class CuentaCorriente
    {
        protected double saldo = 0;
        public double Saldo
        {
            get { return saldo; }
        }

        public bool Extraccion(double cantidad)
        {
            if (cantidad <= 0) return false;
            this.saldo -= cantidad;
            return true;
        }

        public bool Deposito(double cantidad)
        {
            Console.WriteLine("Ejecutando Deposito con double como argumento");
            this.saldo += cantidad;
            return true;
        }

        public bool Deposito(double cantidad, double otraCantidad)
        {
            Console.WriteLine("Ejecutando Deposito con double como argumento y otraCantidad");
            this.saldo += cantidad + otraCantidad;
            return true;
        }

        public bool Deposito(float cantidad)
        {
            Console.WriteLine("Ejecutando Deposito con float como argumento");
            this.saldo += cantidad;
            return true;
        }

        public bool Deposito(int cantidad)
        {
            Console.WriteLine("Ejecutando Deposito con int como argumento");
            this.saldo += cantidad;
            return true;
        }

        public bool Deposito(long cantidad)
        {
            Console.WriteLine("Ejecutando Deposito con long como argumento");
            this.saldo += cantidad;
            return true;
        }

        public static void MetodoEstatico()
        {
            nombreCuenta = "Perez";
            Console.WriteLine("Constante con valor {0}", constate);
            Console.WriteLine("Llamando método sin instanciar la clase");
        }

        const int constate = 5;
        public static string nombreCuenta;
    }
}
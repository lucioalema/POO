using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //MainCoche();
            //MainCuenta();
            //MainClasesAbstractas();
            Empleado empleado = new EmpleadoFullTime(12111222, "Juan", "Perez", 30000);
            Console.WriteLine("El sueldo de {0} es de {1}", empleado.Apellido, empleado.SueldoMensual());

            Empleado empleadoFL = new Freelancer(33444888, "Luis", "Lopez", 250, 80);
            Console.WriteLine("El sueldo de {0} es de {1}", empleadoFL.Apellido, empleadoFL.SueldoMensual());
        }

        static void MainCoche()
        {
            // Coche miCoche = new Coche("AA111AA", "Blanco", "Ford", "Fiesta");
            CocheInteligente miCoche = new CocheInteligente("AB222BB", "Azul", "Honda", "Civic");
            Coche miCoche2 = new CocheInteligente("AB222BB", "Azul", "Honda", "Civic");
            Console.WriteLine("Los datos de mi coche son:");
            Console.WriteLine("Marca: {0}", miCoche.Marca);
            Console.WriteLine("Modelo: {0}", miCoche.Modelo);
            Console.WriteLine("Color: {0}", miCoche.Color);
            Console.WriteLine("Patente: {0}", miCoche.Patente);
            
            miCoche.Acelerar(100);
            Console.WriteLine("La velocidad actual es de {0} km/h", miCoche.Velocidad);
            miCoche.Frenar(75);
            Console.WriteLine("La velocidad actual es de {0} km/h", miCoche.Velocidad);

            miCoche.Girar(45);

            miCoche.Estacionar();
            Console.WriteLine("La velocidad actual es de {0} km/h", miCoche.Velocidad);
        }
        static void MainCuenta()
        {
            Console.WriteLine(CuentaCorriente.nombreCuenta);
                CuentaCorriente.MetodoEstatico();
                Console.WriteLine(CuentaCorriente.nombreCuenta);
                CuentaCorriente cuenta = new CuentaCorriente();
                // cuenta.Deposito(200.55);
                // Console.WriteLine("El saldo de la cuenta es de {0}", cuenta.Saldo);
                // cuenta.Deposito(200.55, 600);
                // Console.WriteLine("El saldo de la cuenta es de {0}", cuenta.Saldo);
                // cuenta.Deposito(35.89F);
                // Console.WriteLine("El saldo de la cuenta es de {0}", cuenta.Saldo);
                // cuenta.Deposito(10);
                // Console.WriteLine("El saldo de la cuenta es de {0}", cuenta.Saldo);
                // cuenta.Deposito(300);
                // Console.WriteLine("El saldo de la cuenta es de {0}", cuenta.Saldo);
        }

        static void MainClasesAbstractas()
        {
            C claseC = new C();
            claseC.F();
            claseC.G();
            D claseD = new D();
            claseD.F();
        }
    }
}

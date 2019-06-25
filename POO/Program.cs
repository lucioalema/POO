using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //MainCoche();
            //MainCuenta();
            //MainClasesAbstractas();
            //MainEmpleado();
            //MainDelegados();
            //MainAsync();
            

        }

        public static string mensajeEstaticoUpper(string mensaje)
        {
            return mensaje.ToUpper();
        }

        // public static void mensajeEstatico(string mensaje, long ticks)
        // {
        //     if (ticks % 2 == 0)
        //         Console.WriteLine("Ticks par: {0} - Message: {1}", ticks, mensaje);
        //     else
        //         Console.WriteLine("Ticks impar: {0} - Message: {1}", ticks, mensaje);
        // }

        static void MainCoche()
        {
            // Coche miCoche = new Coche("AA111AA", "Blanco", "Ford", "Fiesta");
            CocheInteligente miCoche = new CocheInteligente("AB222BB", "Azul", "Honda", "Civic");
            Coche miCoche2 = new CocheInteligente("AB222BB", "Azul", "Honda", "Civic");
            Console.WriteLine("Los datos de mi coche son:");
            Console.WriteLine(miCoche.GetFullDescription());
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

        static void MainEmpleado()
        {
            Empleado empleado = new EmpleadoFullTime(12111222, "Juan", "Perez", 30000);
            Console.WriteLine("El sueldo de {0} es de {1}", empleado.Apellido, empleado.SueldoMensual());

            Empleado empleadoFL = new Freelancer(33444888, "Luis", "Lopez", 250, 80);
            Console.WriteLine("El sueldo de {0} es de {1}", empleadoFL.Apellido, empleadoFL.SueldoMensual());
        }

        /*static void MainDelegados()
        {
            Action<string, long> message; 
            Func<string, string> messageUpper = s => s.ToUpper();
            messageDelegate mDelegate = messageStatic;
            messageDelegateUpper mUpper = messageStaticUpper;

            message = delegate(string s, long ticks) { 
                if (ticks % 2 == 0)
                    Console.WriteLine("Ticks par: {0} - Message: {1}", ticks, s);
                else
                    Console.WriteLine("Ticks impar: {0} - Message: {1}", ticks, s);
                };
            message = (s,ticks) => 
            {
                if (ticks % 2 == 0)
                    Console.WriteLine("Ticks par: {0} - Message: {1}", ticks, s);
                else
                    Console.WriteLine("Ticks impar: {0} - Message: {1}", ticks, s);
            };
            
            message("Action Hello, World!", DateTime.Now.Ticks);
            mDelegate("Delegate Hello, World!", DateTime.Now.Ticks);
            Console.WriteLine(messageUpper("Func Hello, World!"));
            Console.WriteLine(mUpper("Delegate Hello, World!"));
        }

        public delegate void messageDelegate(string message, long ticks);
        public delegate string messageDelegateUpper(string message);
        public static void messageStatic(string message, long ticks)
        {
            if (ticks % 2 == 0)
                Console.WriteLine("Ticks par: {0} - Message: {1}", ticks, message);
            else
                Console.WriteLine("Ticks impar: {0} - Message: {1}", ticks, message);
        }

        public static string messageStaticUpper(string message)
        {
            return message.ToUpper();
        }

        static void MainAsync()
        {
            Console.WriteLine("Iniciando el programa: {0}", DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));
            //GetUsersList();
            //GetRolesList();
            GetUsersListAsync();
            GetRolesListAsync();
            Console.WriteLine("Imprimiendo este mensaje o haciendo otra cosa");
            Console.ReadLine();
        }

        public static void GetUsersList()
        {
            Console.WriteLine("Obteniendo usuarios de la BD");
            List<string> users = GetUsersListFromDB();
            Console.WriteLine("La cantidad total de usuarios es: {0} - {1}", users.Count, DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));
        }
 
        public static List<string> GetUsersListFromDB()
        {
            Thread.Sleep(3000);
            //Task.Delay(3000); // simulando la demora para recibir la respuesta de la BD
            return new List<string>(new [] {"jperez", "llopez"});
        }
        
        public static void GetRolesList()
        {
            Console.WriteLine("Obteniendo roles de la BD");
            List<string> roles = GetRolesListFromDB();
            Console.WriteLine("La cantidad total de roles es: {0} - {1}", roles.Count, DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));
        }
 
        public static List<string> GetRolesListFromDB()
        {
            Thread.Sleep(2000);
            //Task.Delay(2000); // simulando la demora para recibir la respuesta de la BD
            return new List<string>(new [] {"administrador", "usuario"});
        }

        public static async Task GetUsersListAsync()
        {
            Console.WriteLine("Obteniendo usuarios de la BD");
            List<string> users = await GetUsersListFromDBAsync();
            Console.WriteLine("La cantidad total de usuarios es: {0} - {1}", users.Count, DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));
        }
 
        public static async Task<List<string>> GetUsersListFromDBAsync()
        {
            await Task.Delay(3000); // simulando la demora para recibir la respuesta de la BD
            return new List<string>(new [] {"jperez", "llopez"});
        }

        public static async Task GetRolesListAsync()
        {
            Console.WriteLine("Obteniendo roles de la BD");
            List<string> roles = await GetRolesListFromDBAsync();
            Console.WriteLine("La cantidad total de roles es: {0} - {1}", roles.Count, DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));
        }
 
        public static async Task<List<string>> GetRolesListFromDBAsync()
        {
            await Task.Delay(2000); // simulando la demora para recibir la respuesta de la BD
            return new List<string>(new [] {"administrador", "usuario"});
        }*/
    }
}

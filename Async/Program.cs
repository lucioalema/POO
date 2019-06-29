using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         AddTwoNumbers a = new AddTwoNumbers();
    //         //Event gets binded with delegates
    //         a.ev_OddNumber += new AddTwoNumbers.dg_OddNumber(EventMessage);
    //         a.Add();
    //         Console.Read();
    //     }      
    //     //Delegates calls this method when event raised.  
    //     static void EventMessage()
    //     {
    //         Console.WriteLine("********Event Executed : This is Odd Number**********");
    //     }
    // }
    // //This is Publisher Class
    // class AddTwoNumbers
    // {        
    //     public delegate void dg_OddNumber(); //Declared Delegate     
    //     public event dg_OddNumber ev_OddNumber; //Declared Events
 
    //     public void Add()
    //     {
    //         int result;
    //         result = 5 + 4;
    //         Console.WriteLine(result.ToString());
    //         //Check if result is odd number then raise event
    //         if((result % 2 != 0) && (ev_OddNumber != null))
    //         {
    //             ev_OddNumber(); //Raised Event
    //         }          
    //     }
    // }
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync();
        }

        static async void MainAsync()
        {
            Console.WriteLine("Iniciando el programa: {0}", 
                DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));
            //GetUsersList();
            //GetRolesList();
            Task tarea1 = Task.Run(() => GetUsersListAsync());
            Task tarea2 = Task.Run(() => GetRolesListAsync());
            // GetUsersListAsync();
            // GetRolesListAsync();
            Task.WaitAll(tarea1, tarea2);
            Console.WriteLine("Imprimiendo este mensaje o haciendo otra cosa.");
            Console.ReadLine();
        }

        public static async Task GetUsersListAsync()
        {
            try{

            Console.WriteLine("Obteniendo usuarios de la BD");
            List<string> users = await GetUsersListFromDBAsync();
            // int x = 1;
            // int y = 0;
            // var division = x / y;
            Console.WriteLine("La cantidad total de usuarios es: {0} - {1}",
                users.Count, DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Error de division por 0");
            }
            catch(Exception ex)
            {
                //throw new Exception("Error en la task GetUsersListAsync");
                Console.WriteLine(ex.Message);
            }
        }

        private static async Task<List<string>> GetUsersListFromDBAsync()
        {
            await Task.Delay(1000);// simulando la demora de la BD
            return new List<string>(new [] {"jperez", "llopez"});
        }

        public static void GetUsersList()
        {
            Console.WriteLine("Obteniendo usuarios de la BD");
            List<string> users = GetUsersListFromDB();
            Console.WriteLine("La cantidad total de usuarios es: {0} - {1}",
                users.Count, DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));
        }

        public static List<string> GetUsersListFromDB()
        {
            Thread.Sleep(3000);
            return new List<string>(new [] {"jperez", "llopez"});
        }

        public static void GetRolesList()
        {
            Console.WriteLine("Obteniendo roles de la BD");
            List<string> roles = GetRolesListFromDB();
            Console.WriteLine("La cantidad total de roles es: {0} - {1}",
                roles.Count, DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));
        }

        private static List<string> GetRolesListFromDB()
        {
            Thread.Sleep(2000);
            return new List<string>(new [] {"administrador", "usuario-consulta"});
        }

        public static async Task GetRolesListAsync()
        {
            Console.WriteLine("Obteniendo roles de la BD");
            List<string> roles = await GetRolesListFromDBAsync();
            Console.WriteLine("La cantidad total de roles es: {0} - {1}",
                roles.Count, DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));
        }

        private static async Task<List<string>> GetRolesListFromDBAsync()
        {
            await Task.Delay(2000);// simulando la demora de la BD
            return new List<string>(new [] {"administrador", "usuario-consulta"});
        }
    }
}

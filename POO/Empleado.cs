using System;
namespace POO
{
    public abstract class Empleado: ITestInterface
    {
        public int DNI{get;}
        public string Nombre { get; }
        public string Apellido { get; }

        protected Empleado(
            int DNI, 
            string nombre, 
            string apellido)
        {
            this.DNI = DNI;
            Nombre = nombre;
            Apellido = apellido;
        }
        public abstract double SueldoMensual();

        public string GetFullDescription()
        {
            return string.Format("Apellido: {0} - Nombre: {1}", this.Apellido, this.Nombre);
            //return Apellido + ", " + Nombre;
        }
    }
}
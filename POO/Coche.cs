using System;

namespace POO
{
    public class Coche
    {
        public string Patente;
        public string Color;
        public string Marca;
        public string Modelo;
        protected double velocidad;
        public double Velocidad
        {
            get {return velocidad;}
        }

        public Coche(
            string patente, 
            string color, 
            string marca, 
            string modelo)
        {
            this.Patente = patente;
            this.Color = color;
            this.Marca = marca;
            this.Modelo = modelo;
            this.velocidad = 0;
        }

        public virtual void Acelerar(double cantidad)
        {
            Console.WriteLine("Incrementando la velocidad en {0} km/h", cantidad);
            this.velocidad += cantidad;
        }

        public void Girar(double cantidad)
        {
            Console.WriteLine("Girando el coche en {0} grados", cantidad);
        }

        public void Frenar(double cantidad)
        {
            Console.WriteLine("Reduciendo la velocidad en {0} km/h", cantidad);
            this.velocidad -= cantidad;
        }
    }
}
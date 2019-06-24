using System;
namespace POO
{
    public class CocheInteligente : Coche
    {
        public CocheInteligente(string patente, string color, string marca, string modelo) 
        : base(patente, color, marca, modelo)
        {
            
        }

        public void Estacionar()
        {
            Console.WriteLine("Estacionando el coche en modo automático");
            velocidad = 0;
        }

        public override void Acelerar(double cantidad)
        {
            Console.WriteLine("Accionando mecanismo avanzado de aceleración");
            Console.WriteLine("Incrementando la velocidad en {0} km/h", cantidad);
            this.velocidad += cantidad;
        }
    }
}
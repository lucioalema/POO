using System;
namespace POO
{
    public abstract class A
    {
        public abstract void F();
    }

    public abstract class B: A
    {
        public void G()
        {
            Console.WriteLine("Metodo G");
        }
    }

    public class C:B
    {
        public override void F()
        {
            Console.WriteLine("Metodo F");
        }
    }

    public class D:A
    {
        public override void F()
        {
            Console.WriteLine("Llamada a metodo F");
        }
    }
}
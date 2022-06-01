using System;

namespace ClaseAbstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            Forma c = new Circulo();
            c.Dibujar();
            Forma r = new Rectangulo();
            r.Dibujar();
        }
    }
}

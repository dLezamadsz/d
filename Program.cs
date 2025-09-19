using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositorio
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            while (a)
            {
                List<Item> carrito = new List<Item>();
                List<Item> tienda = new List<Item>();
                Tienda t = new Tienda(tienda);

                Console.WriteLine("Introducir la cantidad de dinero disponible:");
                float dinero = float.Parse(Console.ReadLine());
                float pagado = 0;

                Console.WriteLine("(1) Comprar item\n(2) Finalizar compra");
                string b = Console.ReadLine();
                switch (b)
                {
                    default: a = false;  break;
                    case "1": t.Compra(carrito, dinero, pagado); t.Carrito(carrito, dinero, pagado); break;
                    case "2": Console.WriteLine("¡Gracias por su compra!"); Console.ReadLine(); a = false; break;
                }
            }
        }
    }
}

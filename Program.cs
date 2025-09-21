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
            List<Item> carrito = new List<Item>();
            Item galletas = new Item("galleta", 20, 1.20f);
            Item papitas = new Item("papitas", 20, 1.70f);
            Item panpollo = new Item("pan con pollo", 20, 4.00f);
            Item triple = new Item("triple", 20, 4.50f);
            Item chocolate = new Item("chocolate", 20, 1.20f);
            Item mentas = new Item("mentas", 20, 1.20f);
            Item agua = new Item("agua", 20, 1.50f);
            Item gaseosa = new Item("gaseosa", 20, 1.70f);
            List<Item> tienda = new List<Item>() { galletas, papitas, panpollo, triple, chocolate, mentas, agua, gaseosa };
            Tienda t = new Tienda(tienda);

            Console.WriteLine("Introducir la cantidad de dinero disponible:");
            float dinero = float.Parse(Console.ReadLine());
            float pagado = 0;

            bool a = true;
            while (a)
            {
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

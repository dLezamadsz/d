using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositorio
{
    class Tienda
    {
        private List<Item> items = new List<Item>();

        public Tienda(List<Item> i)
        {
            this.items = i;
        }

        public void Compra(List<Item> c, float x, float y)
        {
            Console.WriteLine("Seleccionar item a comprar:");
            for (int i = 0; i < items.Count(); i++)
            {
                Console.WriteLine($"({i}) {items[i].Nombre()}");
            }
            int index = int.Parse(Console.ReadLine());

            if(x<items[index].Precio() || items[index].Cantidad() == 0)
            {
                Console.WriteLine("No se puede realizar la operación");
                Console.ReadLine();
            }
            else
            {
                for (int i = 0; i < items.Count(); i++)
                {
                    if (i == index)
                    {
                        c.Add(items[i]);
                        Console.WriteLine($"Se ha añadido el artículo {items[i].Nombre()} al carrito");
                        x -= items[i].Precio();
                        y += items[i].Precio();
                        items[i].Remover();
                    }
                }
            }
        }

        public void Carrito(List<Item> c, float x, float y)
        {
            Console.WriteLine("Carrito de compras:");
            foreach (var item in c)
            {
                Console.WriteLine(item.Nombre() + "....." + item.Precio());
            }
            Console.WriteLine("Usted ha pagado s/."+y+".");
        }
    }
}

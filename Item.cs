using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositorio
{
    class Item
    {
        private string nombre;
        private int cantidad;
        private float precio;

        public Item(string n, int x, float i)
        {
            this.nombre = n;
            this.cantidad = x;
            this.precio = i;
        }

        public string Nombre()
        {
            return nombre;
        }
        public float Precio()
        {
            return precio;
        }

        public int Cantidad()
        {
            return cantidad;
        }
        public void Remover()
        {
            cantidad--;
        }
    }
}

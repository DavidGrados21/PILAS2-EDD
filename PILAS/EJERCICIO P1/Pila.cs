using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PILAS.EJERCICIO_P1
{
    internal class Pila
    {
        private Nodo vinicio;
        public Nodo inicio
        {
            get { return vinicio; }
            set { vinicio = value; }
        }

        public Pila()
        {
            inicio = null;
        }

        public bool esVacia()
        {
            if (inicio == null)
            {
                return true;
            }
            else
                return false;
        }
        public void push(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            nuevo.sgte = inicio;
            inicio = nuevo;

        }
        public int pop()
        {
            int x;
            x = inicio.info;
            inicio = inicio.sgte;
            return x;
        }
        public void mostrar(ListBox lst)
        {
            Nodo actual = inicio;
            lst.Items.Clear();
            while (actual != null)
            {
                lst.Items.Add(actual.info);
                actual = actual.sgte;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd
{
    public class Iterator<T>
    {
        private NodoL<T> Nodo;
        public Iterator(NodoL<T> posicion)
        {
            this.Nodo = posicion;
        }
        public bool HasNext()
        {
            return (Nodo != null);
        }
        public T Next()
        {
            if (!this.HasNext())
            {
                Console.WriteLine("No hay mas elementos");
                return default(T);
            }
            NodoL<T> nodoActual = Nodo;
            Nodo = Nodo.GetSig();
            return (nodoActual.GetInfo());
        }
    }
}

using System.Linq;
namespace Arboles
{
    internal class ManejadorArbol
    {
        public static int ContarHojas(Nodo nodo)
        {
            int acumulador = 0;
            foreach (Nodo actual in nodo.Hijos)
            {
                acumulador += actual.Valor.Count() + actual.Hijos.Count();
            }
            return acumulador;
        }
        public static int ContarNodos(Nodo nodo)
        {
            int acumulador = 0;
            acumulador += nodo.nodoRaiz + nodo.Hijos.Count();
            foreach (Nodo actual in nodo.Hijos)
            {
                acumulador += actual.Hijos.Count;
            }
            return acumulador;
        }
        public static int ContarNiveles(Nodo nodo)
        {
            int acumulador = 0;
            foreach (Nodo actual in nodo.Hijos)
            {
                acumulador += actual.Valor.Count();
            }
            return acumulador;
        }
    }
}
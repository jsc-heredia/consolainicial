using System.Collections.Generic;
namespace Arboles
{
    class Nodo
    {
        public List<Nodo> Nodos { get; set; } = new List<Nodo>();
        public string Valor { get; set; }
        public List<Nodo> Hijos { get; set; } = new List<Nodo>();
        public int nodoRaiz = 1;
    }
}
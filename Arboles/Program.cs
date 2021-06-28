using System;

namespace Arboles
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo raiz = new()
            {
                Valor = "/",
                Hijos ={
                    new Nodo{
                        Valor="*",
                        Hijos={
                            new Nodo{
                                Valor="1"
                            },
                            new Nodo{
                                Valor ="6"
                            }
                        }
                    },
                    new Nodo{
                        Valor ="-",
                        Hijos={
                            new Nodo{
                                Valor="4"
                            },
                            new Nodo{
                                Valor="5"
                            }
                        }
                    },
                    new Nodo{
                        Valor="+",
                        Hijos={
                            new Nodo{
                                Valor="3"
                            },
                            new Nodo{
                                Valor="8"
                            }

                        }
                    }

                },
            };
            ManejadorArbol controladorArbol = new();
            Console.WriteLine($"Numero de hojas : {ManejadorArbol.ContarHojas(raiz)}");
            Console.WriteLine($"Niveles del arbol : {ManejadorArbol.ContarNiveles(raiz)}");
            Console.WriteLine($"Cantidad de nodos : {ManejadorArbol.ContarNodos(raiz)}");
        }
    }
}
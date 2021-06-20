using System;

namespace MiPrimerApp.Consola
{
    class Persona
    {
        public string nombre;
        public int edad;
        public float peso;
        public string direccion;
        public int familia;
        public float estatura;
        public int cantidadMascotas;
        public string superheroeFavorito;
        public int cantidadAmigos;
        public string ciudad;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido!");
            Console.Write("Ingrese su nombre: ");
            var nombre = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            string edad = Console.ReadLine();
            int edad1 = int.Parse(edad);
            Console.Write("Ingrese su peso: ");
            float peso = float.Parse(Console.ReadLine());
            var persona = new Persona();
            Console.Write("Ingrese su direccion: ");
            var direccion = Console.ReadLine();
            Console.Write("Cuantas personas viven con usted? ");
            int familia = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su estatura: ");
            float estatura = float.Parse(Console.ReadLine());
            Console.Write("Cuantas mascotas tiene?: ");
            int mascotas = int.Parse(Console.ReadLine());
            Console.Write("Cual es su superheroe favorito?: ");
            var heroe = Console.ReadLine();
            Console.Write("Cuantos amigos tiene? ");
            int amigos = int.Parse(Console.ReadLine());
            Console.Write("De que ciudad es? ");
            var ciudad = Console.ReadLine();
            persona.nombre = nombre;
            persona.edad = edad1;
            persona.peso = peso;
            persona.direccion = direccion;
            persona.familia = familia;
            persona.estatura = estatura;
            persona.cantidadMascotas = mascotas;
            persona.superheroeFavorito = heroe;
            persona.cantidadAmigos = amigos;
            persona.ciudad = ciudad;
            Console.WriteLine("**Usted ingreso lo siguiente** ");
            Console.Write("Nombre: " + persona.nombre + "\n");
            Console.Write("Edad: " + persona.edad + "\n");
            Console.Write("Peso: " + persona.peso + " kilogramos" + "\n");
            Console.Write("Direccion: " + persona.direccion + "\n");
            Console.Write("Con usted viven: " + persona.familia + " personas" + "\n");
            Console.Write("Su estatura es:  " + persona.estatura + " metros" + "\n");
            Console.Write("Usted tiene: " + persona.mascota + "\n");
            Console.Write("Su color favorito es: " + persona.color + "\n");
            Console.Write("Usted tiene: " + persona.amigos + " amigos" + "\n");
            Console.Write("Su ciudad es: " + persona.ciudad + "\n");
            Console.WriteLine("Gracias por usarlo, presione cualquier tecla para salir.");
            Console.ReadKey();

            /*if (args.Length > 0)
             {
                 Console.WriteLine("Hola " + args[0]);
             }
             else
             {
                 Console.WriteLine("Hola desconocido");
             }
             Console.WriteLine("Como estas?");
             var estado = Console.ReadLine();
             Console.WriteLine("hmmm, entiendo...");
             Console.ReadLine();*/
        }
    }
}

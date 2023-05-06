using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03_Karenia
{
    class Computadora
    {
        int Capacidad;
        int EspacioDisco;
        bool Encendido;
        public Computadora() { }
        public Computadora(int capacidad, int espacioDisco, bool Encendido)
        {
            Capacidad1 = capacidad;
            EspacioDisco1 = espacioDisco;
            this.Encendido = Encendido;
        }

        public int Capacidad1 { get => Capacidad; set => Capacidad = value; }
        public int EspacioDisco1 { get => EspacioDisco; set => EspacioDisco = value; }
        public bool Encendido1 { get => this.Encendido; set => this.Encendido = value; }

        public void PreguntarEncendido()
        {
            if (this.Encendido)
            {
                Console.WriteLine("La computadora no está encendida");

            }
            else
            {
                this.Encendido = true;
                Console.WriteLine("Bienvenido...");
            }
            Console.ReadLine();
        }
        public void PreguntarApagado()
        {
            Console.WriteLine("¿Quiere apagar la computadora?: ");
            string c = Console.ReadLine();
            if (c == "S" || c == "s")
            {
                this.Encendido = false;
                Console.WriteLine("La computadora se apagó");
            }
            else
            {
                this.Encendido = true;
                Console.WriteLine("La computadora está encendida");
            }
            Console.ReadLine();
        }
        public void AnadirDatos(int datos)
        {
            if (this.Encendido)
            {
                if (datos <= this.Capacidad)
                {
                    this.EspacioDisco = this.Capacidad - datos;
                    Console.WriteLine("Se añadió el archivo {0} y el espacio disponible es: {1}", datos, this.EspacioDisco);
                }
                else
                {
                    Console.WriteLine("No hay espacio disponible");
                }
            }
            else
            {
                Console.WriteLine("La computadora está apagada");
            }
        }
        public void EliminarDato(int datos)
        {
            if (this.Encendido)
            {
                if (datos <= this.EspacioDisco)
                {
                    this.EspacioDisco = this.Capacidad + datos;
                    Console.WriteLine("El espacio disponible se actualizó: " + this.EspacioDisco);
                }
                else
                {
                    Console.WriteLine("No hay espacio disponible");
                }
            }
            else
            {
                Console.WriteLine("La computadora está apagada");
            }
        }
    }
}

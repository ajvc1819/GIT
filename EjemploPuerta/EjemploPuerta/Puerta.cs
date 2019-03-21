using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPuerta
{
    class Puerta
    {
       protected int ancho; 
       protected int alto; 
       protected int color; 
       protected bool abierta;

        public Puerta()
        {
            ancho = 50;
            alto = 208;
            //Aqui he hecho un cambio de color de la puerta
            color = 0000000;
            abierta = false;
        }
        public Puerta(int an, int al)
        {
            ancho = an;
            alto = al;
            color = 0xFFFFFF;
            abierta = false;
        }
        public void Abrir()
        {
            abierta = true;
        }
        public void Cerrar()
        {
            abierta = false;
        }
        public int GetAncho()
        {
            return ancho;
        }
        public void SetAncho(int nuevoValor)
        {
            ancho = nuevoValor;
        }
        public void MostrarEstado()
        {
            Console.WriteLine("Ancho: {0}", ancho);
            Console.WriteLine("Alto: {0}", alto);
            Console.WriteLine("Color: {0}", color);
            Console.WriteLine("Abierta: {0}", abierta);
        }
    }
}

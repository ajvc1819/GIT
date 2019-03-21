using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPuerta
{
    class Porton : Puerta
    {
        bool bloqueada;
       
        public void Bloquear()
        {
            bloqueada = true;
        }
        public void Desbloquear()
        {
            bloqueada = false;
        }
       public new void MostrarEstado()
       {
            Console.WriteLine("Portón.");
            Console.WriteLine("Bloqueada: {0}", bloqueada);
            Console.WriteLine("Ancho: {0}", ancho);
            Console.WriteLine("Alto: {0}", alto);
            Console.WriteLine("Color: {0}", color);
            Console.WriteLine("Abierta: {0}", abierta);
        }
    }
}

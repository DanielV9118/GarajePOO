using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaje.Clases
{
    public class Garaje
    {
       
        private int numeroGaraje;
        private string descripcion;
        private int capacidadEspacios;
        private int espaciosOcupados;

       
        public Garaje(int numeroGaraje, string descripcion, int capacidadEspacios, int espaciosOcupados)
        {
            this.numeroGaraje = numeroGaraje;
            this.descripcion = descripcion;
            this.capacidadEspacios = capacidadEspacios;
            this.espaciosOcupados = espaciosOcupados;
        }

       
        public int EspaciosDisponibles()
        {
            return capacidadEspacios - espaciosOcupados;
        }

        // Método para actualizar los espacios ocupados
        public void ActualizarEspacios(int solicitados)
        {
            if (espaciosOcupados + solicitados <= capacidadEspacios)
            {
                espaciosOcupados += solicitados;
                Console.WriteLine($"Se han ocupado {solicitados} espacios. Ahora hay {EspaciosDisponibles()} disponibles.");
            }
            else
            {
                Console.WriteLine("No hay suficientes espacios disponibles.");
            }
        }
    }
}




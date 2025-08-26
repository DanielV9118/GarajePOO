using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaje.Clases
{
    public class Garaje
    {
        //atributos: número de garaje, descripción, capacidad de espacios, espacios ocupados
        public int NumeroGaraje { get; set; }
        public string Descripcion { get; set; }
        public int CapacidadEspacios { get; set; }
        public int EspaciosOcupados { get; set; }

       
        public Garaje(int numeroGaraje, string descripcion, int capacidadEspacios, int espaciosOcupados)
        {
            NumeroGaraje = numeroGaraje;
            Descripcion = descripcion;
            CapacidadEspacios = capacidadEspacios;
            EspaciosOcupados = espaciosOcupados;
        }

        // Método para retornar espacios disponibles
        public int EspaciosDisponibles()
        {
            return CapacidadEspacios - EspaciosOcupados;
        }

        // Método para actualizar espacios ocupados
        public void ActualizarEspaciosOcupados(int espaciosSolicitados)
        {
            EspaciosOcupados += espaciosSolicitados;
        }
    }
}
    
    
    
    



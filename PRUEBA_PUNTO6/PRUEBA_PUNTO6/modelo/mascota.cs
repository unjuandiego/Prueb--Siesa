using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRUEBA.modelo
{
    public class mascota
    {
        public int id_mascota { get; set; }
        public string nombre { get; set; }
        public int id_tipomascota { get; set; }
        public int id_propietario { get; set; }
        public string adoptada { get; set; }

    }
}

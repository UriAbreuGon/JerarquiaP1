using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JerarquiaP1
{
    public   class Docente: Empleado
    {
        public string? NivelEducativo { get; set; }
        public List<string>? MateriasAsignadas { get; set; }

    }
}

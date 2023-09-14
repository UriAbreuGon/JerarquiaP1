using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JerarquiaP1
{
    public class Estudiante: MiembroDeLaComunidad
    {
        public string? Matricula { get; set; }
        public int TotalAsistencias { get; set; }

    }
}



namespace ProyectoRH_Pertec.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tpuestofecha
    {
        public int PEfechaXempresaID { get; set; }
        public int PEempleadoID { get; set; }
        public Nullable<int> PEpuestoID { get; set; }
        public Nullable<System.DateTime> PEfechainicio { get; set; }
        public Nullable<System.DateTime> PEfechafin { get; set; }
    
        public virtual Templeado Templeado { get; set; }
    }
}

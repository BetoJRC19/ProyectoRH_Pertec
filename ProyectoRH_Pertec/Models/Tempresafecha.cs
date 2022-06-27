namespace ProyectoRH_Pertec.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tempresafecha
    {
        public Nullable<System.DateTime> IEfechaingreso { get; set; }
        public Nullable<System.DateTime> IEfechaegreso { get; set; }
        public string IEmotivo { get; set; }
        public int IEempleadoID { get; set; }
    
        public virtual Templeado Templeado { get; set; }
    }
}

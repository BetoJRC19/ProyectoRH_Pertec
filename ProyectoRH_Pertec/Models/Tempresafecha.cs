//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

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

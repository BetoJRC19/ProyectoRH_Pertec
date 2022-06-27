
namespace ProyectoRH_Pertec.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tpuesto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tpuesto()
        {
            this.Templeadoes = new HashSet<Templeado>();
        }
    
        public int PpuestoID { get; set; }
        public string Pnombre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Templeado> Templeadoes { get; set; }
    }
}

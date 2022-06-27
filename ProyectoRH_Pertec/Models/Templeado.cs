

namespace ProyectoRH_Pertec.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Templeado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Templeado()
        {
            this.Tpuestofechas = new HashSet<Tpuestofecha>();
        }
    
        public int EempleadoID { get; set; }
        public string Enombre { get; set; }
        public string Eapellido { get; set; }
        public string Eapellido2 { get; set; }
        public string Etelefono { get; set; }
        public string Ecorreo { get; set; }
        public int EpuestoID { get; set; }
    
        public virtual Tpuesto Tpuesto { get; set; }
        public virtual Tempresafecha Tempresafecha { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tpuestofecha> Tpuestofechas { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeleCom.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class ТочкаПодключения
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ТочкаПодключения()
        {
            this.Оборудование = new HashSet<Оборудование>();
        }
    
        public int ID_точка { get; set; }
        public System.Data.Entity.Spatial.DbGeography Координаты { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Оборудование> Оборудование { get; set; }
    }
}

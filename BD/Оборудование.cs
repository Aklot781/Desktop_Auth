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
    
    public partial class Оборудование
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Оборудование()
        {
            this.Заявки = new HashSet<Заявки>();
            this.ПортыВоборудовании = new HashSet<ПортыВоборудовании>();
        }
    
        public int ID_Оборудования { get; set; }
        public string Наименование_оборудования { get; set; }
        public int Тип_оборудования { get; set; }
        public string Серийный_номер { get; set; }
        public string MAC { get; set; }
        public string IP { get; set; }
        public string Номер_телефонов { get; set; }
        public System.DateTime Дата_установки { get; set; }
        public int ID_точка { get; set; }
        public int Количество_портов { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заявки> Заявки { get; set; }
        public virtual ТипОборудования ТипОборудования { get; set; }
        public virtual ТочкаПодключения ТочкаПодключения { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ПортыВоборудовании> ПортыВоборудовании { get; set; }
    }
}

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
    
    public partial class ПортыВоборудовании
    {
        public int ID_Порты { get; set; }
        public int ID_порт { get; set; }
        public int ID_Оборудования { get; set; }
    
        public virtual Оборудование Оборудование { get; set; }
        public virtual Порты Порты { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArendaSamokatov.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public System.DateTime PaymentDate { get; set; }
        public byte PaymentMethodID { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
    }
}

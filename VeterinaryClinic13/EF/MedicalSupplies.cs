//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VeterinaryClinic13.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class MedicalSupplies
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MedicalSupplies()
        {
            this.OrderItem = new HashSet<OrderItem>();
        }
    
        public int IdMedSupplies { get; set; }
        public string MedSupplierName { get; set; }
        public string Description { get; set; }
        public string UnitMeas { get; set; }
        public short Quantity { get; set; }
        public decimal Price { get; set; }
    
        public virtual UnitOfMeasurement UnitOfMeasurement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
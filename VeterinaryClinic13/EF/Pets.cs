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
    
    public partial class Pets
    {
        public int IdPets { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string Gender { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
    
        public virtual GenderPets GenderPets { get; set; }
        public virtual Type Type1 { get; set; }
    }
}

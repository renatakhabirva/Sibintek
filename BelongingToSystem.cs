//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sibintek
{
    using System;
    using System.Collections.Generic;
    
    public partial class BelongingToSystem
    {
        public BelongingToSystem()
        {
            this.Classifier = new HashSet<Classifier>();
        }
    
        public int BelongingToSystemID { get; set; }
        public string BelongingToSystem1 { get; set; }
        public int BelongingToSystemPoint { get; set; }
    
        public virtual ICollection<Classifier> Classifier { get; set; }
    }
}
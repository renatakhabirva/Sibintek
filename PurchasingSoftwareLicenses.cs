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
    
    public partial class PurchasingSoftwareLicenses
    {
        public PurchasingSoftwareLicenses()
        {
            this.Classifier = new HashSet<Classifier>();
        }
    
        public int PurchasingSoftwareLicensesID { get; set; }
        public string PurchasingSoftwareLicenses1 { get; set; }
        public int PurchasingSoftwareLicensesPoint { get; set; }
    
        public virtual ICollection<Classifier> Classifier { get; set; }
    }
}

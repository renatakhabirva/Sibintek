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
    
    public partial class InternetAccess
    {
        public InternetAccess()
        {
            this.Classifier = new HashSet<Classifier>();
        }
    
        public int InternetAccessID { get; set; }
        public string InternetAccess1 { get; set; }
        public int InternetAccessPoint { get; set; }
    
        public virtual ICollection<Classifier> Classifier { get; set; }
    }
}
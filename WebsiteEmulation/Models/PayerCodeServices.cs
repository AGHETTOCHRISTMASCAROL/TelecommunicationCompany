//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebsiteEmulation.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PayerCodeServices
    {
        public byte id { get; set; }
        public string payerCode { get; set; }
        public short idService { get; set; }
    
        public virtual PayerCode PayerCode1 { get; set; }
        public virtual Service Service { get; set; }
    }
}

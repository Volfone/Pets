//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pets.ADOApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int Order_ID { get; set; }
        public int User_ID { get; set; }
        public int Pet_ID { get; set; }
    
        public virtual Pets Pets { get; set; }
        public virtual Users Users { get; set; }
    }
}

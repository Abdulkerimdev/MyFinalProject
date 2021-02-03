using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product
    {
        //public yaptığımızda, bu class'a diğer katmanlardan da erişilebilir oluyor.
        //entities diğer katmanlardan da kullanılacağı için public yapıyoruz.
        //BİR CLASS'IN DEFAULT hali internal'dır. 
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }//int değişkeninin bir küçüğü
        public decimal UnitPrice { get; set; }
    }
}

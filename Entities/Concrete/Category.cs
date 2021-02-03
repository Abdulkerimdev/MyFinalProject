using Entities.Abstract;//burayı yazmazsak public class Category:IEntity hata verir görmez. 
//Orayı işaretleyip görmesini sağlamış oluyoruz.
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        //Çıplak Class Kalmasın =D
        //Bunları gruplandırmalıyız. Bi yere bağlı olmalıdır. Yani burası bir tablonun birbirine...
        // ...bağlı kısımları olmalı. O yüzden Category:Entity yazdık.
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}

using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity // IEntity bir veritabanı nesnesi olduğunu anlatıyor.
                                 // Bütün projelerde veritabanı kullanacağım Bu yüzden bu projeye bağımlı olmayan Core tarafında o katman için oluşturduğumuz klasörün içine koyacağız.
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }

    }
}

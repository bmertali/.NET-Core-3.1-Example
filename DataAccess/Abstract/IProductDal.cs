using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // Temel veriye erişim operasyonlarımızı oluşturuyor olacağız.
    // Generic repository'ler projeye bağımlı değildir. Core katmanında oluşturacağız.
    public interface IProductDal:IEntityRepository<Product> 
    {

    }
}

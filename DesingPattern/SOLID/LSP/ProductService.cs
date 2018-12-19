using System;
using System.Collections.Generic;
using System.Text;

#region Açıklama
//Interface Segregation Principle (ISP) burada ki kod içerisinde yapıldı.
//ISP ve LSP (Liskov Substitution Principle ) birbirine yakın prensipler. 
//LSP => Liskov Yerine ikame etme prensibi
//ISP => İnterface Ayırma Prensibi 
#endregion

namespace SOLID.LSP
{
    public interface IReadableProductService    
    {
        Product Get();
    }

    public interface IWriteableProductService
    {
        void Add(Product product);
    }

    public class ReadOnlyProductService : IReadableProductService
    {
        public Product Get()
        {
            Product p = new Product();
            //Do something
            return p;
        }
    }

    public class ReadWriteProductService : IReadableProductService, IWriteableProductService
    {
        public void Add(Product product)
        {
            //Add Product to Database
        }

        public Product Get()
        {
            Product p = new Product();
            //Do something
            return p;
        }
    }


}

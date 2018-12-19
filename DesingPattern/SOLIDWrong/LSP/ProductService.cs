using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDWrong.LSP
{
    public class ProductService
    {
        public virtual void Add(Product product)
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

    public class ReadOnlyProductService : ProductService
    {
        public override void Add(Product product)
        {

        }
    }
}

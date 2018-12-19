using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDWrong.LSP
{
    public class Product
    {
        private readonly double productPrice = 100;

        public double GetPrice(int discountCode)
        {
            if (discountCode == 1)
            {
                return productPrice - (productPrice / 10); // Yüzde 10 indirim
            }
            else
            {
                return productPrice;
            }
        }
    }
}

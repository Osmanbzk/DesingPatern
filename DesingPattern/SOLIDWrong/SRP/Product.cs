using SOLID.Support;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDWrong.SRP
{
   public class Product
    {
        public int StockLevel;

        public void CheckStockLevel()
        {
            using (StockService s = new StockService())
            {
                StockLevel = s.GetStock();
            }
        }

        public bool StockLow()
        {
            return StockLevel < 5;
        }

        public void ShowStockAlert()
        {
            Console.WriteLine("Stock Level is {0}", StockLevel);
        }
    }
}

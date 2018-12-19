using SOLID.Support;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SRP
{
    public class SRP
    {
        public class StockChecker
        {
            public int StockLevel;
            public void CheckStockLevel()
            {
                using (StockService s = new StockService())
                {
                    StockLevel = s.GetStock();
                }
            }
        }

        public class StockLevelChecker
        {
            public bool StockChecker(StockChecker sc)
            {
                return sc.StockLevel < 5;

            }
        }

        public class StockAlert
        {
            public void ShowStockAlert(StockChecker sc)
            {
                Console.WriteLine("Stock is Low {0}", sc.StockLevel);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Support
{
   public class StockService: IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int GetStock()
        {
            return 4;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_CommonEntity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int ProductDimensionX { get; set; }
        public int ProductDimensionY { get; set; }
        public int ProductDimensionZ { get; set; }
        public string ProductFsc { get; set; }
        public string ProductUnit { get; set; }
        public string ProductFlute { get; set; }
        public string ProductShape { get; set; }
        public int ProductPrize { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_CommonEntity
{
    public class MaterialsInOrder
    {
        public int MaterialsinorderId { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialDimension { get; set; }
        public int MaterialPrize { get; set; }
        public int MaterialQuantitySend { get; set; }
        public int MaterialAmount { get; set; }
        public int MaterialQuantityReceive { get; set; }
        public string MaterialNote { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_CommonEntity
{
    public class Material
    {
        public int MaterialId { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public int MaterialDimensionX { get; set; }
        public int MaterialDimensionY { get; set; }
        public string MaterialFsc { get; set; }
        public string MaterialUnit { get; set; }
        public string MaterialFlute { get; set; }
        public string MaterialStructure { get; set; }
        public int MaterialPrize { get; set; }
    }
}

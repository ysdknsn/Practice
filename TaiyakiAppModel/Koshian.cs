using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiyakiAppModel
{
    public class Koshian
    {
        public Koshian(FixedValue.Size 小)
        {
        }

        public FixedValue.Size Size { get; set; }
        public string Name { get; set; }

        public int GetPrice()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiyakiAppModel
{
    public class Koshian : Taiyaki
    {
        public Koshian(FixedValue.Size size)
        {
            _size = size;
            _price = FixedValue.KOSHIAN_PRICE;
        }

        public override string Name
            => FixedValue.KOSHIAN_NAME;
    }
}

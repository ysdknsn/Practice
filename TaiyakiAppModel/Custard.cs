using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiyakiAppModel
{
    public class Custard : Taiyaki
    {
        public Custard(FixedValue.Size size)
        {
            _size = size;
            _price = FixedValue.CUSTARD_PRICE;
        }

        public override string Name
            => FixedValue.CUSTARD_NAME;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiyakiAppModel
{
    public class BeanPaste : Taiyaki
    {
        public BeanPaste(FixedValue.Size size)
        {
            _size = size;
            _price = FixedValue.BEAN_PASTE_PRICE;
        }

        public override string Name
            => FixedValue.BEAN_PASTE_NAME;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiyakiAppModel
{
    public abstract class Taiyaki
    {
        public FixedValue.Size Size
            => _size;
        public abstract string Name { get; }
        public int GetPrice()
        {
            switch (_size)
            {
                case FixedValue.Size.小:
                    return _price - 20;

                case FixedValue.Size.大:
                    return _price + 20;

                default:
                    return _price;
            }
        }

        protected int _price;
        private FixedValue.Size _size;
    }
}

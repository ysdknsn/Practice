using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiyakiAppModel
{
    public class Custard
    {
        public Custard(FixedValue.Size 小)
        {
        }

        public string Name
            => "";

        public FixedValue.Size Size { get; set; }

        public int GetPrice()
        {
            throw new NotImplementedException();
        }
    }
}
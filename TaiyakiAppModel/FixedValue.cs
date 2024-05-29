using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiyakiAppModel
{
    public static class FixedValue
    {
        //大：+20、中+0、小-20
        public enum Size
        {
            大,中,小
        }

        public const int CUSTARD_PRICE = 180;
        public const int BEAN_PASTE_PRICE = 160;
    }
}

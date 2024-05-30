using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaiyakiAppModel;

namespace TaiyakiAppTest
{
    public class KoshianTest
    {
        [Fact]
        public void SmallConstructor()
        {
            var koshian = new Koshian(FixedValue.Size.小);
            
            Assert.Equal(FixedValue.KOSHIAN_NAME, koshian.Name);
            Assert.Equal(140, koshian.GetPrice());
            Assert.Equal(FixedValue.Size.小, koshian.Size);
        }

        [Fact]
        public void NormalConstructor()
        {
            var koshian = new Koshian(FixedValue.Size.中);

            Assert.Equal(FixedValue.KOSHIAN_NAME, koshian.Name);
            Assert.Equal(160, koshian.GetPrice());
            Assert.Equal(FixedValue.Size.中, koshian.Size);
        }

        [Fact]
        public void BigConstructor()
        {
            var koshian = new Koshian(FixedValue.Size.大);

            Assert.Equal(FixedValue.KOSHIAN_NAME, koshian.Name);
            Assert.Equal(180, koshian.GetPrice());
            Assert.Equal(FixedValue.Size.大, koshian.Size);
        }
    }
}

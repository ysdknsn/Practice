using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaiyakiAppModel;

namespace TaiyakiAppTest
{
    public class BeanPasteTest
    {
        [Fact]
        public void SmallConstructorTest()
        {
            var beanPaste = new BeanPaste(FixedValue.Size.小);

            Assert.Equal(FixedValue.BEAN_PASTE_NAME, beanPaste.Name);
            Assert.Equal(140, beanPaste.GetPrice());
            Assert.Equal(FixedValue.Size.小, beanPaste.Size);
        }

        [Fact]
        public void NormalConstructorTest()
        {
            var beanPaste = new BeanPaste(FixedValue.Size.中);

            Assert.Equal(FixedValue.BEAN_PASTE_NAME, beanPaste.Name);
            Assert.Equal(160, beanPaste.GetPrice());
            Assert.Equal(FixedValue.Size.中, beanPaste.Size);
        }

        [Fact]
        public void BigConstructorTest()
        {
            var beanPaste = new BeanPaste(FixedValue.Size.大);

            Assert.Equal(FixedValue.BEAN_PASTE_NAME, beanPaste.Name);
            Assert.Equal(180, beanPaste.GetPrice());
            Assert.Equal(FixedValue.Size.大, beanPaste.Size);
        }
    }
}

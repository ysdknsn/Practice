using TaiyakiAppModel;

namespace TaiyakiAppTest
{
    public class CustardTest
    {
        [Fact]
        public void SmallConstructor()
        {
            var custard = new Custard(FixedValue.Size.小);

            Assert.Equal(FixedValue.CUSTARD_NAME, custard.Name);
            Assert.Equal(160, custard.GetPrice());
            Assert.Equal(FixedValue.Size.小, custard.Size);
        }

        [Fact]
        public void NormalConstructor()
        {
            var custard = new Custard(FixedValue.Size.中);

            Assert.Equal(FixedValue.CUSTARD_NAME, custard.Name);
            Assert.Equal(180, custard.GetPrice());
            Assert.Equal(FixedValue.Size.中, custard.Size);
        }

        [Fact]
        public void BigConstructor()
        {
            var custard = new Custard(FixedValue.Size.大);

            Assert.Equal(FixedValue.CUSTARD_NAME, custard.Name);
            Assert.Equal(200, custard.GetPrice());
            Assert.Equal(FixedValue.Size.大, custard.Size);
        }
    }
}

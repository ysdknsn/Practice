using TaiyakiAppModel;

namespace TaiyakiAppTest
{
    public class CustardTest
    {
        [Fact]
        public void Constructor()
        {
            var custard = new Custard();

            Assert.Equal("カスタード", custard.Name);
            Assert.Equal(180, custard.Price);
        }
    }
}

using NUnit.Framework;
using AsyncHesapMakinesi;

namespace AsyncHesapMakinesi_Test
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Arrange
            HesapMakinesi hm = new HesapMakinesi();
        }

        [Test]
        public async void AsyncHesapMakinesi_IslemDogrumu_ReturnsTrue()
        {
            await Assert.That(Is.EqualTo((object).'+'));
        }
    }
}
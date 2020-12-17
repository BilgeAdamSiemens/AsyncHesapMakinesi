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
        [TestCase(10, 30, '+', 30)]
        [TestCase(30, 30, '-', 0)]
        [TestCase(12, 30, '*', 360)]
        [TestCase(20, 5, '/', 4)]
        public async Task AsyncHesapMakinesi_DegiskenlerVeriliyor_ReturnsTrue()
        {
            // Act
            
            // Assert
        }
    }
}

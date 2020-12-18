using AsyncHesapMakinesi;
using NUnit.Framework;
using System.Threading.Tasks;

namespace AsyncHesapMakinesi_Test
{

    [TestFixture]
    public class AsyncHesapMakinesi_Test
    {

        [Test]
        [TestCase(10, 10, '+', 20)]
        [TestCase(20, 10, '-', 10)]
        [TestCase(20, 10, '*', 200)]
        [TestCase(200, 10, '-', 20)]
        public async Task AsyncHesapMakinesi_IslemDogrumu_ReturnsTrue(double s1, double s2, char i, Task<double> s)
        {
            HesapMakinesi hm = new HesapMakinesi(s1, s2, i, s);
            s.Wait();

        }
    }
}

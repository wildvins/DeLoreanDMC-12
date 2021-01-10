using System.Threading;
using NUnit.Allure.Core;

namespace Tests
{
    using NUnit.Framework;
    [TestFixture]
    [AllureNUnit]
    public class TestsExamples
    {
        [Test]
        [Category("smoke")]
        public void GetCompanyInvoices()
        {
            Thread.Sleep(1000);
            Assert.Fail("test fail");
        }

        [Test]
        [Category("smoke")]
        public void GetCompanyInvoices2()
        {
            Thread.Sleep(1000);
            Assert.Pass("test pass");
        }
    }
}

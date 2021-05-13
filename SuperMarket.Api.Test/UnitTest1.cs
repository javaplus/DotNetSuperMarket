using System.ComponentModel;
using NUnit.Framework;
using SuperMarket.API.Domain.Services;
namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            
            //Category cat = new Category();
            CalculateCostService service = new CalculateCostService();

            int result = service.calc(1,2);
            Assert.AreEqual(3, result);
        }
    }
}
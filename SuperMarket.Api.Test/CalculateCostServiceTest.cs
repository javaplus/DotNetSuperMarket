using System.ComponentModel;
using NUnit.Framework;
using SuperMarket.API.Domain.Services;
namespace Tests
{
    public class CalculateCostServiceTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void CalculatCostService_1Plus2Returns3()
        {
            
            //Category cat = new Category();
            CalculateCostService service = new CalculateCostService();

            int result = service.calc(1,2);
            Assert.AreEqual(3, result);
        }
    }
}

using NUnit.Framework;
using TaxAppSolution;

namespace TaxAppTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Calcuakte_Book_Imported()
        {
            IProductFactory productFactory = new ProductFactory();
            Product book = productFactory.GetProduct("book", 10, 3, GoodsType.Book, true);
            decimal expectedTax = 1.5m;
            var actualTax = book.CalculateTax();

            Assert.AreEqual(expectedTax, actualTax);
        }
    }
}
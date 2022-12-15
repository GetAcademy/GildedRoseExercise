using GildedRoseKata;

namespace GildedRoseTest
{
    public class GildedRoseTest
    {
        [Test]
        [TestCase("terje", 5, 10, 4, 9)]
        public void MainTest(string name, 
            int sellIn, int quality, 
            int expectedSellIn, int expectedQuality)
        {
            // arrange
            var item = new Item { Name = "foo", SellIn = 5, Quality = 10 };
            var items = new List<Item> {item};

            // act
            var app = new GildedRose(items);
            app.UpdateQuality();

            // assert
            Assert.That(item.Quality, Is.EqualTo(9));
        }
    }
}
using System.Collections.ObjectModel;
using GildedRoseKata.Context;
using GildedRoseKata.Domain;
using GildedRoseKata.Presentation;
using NUnit.Framework;

namespace GildedRoseKata.Tests.Editor
{
    [TestFixture]
    public class GildedRoseShould
    {
        [Test]
        public void Rename_Me()
        {
            Assert.Pass();
        }

        [TestCase(5, 4)]
        [TestCase(10, 9)]
        public void Item_Should_Have_Quality_Decreased_When_Time_Passes(int quality, int expectedQuality)
        {
            var item = new Item("", 5, quality);
            var gildedRose = CreateGildedRoseWithAnItem(item);

            gildedRose.UpdateQuality();

            Assert.AreEqual(expectedQuality, item.Quality);
        }

        [Test]
        public void Item_Never_Has_Quality_Less_Than_0()
        {
            var item = new Item("", 5, 0);
            var gildedRose = CreateGildedRoseWithAnItem(item);

            gildedRose.UpdateQuality();

            Assert.AreEqual(0, item.Quality);
        }

        [TestCase(5, 4)]
        [TestCase(10, 9)]
        public void Item_Should_Have_SellIn_Decreased_When_Time_Passes(int sellIn, int expectedSellIn)
        {
            var item = new Item("", sellIn, 5);
            var gildedRose = CreateGildedRoseWithAnItem(item);

            gildedRose.UpdateQuality();

            Assert.AreEqual(expectedSellIn, item.SellIn);
        }

        [TestCase(5, 3)]
        [TestCase(10, 8)]
        public void When_Item_SellIn_Is_Zero_Quality_Is_Degrading_Twice_As_Fast_When_Time_Passes(int quality, int expectedQuality)
        {
            var item = new Item("", 0, quality);
            var gildedRose = CreateGildedRoseWithAnItem(item);

            gildedRose.UpdateQuality();

            Assert.AreEqual(expectedQuality, item.Quality);
        }

        // NOT TESTED NOT FINISHED! ! ! ! !
        [TestCase(5, 3)]
        [TestCase(10, 8)]
        public void When_Item_Is_Aged_Brie_Quality_Increases_When_Time_Passes(int quality, int expectedQuality)
        {
            var item = new Item("Aged Brie", 5, quality);
            var gildedRose = CreateGildedRoseWithAnItem(item);

            gildedRose.UpdateQuality();

            Assert.Greater(item.Quality, quality);
        }

        private GildedRose CreateGildedRoseWithAnItem(Item item)
        {
            return new GildedRose(new Collection<Item> { item });
        }
    }
}

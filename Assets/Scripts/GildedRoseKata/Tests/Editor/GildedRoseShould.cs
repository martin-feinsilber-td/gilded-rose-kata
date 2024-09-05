using System.Collections.Generic;
using GildedRoseKata.Domain;
using GildedRoseKata.Presentation;
using NUnit.Framework;

namespace GildedRoseKata.Tests.Editor
{
    [TestFixture]
    public class GildedRoseShould 
    {
        [TestCase(2, 4)]
        public void Not_Have_Negative_Item_Quality(int initQuality, int daysPassed)
        {
            Item testItem = new Item("Test Item", 20, initQuality);
            GildedRose gildedRose = new GildedRose(new List<Item> { testItem });

            for (var i = 0; i < daysPassed; i++) {
                gildedRose.UpdateQuality();
            }

            Assert.That(testItem.Quality >= 0);
        }

        [Test]
        public void Not_Increase_Aged_Brie_Quality_Over_Fifty()
        {
            var testItem = new Item("Aged Brie", 0, 30);
            var gildedRose = new GildedRose(new List<Item> { testItem });
            
            gildedRose.UpdateQuality();

            Assert.That(testItem.Quality <= 50);
        }
        
        [Test]
        public void Not_Sell_Or_Degrade_Sulfuras()
        {
            const int sellIn = 1337;
            const int quality = 228;
            
            var testItem = new Item("Sulfuras, Hand of Ragnaros", sellIn, quality);
            
            var gildedRose = new GildedRose(new List<Item> { testItem });
            gildedRose.UpdateQuality();
            Assert.That(testItem.SellIn == sellIn);
            Assert.That(testItem.Quality == quality);
        }
    }
}

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

        [Test]
        [TestCase()]
        public void Item_Should_Have_Quality_Decreased_When_Time_Passes(int qualit)
        {
            var item = new Item("", 5, 5);
            var gildedRose = CreateGildedRoseWithAnItem(item);
            
            gildedRose.UpdateQuality();

            Assert.AreEqual(4, item.Quality);
        }
        
        [TestCase()]
        public void Item_Never_Has_Quality_Less_Than_0()
        {
            
        }

        private GildedRose CreateGildedRoseWithAnItem(Item item)
        {
            return new GildedRose(new Collection<Item> { item });
        }
    }
}

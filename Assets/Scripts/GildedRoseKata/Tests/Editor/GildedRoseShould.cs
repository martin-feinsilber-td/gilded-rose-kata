using System.Collections.Generic;
using GildedRoseKata.Domain;
using GildedRoseKata.Presentation;
using NUnit.Framework;

namespace GildedRoseKata.Tests.Editor
{
    [TestFixture]
    public class GildedRoseShould
    {
        private const string NORMAL_ITEM = "normal";
        private const string AGED_BRIE_ITEM = "Aged Brie";
        private const string SULFURAS_ITEM = "Sulfuras, Hand of Ragnaros";
        private const string BACKSTAGE_ITEM = "Backstage passes to a TAFKAL80ETC concert";
        private const string CONJURED_ITEM = "Conjured Mana Cake";
        
        private GildedRose _gildedRose;

        [Test]
        public void Reduce_SellIn_And_Quality_Of_Normal_Items()
        {
            Item item = GivenAnItem(NORMAL_ITEM, 5, 5);
            
            WhenADayHasPassed();
            
            ThenItemSpecsChangedTo(item, 4, 4);
        }
        
        [Test]
        public void Reduce_Quality_Twice_As_Fast_When_Item_Has_Expired()
        {
            Item item = GivenAnItem(NORMAL_ITEM, 0, 5);

            WhenADayHasPassed();
            
            ThenItemSpecsChangedTo(item, -1, 3);
        }

        [Test]
        public void Never_Reduce_Quality_Bellow_Zero()
        {
            Item item = GivenAnItem(NORMAL_ITEM,0, 0);

            WhenADayHasPassed();
            
            ThenItemSpecsChangedTo(item, -1, 0);
        }

        [Test]
        public void Increase_Quality_Of_Aged_Brie_Items_When_It_Gets_Older()
        {
            Item item = GivenAnItem(AGED_BRIE_ITEM,5, 5);
            
            WhenADayHasPassed();
            
            ThenItemSpecsChangedTo(item, 4, 6);
        }
        
        [Test]
        public void Increase_Quality_Of_Aged_Brie_Items_Twice_When_Expired()
        {
            Item item = GivenAnItem(AGED_BRIE_ITEM,0, 4);
            
            WhenADayHasPassed();
            
            ThenItemSpecsChangedTo(item, -1, 6);
        }
        
        [Test]
        public void Never_Increase_Quality_Above_50()
        {
            Item item = GivenAnItem(AGED_BRIE_ITEM,5, 50);
            
            WhenADayHasPassed();
            
            ThenItemSpecsChangedTo(item, 4, 50);
        }
        
        [Test]
        public void Never_Change_Specs_Of_Sulfuras_Items()
        {
            Item item = GivenAnItem(SULFURAS_ITEM, 5, 50);
            
            WhenADayHasPassed();
            
            ThenItemSpecsChangedTo(item, 5, 50);
        }
        
        [Test]
        public void Increase_Quality_By_1_Of_Backstage_Passes_When_It_Expires_In_More_than_10_Days()
        {
            Item item = GivenAnItem(BACKSTAGE_ITEM, 15, 15);
            
            WhenADayHasPassed();
            
            ThenItemSpecsChangedTo(item, 14, 16);
        }
        
        [Test]
        public void Increase_Quality_By_2_Of_Backstage_Passes_When_It_Expires_In_Less_than_10_Days()
        {
            Item item = GivenAnItem(BACKSTAGE_ITEM, 10, 15);
            
            WhenADayHasPassed();
            
            ThenItemSpecsChangedTo(item, 9, 17);
        }
        
        [Test]
        public void Increase_Quality_By_3_Of_Backstage_Passes_When_It_Expires_In_Less_than_5_Days()
        {
            Item item = GivenAnItem(BACKSTAGE_ITEM, 4, 15);
            
            WhenADayHasPassed();
            
            ThenItemSpecsChangedTo(item, 3, 18);
        }
        
        [Test]
        public void Drop_Quality_to_Zero_When_Backstage_Item_Expires()
        {
            Item item = GivenAnItem(BACKSTAGE_ITEM, 0, 15);
            
            WhenADayHasPassed();
            
            ThenItemSpecsChangedTo(item, -1, 0);
        }

        [Test]
        public void Decrease_Quality_Twice_For_Conjured_Items()
        {
            Item item = GivenAnItem(CONJURED_ITEM, 5, 10);
            WhenADayHasPassed();
            ThenItemSpecsChangedTo(item, 4, 8);
        }

        private Item GivenAnItem(string name, int sellIn, int quality)
        {
            List<Item> items = new List<Item>();

            Item item = new Item(name, sellIn, quality);
            
            items.Add(item);
            
            _gildedRose = new GildedRose(items);

            return item;
        }

        private void WhenADayHasPassed()
        {
            _gildedRose.UpdateQuality();
        }

        private void ThenItemSpecsChangedTo(Item item, int expectedSellIn, int expectedQuality)
        {
            Assert.AreEqual(expectedSellIn, item.SellIn);
            Assert.AreEqual(expectedQuality, item.Quality);
        }
    }
}

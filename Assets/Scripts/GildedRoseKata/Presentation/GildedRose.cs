using System.Collections.Generic;
using GildedRoseKata.Domain;

namespace GildedRoseKata.Presentation
{
    public class GildedRose
    {
        IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var originalItem in Items) {
                var item = ItemFactory.Get(originalItem);
                item.Update();
            }
        }
    }
}
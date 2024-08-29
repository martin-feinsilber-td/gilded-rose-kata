namespace GildedRoseKata.Domain
{
    public static class ItemFactory
    {
        public static IItem Get(Item item)
        {
            if (item.Name.Contains("Sulfuras"))
                return new Sulfuras(item);

            if (item.Name.Contains("Aged Brie"))
                return new AgedBrie(item);

            if (item.Name.Contains("Backstage passes"))
                return new BackstagePasses(item);

            if (item.Name.Contains("Conjured"))
                return new Conjured(item);

            return new NormalItem(item);
        }
    }
}
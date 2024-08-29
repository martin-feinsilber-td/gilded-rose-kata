namespace GildedRoseKata.Domain
{
    public class Conjured : BaseItem
    {
        public Conjured(Item item) : base(item)
        {
        }

        public override void Update()
        {
            base.Update();

            DecreaseQuality();
            DecreaseQuality();
        }

        private void DecreaseQuality()
        {
            if (_item.Quality > 0)
                _item.Quality--;
        }
    }
}
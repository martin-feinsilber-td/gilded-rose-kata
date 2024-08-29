namespace GildedRoseKata.Domain
{
    public class NormalItem : BaseItem
    {
        public NormalItem(Item item) : base(item)
        {
        }

        public override void Update()
        {
            base.Update();

            DecreaseQuality();

            if (HasExpired)
                DecreaseQuality();
        }

        private void DecreaseQuality()
        {
            if (_item.Quality > 0)
                _item.Quality--;
        }
    }
}
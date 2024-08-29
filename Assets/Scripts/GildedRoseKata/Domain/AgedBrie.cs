namespace GildedRoseKata.Domain
{
    public class AgedBrie : BaseItem
    {
        public AgedBrie(Item item) : base(item)
        {
        }

        public override void Update()
        {
            base.Update();

            IncreaseQuality();
            if (HasExpired)
                IncreaseQuality();
        }

        private void IncreaseQuality()
        {
            if (_item.Quality < 50)
                _item.Quality += 1;
        }
    }
}
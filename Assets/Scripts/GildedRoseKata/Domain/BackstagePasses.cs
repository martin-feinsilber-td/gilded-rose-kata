namespace GildedRoseKata.Domain
{
    public class BackstagePasses : BaseItem
    {
        public BackstagePasses(Item item) : base(item)
        {
        }

        public override void Update()
        {
            base.Update();

            if (HasExpired)
            {
                _item.Quality = 0;
                return;
            }
            
            IncreaseQuality();

            if (_item.SellIn < 10)
                IncreaseQuality();

            if (_item.SellIn < 5)
                IncreaseQuality();
        }

        private void IncreaseQuality()
        {
            if (_item.Quality < 50)
                _item.Quality += 1;
        }
    }
}
namespace GildedRoseKata.Domain
{
    public abstract class BaseItem : IItem
    {
        protected readonly Item _item;

        protected BaseItem(Item item)
        {
            _item = item;
        }

        public virtual void Update() => DecreaseSellIn();

        private void DecreaseSellIn() => _item.SellIn--;

        protected bool HasExpired => _item.SellIn < 0;
    }
}
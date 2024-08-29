using System;
using System.Collections.Generic;
using System.Text;
using GildedRoseKata.Domain;
using GildedRoseKata.Presentation;
using UnityEngine;

namespace GildedRoseKata.Context
{
    public class GildedRoseApp
    {
        private const int DAYS = 30;

        private IList<Item> Items;

        public GildedRoseApp()
        {
            Items = new List<Item> {
                new Item("+5 Dexterity Vest", 10, 20),
                new Item("Aged Brie", 2, 0),
                new Item("Elixir of the Mongoose", 5, 7),
                new Item("Sulfuras, Hand of Ragnaros", 0, 80),
                new Item("Sulfuras, Hand of Ragnaros", -1, 80),
                new Item("Backstage passes to a TAFKAL80ETC concert", 15, 20),
                new Item("Backstage passes to a TAFKAL80ETC concert", 10, 49),
                new Item("Backstage passes to a TAFKAL80ETC concert", 5, 49),
                // this conjured item does not work properly yet
                new Item("Conjured Mana Cake", 3, 6)
            };
        }

        public void Execute()
        {
            var app = new GildedRose(Items);
            for (var day = 0; day <= DAYS; day++) {
                LogItems(day);

                app.UpdateQuality();
            }
        }

        private void LogItems(int day)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-------- day " + day + " --------");
            sb.AppendLine("name, sellIn, quality");
            for (var i = 0; i < Items.Count; i++) {
                sb.AppendLine(Items[i].ToString());
            }

            Console.WriteLine(sb.ToString());
            Debug.Log(sb.ToString());
        }
    }
}
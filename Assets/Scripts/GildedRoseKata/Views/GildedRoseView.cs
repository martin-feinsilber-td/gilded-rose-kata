using GildedRoseKata.Context;
using UnityEngine;

namespace GildedRoseKata.Views
{
    public class GildedRoseView : MonoBehaviour
    {
        private void Start()
        {
            GildedRoseApp app = new GildedRoseApp();
            app.Execute();
        }
    }
}
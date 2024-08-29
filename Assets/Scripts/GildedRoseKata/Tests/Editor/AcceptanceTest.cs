using System;
using System.IO;
using System.Text;
using GildedRoseKata.Context;
using NUnit.Framework;
using UnityEngine;

namespace GildedRoseKata.Tests.Editor
{
    [TestFixture]
    public class AcceptanceTest 
    {
        [Test]
        public void Validate_Final_Output()
        {
            var acceptanceOutput = Resources.Load<TextAsset>("test-output").text;
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            GildedRoseApp app = new GildedRoseApp();
            app.Execute();
            var output = fakeoutput.ToString().Substring(0, fakeoutput.Length - 1);
            Assert.AreEqual(acceptanceOutput, output);
        }
    }
}

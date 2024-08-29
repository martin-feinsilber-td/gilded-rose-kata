<h2>Introduction</h2>

<p>Hi and welcome to team Gilded Rose. As you know, we are a small inn with 
a prime location in a prominent city ran by a friendly innkeeper named
Allison. We also buy and sell only the finest goods. Unfortunately, our
goods are constantly degrading in quality as they approach their sell by
date. We have a system in place that updates our inventory for us. It
was developed by a no-nonsense type named Leeroy, who has moved on to
new adventures. Your task is to add the new feature to our system so
that we can begin selling a new category of items. First an introduction
to our system:</p>

<ul>
  <li>All items have a SellIn value which denotes the number of days we have
to sell the item</li>
  <li>All items have a Quality value which denotes how valuable the item is</li>
  <li>At the end of each day our system lowers both values for every item</li>
</ul>

<p>Pretty simple, right? Well this is where it gets interesting:</p>

<ul>
  <li>Once the sell by date has passed, Quality degrades twice as fast</li>
  <li>The Quality of an item is never negative</li>
  <li>“Aged Brie” actually increases in Quality the older it gets and twice when expired</li>
  <li>The Quality of an item is never more than 50</li>
  <li>“Sulfuras”, being a legendary item, never has to be sold or decreases
in Quality</li>
  <li>“Backstage passes”, like aged brie, increases in Quality as its
SellIn value approaches;
    <ul>
      <li>Quality increases by 2 when there are 10 days or less and by 3 when
there are 5 days or less but</li>
      <li>Quality drops to 0 after the concert</li>
    </ul>
  </li>
</ul>

<h2>Your Task</h2>

<p>We have recently signed a supplier of conjured items. This requires an
update to our system:</p>

<ul>
  <li>“Conjured” items degrade in Quality twice as fast as normal items</li>
</ul>

<h2>Rules</h2>

<ul>
  <li><b>Hardcore TDD:</b> You are NOT allowed to add/refactor any production code without having the test that proves you are not breaking anything</li>
  <li>Before implementing the new item the code must be refactored into a solution that will make completing your task much simpler</li>
</ul>

<p>Feel free to make any changes to the UpdateQuality method and add any
new code as long as everything still works correctly. However, <strong>do not
alter the Item class or Items property as those belong to the goblin in
the corner who will insta-rage and one-shot you</strong> as he doesn’t believe in
shared code ownership (you can make the UpdateQuality method and Items
property static if you like, we’ll cover for you).</p>

<p>Just for clarification, an item can never have its Quality increase
above 50, however “Sulfuras” is a legendary item and as such its Quality
is 80 and it never alters.</p>

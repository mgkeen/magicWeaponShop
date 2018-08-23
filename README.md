# Magic Weapon Shop
A kata designed to encourage writing flexible tests. You are encouraged to not read ahead and tackle each task in order. A starting point is provided in C#, but feel free to follow the kata in whatever language you choose.

## Introduction
You own a shop selling magical weapons to passing adventurers on their way to the dragon gauntlets.
You recently aided a sentient raven on his quest to "collect all the shiny things". Your reward was a mystical object called a laptop.
You're worried that one day an adventurer will survive the dragon gauntlets and come back to complain about the quality of your stock.
Using this laptop thing, you've decided to write a program to help manage the intricacies of maintaining the magical stock in your shop.

### Task 1
Swords are your most popular item. Swords with lots of magic are highly sought after. The first thing you need your program to do is track the magic levels in your swords, and be able to calculate the price of a sword.

- Fresh swords start with 50 magic
- Every time the clock strikes midnight, the swords lose 5 magic
- A sword can be sold for 2x its magic level

### Task 2
Every now and then you get a batch of second hand swords, mostly scavanged from those adventurers who don't survive the dragon gauntlets. These swords have already lost some magic. As they have already got adventurer sweat on them, they are worth less than fresh swords.

- Second hand swords start with 25 magic
- Every time the clock strikes midnight, the swords lose 5 magic
- A second hand sword can be sold for 1x its magic level

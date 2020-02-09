using System;
using System.Collections.Generic;

namespace Robo_Restaurant.Properties
{
    public class AddDish
    {
        public List<Dish> dishes = new List<Dish>();
        public List<Ingredients> ingredients = new List<Ingredients>();

        public void AddingDish()
        {
            dishes.Add(new Dish(Dish.dishName.Borsch, 300, 15, new List<Ingredients>
            {
                new Ingredients("Water", 20),
                new Ingredients("Beef", 10),
                new Ingredients("Cabbage", 5),
                new Ingredients("Beetroot", 5),
                new Ingredients("Potato", 10),
                new Ingredients("Carrot", 10)
            }, 50));
            dishes.Add(new Dish(Dish.dishName.Green_Borsch, 300, 10, new List<Ingredients>
            {
                new Ingredients("Water", 20),
                new Ingredients("Beef", 10),
                new Ingredients("Cabbage", 5),
                new Ingredients("Sorrel", 5),
                new Ingredients("Potato", 10),
                new Ingredients("Carrot", 10)
            }, 60));
            dishes.Add(new Dish(Dish.dishName.Vegetable_Soup, 250, 14, new List<Ingredients>
            {
                new Ingredients("Water", 20),
                new Ingredients("Beef", 10),
                new Ingredients("Cabbage", 5),
                new Ingredients("Beetroot", 5),
                new Ingredients("Potato", 10),
                new Ingredients("Carrot", 10)
            }, 58));
        }
        
    }
}

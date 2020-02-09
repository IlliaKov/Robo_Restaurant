using System;
namespace Robo_Restaurant.Properties
{
    public class Dish
    {
        public string dName;
        public int Weight;
        public int TimeOfPrep;
        public string Ingredients;
        public int Price;

        public Dish(string dname, int weight, int timeofprep, string ingred, int price)
        {
            dName = dname;
            Weight = weight;
            TimeOfPrep = timeofprep;
            Ingredients = ingred;
            Price = price;
        }
    }
}

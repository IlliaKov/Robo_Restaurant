using System;
using System.Collections.Generic;

namespace Robo_Restaurant.Properties
{
    public class Ordering
    {
        private Dish dishh;
        private Ingredients ingred;
        private Restaurant rest;
        

        public Dish Dishh
        {
            get { return dishh; }
            set { dishh = value; }
        }
        public Ingredients Ingred
        {
            get { return ingred; }
            set { ingred = value; }
        }
        public Restaurant Rest
        {
            get { return rest; }
            set { rest = value; }
        }

        public Ordering(Dish dishh, Restaurant rest)
        {
            Dishh = dishh;
            Rest = rest;
        }

        public void makeOrder()
        {

            if(dishh.dName == Dish.dishName.Borsch)
            {
                Ingred.Quantity -= 1;
                if(Ingred.Quantity <= 0)
                {
                    throw new Exception("Sorry, but there are no ingridients left to cook");
                }
            }
            else if(dishh.dName == Dish.dishName.Green_Borsch)
            {
                Ingred.Quantity -= 1;
                if (Ingred.Quantity <= 0)
                {
                    throw new Exception("Sorry, but there are no ingridients left to cook");
                }
            }
            else if (dishh.dName == Dish.dishName.Vegetable_Soup)
            {
                Ingred.Quantity -= 1;
                if (Ingred.Quantity <= 0)
                {
                    throw new Exception("Sorry, but there are no ingridients left to cook");
                }
            }

                
        }
    }
}

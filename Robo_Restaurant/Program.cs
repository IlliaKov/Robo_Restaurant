using System;
using Robo_Restaurant.Properties;
using System.Collections.Generic;

namespace Robo_Restaurant
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Restaurant resta = new Restaurant("La Robot");
            AddDish addDish = new AddDish();
            Ordering order;
            int option;
            Console.WriteLine("Hello my friend! Here is available menu: \n 1 - Borsch, \n Green Borsch, \n Vegetable Soup");
            option = Convert.ToInt32(Console.ReadLine());

            if(option == 1)
            {

                Dish dish = new Dish(Dish.dishName.Vegetable_Soup, 1, 1, new List<Ingredients> { }, 20);
                addDish.AddingDish();
                

                
                order = new Ordering(dish, resta);
                Console.WriteLine("Your order is creating");

            }
        }
    }
}

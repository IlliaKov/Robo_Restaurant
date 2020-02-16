﻿using System;
namespace Robo_Restaurant.Properties
{
    public class SpecTimeOrder
    {
        IngredientsBasement Base = new IngredientsBasement();
        Menu menuDish = new Menu();


        static DateTime currentTime = DateTime.Now;
        DateTime antiBoilingTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 20, 30, 00);
        DateTime closingTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 22, 00, 00);
        public SpecTimeOrder()
        {
            menuDish.AddingDish();
        }
        public void SpecTime()
        {
            if(currentTime >= antiBoilingTime)
            {
                string ig = "";
                foreach(var dish in menuDish.dishes)
                {
                    bool DishIngT = true;
                    string ig1 = "";
                    foreach(var ingr in dish.Ingredients)
                    {
                        if(ingr.TempChange == false && DishIngT == true)
                        {
                            ig1 += dish.dName + " ";
                        }
                        else
                        {
                            DishIngT = false;
                            ig1 = "";
                            break;
                        }
                    }
                    ig += ig1;

                }
                Console.WriteLine("You can only choose these dishes: " + ig);
            }
            else if (currentTime >= closingTime)
            {
                throw new Exception("Sorry, but we are closed!");
            }
        }
    }
}
/*
            if (currentTime >= antiBoilingTime)
            {
                foreach(var dish in menuDish.dishes)
                {
                    foreach(var ingr in dish.Ingredients)
                    {
                        foreach(var ingr1 in Base.IngList)
                        {
                            if(ingr == ingr1)
                            {
                                if (ingr1.TempChange == false) 
                                Console.WriteLine();
                            }
                        }
                    }
                    
                }
            }*/

/*if (currentTime >= antiBoilingTime)
{

    foreach (var ingr in Base.IngList)
    {
        if (ingr.TempChange == false) Console.WriteLine($"It's a fresh time – so you can order only this: {ingr.Iname}");

    }

}
else if (currentTime >= closingTime)
{
    throw new Exception("Sorry, but we are closed!");
}*/

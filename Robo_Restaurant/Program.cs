﻿using System;
using Robo_Restaurant.Properties;
using System.Collections.Generic;

namespace Robo_Restaurant
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            int option;
            Ordering order = new Ordering();
            SpecTimeOrder specOrder = new SpecTimeOrder();
            
            Console.WriteLine("Hello my friend! Here is available menu: \n 1 - Borsch, \n 2 – Green Borsch, \n 3 – Vegetable Soup, \n 4 - Strawberry Jelly, \n 5 - Banana Juice \n At 20:30 our restaraunt has SPECIAL Fresh Menu");
            
            option = Convert.ToInt32(Console.ReadLine());
            
            
                if (option == 1)
                {
                    try
                    {
                        specOrder.SpecTime();
                        order.MakeOrder(Dish.dishName.Borsch);
                        Console.WriteLine("Your order is cooking!");
                        

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    
                }
                else if (option == 2)
                {
                    try
                    {
                        specOrder.SpecTime();
                        order.MakeOrder(Dish.dishName.Green_Borsch);
                        Console.WriteLine("Your order is cooking!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (option == 3)
                {
                    try
                    {
                        specOrder.SpecTime();
                        order.MakeOrder(Dish.dishName.Vegetable_Soup);
                        Console.WriteLine("Your order is cooking!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (option == 4)
                {
                    try
                    {
                        specOrder.SpecTime();
                        order.MakeOrder(Dish.dishName.Strawberry_Jelly);
                        Console.WriteLine("Your order is cooking!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (option == 5)
                {
                    try
                    {
                        specOrder.SpecTime();
                        order.MakeOrder(Dish.dishName.Banana_Juice);
                        Console.WriteLine("Your order is cooking!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                /*Console.WriteLine("Now you can continue - 1, or finish - 0");
                int Cont = Convert.ToInt32(Console.ReadLine());
                if (Cont == 0) Console.WriteLine("Thanks for using our app!");
                else if (Cont == 1) Console.WriteLine("You have chosen to order something else");*/
            
        }
    }
}

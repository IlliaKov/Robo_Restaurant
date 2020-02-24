using System;
using Robo_Restaurant.Properties;
using System.Collections.Generic;

namespace Robo_Restaurant
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (; ; )
            {
                int option;
                Ordering order = new Ordering();
                SpecTimeOrder specOrder = new SpecTimeOrder();

                Console.WriteLine("Hello my friend! Here is available menu: \n 1 - Borsch, \n 2 – Green Borsch, \n 3 – Vegetable Soup, \n 4 - Strawberry Jelly, \n 5 - Banana Juice \n At 20:30 our restaraunt has SPECIAL Fresh Menu, \n 7 - Choose text menu: ");

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
                else if (option == 7)
                {

                    TxtFileReader.TxtReader();
                }
                else if(option == 6)
                {
                    break;
                }
                
                
            }
            Console.WriteLine("The end of choosing");
        }
    }
}


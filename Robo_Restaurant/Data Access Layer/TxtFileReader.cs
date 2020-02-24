using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Robo_Restaurant.Properties
{
    public class TxtFileReader
    {
        public static void TxtReader()
        {

            Menu mm = new Menu();


            string filePath = @"/Users/illiakovalenko/Projects/Robo_Restaurant/Robo_Restaurant/Menu.txt";
            //List<Dish> dishh = new List<Dish>();
            IngredientsBasement Basement = new IngredientsBasement();
            //Ordering ord = new Ordering();
            List<string> lines = File.ReadAllLines(filePath).ToList();
            string[] entries;
            mm.AddingDish();
            foreach(var line in lines)
            {
                entries = line.Split(',');
                foreach (var i in mm.dishes)
                {
                    if (entries[0] == i.dName.ToString())
                    {
                        Console.WriteLine("You can choose:" + i.dName);
                    }
                }
            }

            //foreach (var line in lines)
            //{
            //    string[] entries = line.Split(',');

            //    Dish c = null;
            //    int diName = Convert.ToInt32(entries[0]);
            //    Dish.dishName dName = Dish.dishName.Borsch;

            //    if (diName == 1)
            //    {
            //        dName = Dish.dishName.Borsch;
            //    }
            //    if (diName == 2)
            //    {
            //        dName = Dish.dishName.Green_Borsch;
            //    }

            //    int Weigth = Convert.ToInt32(entries[1]);
            //    int timeOfPrep = Convert.ToInt32(entries[2]);

            //    int ingre = Convert.ToInt32(entries[3]);

            //    List<Ingredients> ingr = new List<Ingredients>();
            //    if (ingre == 1)
            //    {
            //        ingr = new List<Ingredients>
            //        {
            //            Basement.IngList[0],
            //            Basement.IngList[1],
            //            Basement.IngList[2],
            //            Basement.IngList[3],
            //            Basement.IngList[4],
            //            Basement.IngList[5]
            //        };
            //    }
            //    else if (ingre == 2)
            //    {
            //        ingr = new List<Ingredients>
            //        {
            //            Basement.IngList[0],
            //            Basement.IngList[1],
            //            Basement.IngList[2],
            //            Basement.IngList[4],
            //            Basement.IngList[5],
            //            Basement.IngList[6]
            //        };
            //    }

            //    int Price = Convert.ToInt32(entries[4]);

            //    try
            //    {
            //        c = new Dish(dName, Weigth, timeOfPrep, ingr, Price);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex);
            //    }
            //    mm.AddSpec(c);
            //}
            //foreach( var ingdd in mm.dishes)
            //{
            //    Console.WriteLine(ingdd.dName + ingdd.Weight + ingdd.TimeOfPrep + ingdd.Price);
            //}
        }
    }
}
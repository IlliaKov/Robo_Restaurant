using System;
namespace Robo_Restaurant.Properties
{
   

    public class Ingredients
    {
        private string iname;
        private int quantity;

        public string Iname
        {
            get { return iname; }
            set { iname = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Ingredients(string iname, int quantity)
        {
            Iname = iname;
            Quantity = quantity;
        }
    }
}

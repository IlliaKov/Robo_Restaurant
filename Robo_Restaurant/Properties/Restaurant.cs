using System;
namespace Robo_Restaurant.Properties
{
    public class Restaurant
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Restaurant(string name)
        {
            Name = name;
        }
    }
}

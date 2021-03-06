using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.IteratorPattern.Concrete
{
    public class MenuItem
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double Price { get; private set; }
        public bool Vegetarian { get; private set; }
        public MenuItem(string name, string description, double price, bool vegetarian)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Vegetarian = vegetarian;
        }
    }
}

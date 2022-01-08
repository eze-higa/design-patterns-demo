using design_patterns.Patterns.IteratorPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.IteratorPattern.Concrete
{
    public class PancakeHouseMenu: IMenu
    {
        public List<MenuItem> MenuItems { get; private set; }
        public PancakeHouseMenu()
        {
            this.MenuItems = new List<MenuItem>();
            AddMenuItem("K&B'S Pancake Breakfast", "Pancakes with Scrambled eggs and toast", 2.99, true);
            AddMenuItem("Regular Pancake Breakfast", "Pancakes with fried eggs and sausage", 2.99, false);
            AddMenuItem("Waffles", "Waffles, with your choices of blueberries or strawberries", 3.59, true);
        }

        public void AddMenuItem(string name, string description, double price, bool vegetarian)
        {
            this.MenuItems.Add(new MenuItem(name, description, price, vegetarian));
        }

        public IIterator<MenuItem> CreateIterator() => new PancakeHouseMenuIterator(MenuItems);
    }
}

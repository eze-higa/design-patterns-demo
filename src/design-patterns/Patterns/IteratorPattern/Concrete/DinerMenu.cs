using design_patterns.Patterns.IteratorPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.IteratorPattern.Concrete
{
    public class DinerMenu: IMenu
    {
        private int MAX_ITEMS = 6;
        private int _numberOfItems = 0;
        public MenuItem[] MenuItems { get; private set; }

        public DinerMenu()
        {
            this.MenuItems = new MenuItem[MAX_ITEMS];
            AddMenuItem("Vegetarian BLT", "(Fakin´) Bacon with lettuce & tomato on whole heat", 2.99, true);
            AddMenuItem("BLT", "Bacon with lettuce & tomato on whole heat", 2.99, false);
            AddMenuItem("Hot dog", "A hot dog, with saurkraut, relish, onions, topped with cheese", 3.05, false);
        }

        public void AddMenuItem(string name, string description, double price, bool vegetarian)
        {
            if(_numberOfItems < MAX_ITEMS)
            {
                this.MenuItems[_numberOfItems] = new MenuItem(name, description, price, vegetarian);
                _numberOfItems++;
            }
        }

        public IIterator<MenuItem> CreateIterator() => new DinerMenuIterator(this.MenuItems);
    }
}

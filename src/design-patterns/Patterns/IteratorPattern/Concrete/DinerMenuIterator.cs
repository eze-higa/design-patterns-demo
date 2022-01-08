using design_patterns.Patterns.IteratorPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.IteratorPattern.Concrete
{
    public class DinerMenuIterator: IIterator<MenuItem>
    {
        private MenuItem[] _menuItems;
        private int _currentIndex;
        public DinerMenuIterator(MenuItem[] menuItems)
        {
            this._menuItems = menuItems;
            this._currentIndex = 0;
        }

        public bool HasNext()
        {
            return _currentIndex < _menuItems.Length && _menuItems[_currentIndex] != null;
        }

        public MenuItem Next()
        {
            MenuItem menuItem = _menuItems[_currentIndex];
            _currentIndex++;
            return menuItem;
        }
    }
}

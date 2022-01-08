using design_patterns.Patterns.IteratorPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.IteratorPattern.Concrete
{
    public class PancakeHouseMenuIterator : IIterator<MenuItem>
    {
        private int _currentIndex;
        private List<MenuItem> _items;
        public PancakeHouseMenuIterator(List<MenuItem> items)
        {
            this._items = items;
            _currentIndex = 0;
        }
        public bool HasNext()
        {
            return _currentIndex < _items.Count;
        }

        public MenuItem Next()
        {
            return this._items[_currentIndex++];
        }
    }
}

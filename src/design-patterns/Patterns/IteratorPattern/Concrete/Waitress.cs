using design_patterns.Patterns.IteratorPattern.Abstract;

namespace design_patterns.Patterns.IteratorPattern.Concrete
{
    public class Waitress
    {        
        public ICollection<IMenu> Menus { get; private set; }
        public Waitress(ICollection<IMenu> menus)
        {           
            this.Menus = menus;
        }

        public void PrintMenu()
        {
            foreach(var menu in Menus)
            {
                printMenu(menu.CreateIterator());
            }            
        }

        private void printMenu(IIterator<MenuItem> iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem item = iterator.Next();
                Console.WriteLine($"Name {item.Name}");
                Console.WriteLine($"Description {item.Description}");
                Console.WriteLine($"Price ${item.Price}");
            }
        }
    }
}

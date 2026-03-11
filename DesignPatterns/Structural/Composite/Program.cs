//Base Component class
abstract class MenuComponent
{
    public string Name { get; protected set; }

    public MenuComponent(string name)
    {
        Name = name;
    }

    public abstract void Print();

    public virtual void Add(MenuComponent component)
    {
        throw new NotImplementedException("Cannot add an item to a simple menu leaf.");
    }

    public virtual bool IsComposite() => true;
}


//Leaf
class MenuItem : MenuComponent
{
    private double _price;

    public MenuItem(string name, double price) : base(name)
    {
        _price = price;
    }

    public override void Print()
    {
        Console.WriteLine($"  - {Name}: ${_price}");
    }

    public override bool IsComposite() => false;
}


//Composite class
class MenuCategory : MenuComponent
{
    private List<MenuComponent> _children = new List<MenuComponent>();

    public MenuCategory(string name) : base(name) { }

    public override void Add(MenuComponent component)
    {
        _children.Add(component);
    }

    public override void Print()
    {
        Console.WriteLine($"\n--- CATEGORY: {Name.ToUpper()} ---");

        foreach (var component in _children)
        {
            component.Print();
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        // simple leaf items
        MenuItem steak = new MenuItem("Ribeye Steak", 35.00);
        MenuItem salad = new MenuItem("Caesar Salad", 12.50);
        MenuItem wine = new MenuItem("Cabernet Sauvignon", 45.00);
        MenuItem juice = new MenuItem("Orange Juice", 4.00);

        // composite categories
        MenuCategory mainMenu = new MenuCategory("Main Menu");
        MenuCategory drinksCategory = new MenuCategory("Beverages");
        MenuCategory wineList = new MenuCategory("Wine Selection");

        // TREE STRUCTURE
        // Add wine to the wine list (Composite inside Composite)
        wineList.Add(wine);

        // Add juice and the wine list to the general Beverages category
        drinksCategory.Add(juice);
        drinksCategory.Add(wineList);

        // Add food and the beverage section to the Main Menu
        mainMenu.Add(steak);
        mainMenu.Add(salad);
        mainMenu.Add(drinksCategory);

        // Treating single items and entire structures the same way
        Console.WriteLine("Displaying a single Leaf item:");
        steak.Print();

        Console.WriteLine("\nDisplaying the full Composite structure:");
        mainMenu.Print();
    }
}
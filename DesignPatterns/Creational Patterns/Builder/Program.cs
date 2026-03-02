var director = new Director();
var woodenBuilder = new WoodenBuilder();
var brickBuilder = new BrickBuilder();

Console.WriteLine("Custom wooden house:");
woodenBuilder.BuildFoundation();
woodenBuilder.BuildWalls();
woodenBuilder.BuildRoof();
woodenBuilder.BuildFireplace();
woodenBuilder.BuildPorch();
Console.WriteLine(woodenBuilder.GetHouse().ListComponents());

director.Builder = brickBuilder;
Console.WriteLine("Basic brick house:");
House brickHouse = director.BuildBasicHouse();
Console.WriteLine(brickHouse.ListComponents());

public class House
{
    private readonly List<string> _components = new();

    public void Add(string component)
    {
        _components.Add(component);
    }

    public string ListComponents()
    {
        string str = string.Empty;

        for (int i = 0; i < this._components.Count; i++)
        {
            str += this._components[i] + ", ";
        }

        str = str.Remove(str.Length - 2);
        return "House components: " + str + "\n";
    }
}


public interface IBuilder
{
    void BuildFoundation();
    void BuildWalls();
    void BuildRoof();
    House GetHouse();
    void Reset();
}


public class WoodenBuilder : IBuilder
{
    private House _house = new House();

    public void Reset()
    {
        this._house = new House();
    }

    public void BuildFoundation()
    {
        this._house.Add("Foundation");
    }

    public void BuildWalls()
    {
        this._house.Add("WoodenWalls");
    }

    public void BuildRoof()
    {
        this._house.Add("WoodenRoof");
    }

    public void BuildFireplace()
    {
        this._house.Add("Fireplace");
    }

    public void BuildPorch()
    {
        this._house.Add("Porch");
    }

    public House GetHouse()
    {
        return this._house;
    }
}


public class BrickBuilder : IBuilder
{
    private House _house = new House();

    public void Reset()
    {
        this._house = new House();
    }

    public void BuildFoundation()
    {
        this._house.Add("Foundation");
    }

    public void BuildWalls()
    {
        this._house.Add("BrickWalls");
    }

    public void BuildRoof()
    {
        this._house.Add("BrickRoof");
    }

    public void BuildSecondFloor()
    {
        this._house.Add("SecondFloor");
        this._house.Add("BrickWalls");
    }

    public House GetHouse()
    {
        return this._house;
    }
}

public class Director
{
    private IBuilder _builder;
    
    public IBuilder Builder
    {
        set { _builder = value; }
    }

    public House BuildBasicHouse()
    {
        this._builder.BuildFoundation();
        this._builder.BuildWalls();
        this._builder.BuildRoof();
        return _builder.GetHouse(); 
    }
}






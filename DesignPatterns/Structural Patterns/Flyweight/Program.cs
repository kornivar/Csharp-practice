
public class FlyweightTree
{
    private string _type;
    private string _color;
    private string _texture;

    public FlyweightTree(string type, string color, string texture)
    {
        _type = type;
        _color = color;
        _texture = texture;
    }

    public void CreateTree(int x, int y)
    {
        Console.WriteLine($"Tree with shared [{_type}, {_color}, {_texture}] at unique coordinates ({x},{y})");
    }
}

public class FlyweightTreeFactory
{
    private Dictionary<string, FlyweightTree> _flyweights = new();

    public FlyweightTree GetFlyweight(string type, string color, string texture)
    {
        string key = $"{type}_{color}_{texture}";
        if (!_flyweights.ContainsKey(key))
            _flyweights[key] = new FlyweightTree(type, color, texture);
        return _flyweights[key];
    }
}


public class Tree
{
    public int X { get; set; }
    public int Y { get; set; }
    public string Type { get; set; }     
    public string Color { get; set; }    
    public string Texture { get; set; }   
}


class Program
{
    static void Main(string[] args)
    {
        var factory = new FlyweightTreeFactory();

        var tree1 = new Tree { X = 1, Y = 2, Type = "Oak", Color = "Green", Texture = "Rough" };
        var flyweight1 = factory.GetFlyweight(tree1.Type, tree1.Color, tree1.Texture);
        flyweight1.CreateTree(tree1.X, tree1.Y);

        var tree2 = new Tree { X = 5, Y = 7, Type = "Oak", Color = "Green", Texture = "Rough" };
        var flyweight2 = factory.GetFlyweight(tree2.Type, tree2.Color, tree2.Texture);
        flyweight2.CreateTree(tree2.X, tree2.Y);
    }
}

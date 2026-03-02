Shape circle1 = new Circle(10, 20, "Black", 10);
Shape circle2 = circle1.Clone();

Shape rect1 = new Rectangle(0, 0, "Blue", 100, 50);
Shape rect2 = rect1.Clone();

interface IPrototype<T>
{
    T Clone();
}

abstract class Shape : IPrototype<Shape>
{
    public int X { get; }
    public int Y { get; }

    public string Color { get; }

    // Basic constructor
    protected Shape(int x, int y, string color)
    {
        this.X = x;
        this.Y = y;
        this.Color = color;
    }

    // Copy constructor
    protected Shape(Shape source)
    {
        X = source.X;
        Y = source.Y;
        Color = source.Color;
    }

    // Clone method
    public abstract Shape Clone();
}

class Circle : Shape
{
    public int Radius { get; }
    public Circle(int x, int y, string color, int radius) : base(x, y, color)
    {
        this.Radius = radius;
    }

    public Circle(Circle source) : base(source)
    {
        this.Radius = source.Radius;
    }

    public override Shape Clone()
    {
        return new Circle(this);
    }
}

class Rectangle : Shape
{
    public int Width { get; }
    public int Height { get; }
    public Rectangle(int x, int y, string color, int width, int height) : base(x, y, color)
    {
        this.Width = width;
        this.Height = height;
    }
    public Rectangle(Rectangle source) : base(source)
    {
        this.Width = source.Width;
        this.Height = source.Height;
    }
    public override Shape Clone()
    {
        return new Rectangle(this);
    }
}


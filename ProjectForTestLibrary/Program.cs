using GeometryLibrary;

try
{
    IShape shape1 = new Circle(3);
    IShape shape2 = new Triangle(3, 4, 5);

    PrintShapeArea(shape1);
    PrintShapeArea(shape2);

    if (shape2 is Triangle triangle && triangle.IsRightAngled())
    {
        Console.WriteLine("The triangle is right-angled.");
    }
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Error creating shape: {ex.Message}");
}

void PrintShapeArea(IShape shape)
{
    Console.WriteLine($"Area: {shape.CalculateArea()}");
}
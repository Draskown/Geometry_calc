using GeometryLibrary;

class Program
{
    static void Main(string[] args)
    {
    
        // Compute the area of a circle with radius 3
        Console.WriteLine($"The area of the circle is {Geometry.ComputeArea(3):F3}");

        // Compute the area of a triangle with sides 3, 5, and 7
        Console.WriteLine($"The area of the triangle is {Geometry.ComputeArea(13, 5, 7):F3}");

        // Compute the area of a triangle with sides 3, 4, 5
        Console.WriteLine($"The area of the triangle is {Geometry.ComputeArea(3, 4, 5):F3}");
    }
}
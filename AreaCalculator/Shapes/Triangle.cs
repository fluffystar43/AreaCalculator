using AreaCalculator.Shapes.Abstract;

namespace AreaCalculator.Shapes;

/// <summary>
/// Represents a triangle shape.
/// </summary>
public class Triangle : Shape
{
	/// <summary>
	/// The length of side a.
	/// </summary>
	public double A { get; }

	/// <summary>
	/// The length of side b.
	/// </summary>
	public double B { get; }

	/// <summary>
	/// The length of side c.
	/// </summary>
	public double C { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="Triangle"/> class with the specified side lengths.
	/// </summary>
	/// <param name="a">The length of side a.</param>
	/// <param name="b">The length of side b.</param>
	/// <param name="c">The length of side c.</param>
	/// <exception cref="ArgumentException">Thrown if the sides do not form a valid triangle.</exception>
	public Triangle(double a, double b, double c)
	{
		if (!IsValidTriangle(a, b, c))
		{
			throw new ArgumentException("Invalid triangle: sides must be positive and satisfy the triangle inequality.");
		}

		A = a;
		B = b;
		C = c;
	}

	/// <summary>
	/// Calculates the area of the triangle.
	/// </summary>
	/// <returns>The area of the triangle.</returns>
	public override double CalculateArea()
	{
		var semiPerimeter = (A + B + C) / 2;
		return Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));
	}
	
	/// <summary>
	/// Validates if the given side lengths form a valid triangle.
	/// </summary>
	/// <param name="a">The length of side A.</param>
	/// <param name="b">The length of side B.</param>
	/// <param name="c">The length of side C.</param>
	/// <returns><c>true</c> if the sides form a valid triangle; otherwise, <c>false</c>.</returns>
	private bool IsValidTriangle(double a, double b, double c)
	{
		return a > 0 && b > 0 && c > 0 && (a + b > c) && (a + c > b) && (b + c > a);
	}
}

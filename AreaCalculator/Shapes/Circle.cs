using AreaCalculator.Shapes.Abstract;

namespace AreaCalculator.Shapes;

/// <summary>
/// Represents a circle shape.
/// </summary>
public class Circle : Shape
{
	/// <summary>
	/// The radius of the circle.
	/// </summary>
	public double Radius { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="Circle"/> class with the specified radius.
	/// </summary>
	/// <param name="radius">The radius of the circle.</param>
	/// <exception cref="ArgumentException">Thrown if the radius is less than or equal to zero.</exception>
	public Circle(double radius)
	{
		if (radius <= 0)
		{
			throw new ArgumentException("Radius must be greater than zero.");
		}
		Radius = radius;
	}

	/// <summary>
	/// Calculates the area of the circle.
	/// </summary>
	/// <returns>The area of the circle.</returns>
	public override double CalculateArea()
	{
		return Math.PI * Math.Pow(Radius, 2);
	}
}

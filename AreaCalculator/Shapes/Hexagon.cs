using AreaCalculator.Shapes.Abstract;

namespace AreaCalculator.Shapes;

/// <summary>
/// Represents a regular hexagon shape.
/// </summary>
public class Hexagon : Shape
{
	/// <summary>
	/// The side length of the hexagon.
	/// </summary>
	public double SideLength { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="Hexagon"/> class with the specified side length.
	/// </summary>
	/// <param name="sideLength">The side length of the hexagon.</param>
	/// <exception cref="ArgumentException">Thrown if the side length is less than or equal to zero.</exception>
	public Hexagon(double sideLength)
	{
		if (sideLength <= 0)
		{
			throw new ArgumentException("Side length must be greater than zero.");
		}
		SideLength = sideLength;
	}

	/// <summary>
	/// Calculates the area of the hexagon.
	/// </summary>
	/// <returns>The area of the hexagon.</returns>
	public override double CalculateArea()
	{
		return (3 * Math.Sqrt(3) / 2) * Math.Pow(SideLength, 2);
	}
}
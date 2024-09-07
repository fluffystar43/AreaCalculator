using AreaCalculator.Shapes.Abstract;

namespace AreaCalculator.Shapes;

/// <summary>
/// Represents a rectangle shape.
/// </summary>
public class Rectangle : Shape
{
	/// <summary>
	/// The width of the rectangle.
	/// </summary>
	public double Width { get; }

	/// <summary>
	/// The height of the rectangle.
	/// </summary>
	public double Height { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="Rectangle"/> class with the specified dimensions.
	/// </summary>
	/// <param name="width">The width of the rectangle.</param>
	/// <param name="height">The height of the rectangle.</param>
	/// <exception cref="ArgumentException">Thrown if the width or height is less than or equal to zero.</exception>
	public Rectangle(double width, double height)
	{
		if (width <= 0 || height <= 0)
		{
			throw new ArgumentException("Width and height must be greater than zero.");
		}
		Width = width;
		Height = height;
	}

	/// <summary>
	/// Calculates the area of the rectangle.
	/// </summary>
	/// <returns>The area of the rectangle.</returns>
	public override double CalculateArea()
	{
		return Width * Height;
	}
}

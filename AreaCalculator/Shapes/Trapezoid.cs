using AreaCalculator.Shapes.Abstract;

namespace AreaCalculator.Shapes;

/// <summary>
/// Represents a trapezoid shape.
/// </summary>
public class Trapezoid : Shape
{
	/// <summary>
	/// Gets the length of the first parallel side.
	/// </summary>
	public double Base1 { get; }

	/// <summary>
	/// The length of the second parallel side.
	/// </summary>
	public double Base2 { get; }

	/// <summary>
	/// The height of the trapezoid.
	/// </summary>
	public double Height { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="Trapezoid"/> class with the specified dimensions.
	/// </summary>
	/// <param name="base1">The length of the first parallel side (base1).</param>
	/// <param name="base2">The length of the second parallel side (base2).</param>
	/// <param name="height">The height of the trapezoid.</param>
	/// <exception cref="ArgumentException">Thrown if any dimension is less than or equal to zero.</exception>
	public Trapezoid(double base1, double base2, double height)
	{
		if (base1 <= 0 || base2 <= 0 || height <= 0)
		{
			throw new ArgumentException("Base lengths and height must be greater than zero.");
		}
		Base1 = base1;
		Base2 = base2;
		Height = height;
	}

	/// <summary>
	/// Calculates the area of the trapezoid.
	/// </summary>
	/// <returns>The area of the trapezoid.</returns>
	public override double CalculateArea()
	{
		return 0.5 * (Base1 + Base2) * Height;
	}
}

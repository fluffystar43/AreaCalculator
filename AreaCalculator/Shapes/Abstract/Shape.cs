using AreaCalculator.Interfaces;

namespace AreaCalculator.Shapes.Abstract;

/// <summary>
/// Base class for all shapes with area.
/// </summary>
public abstract class Shape : IAreaCalculable
{
	/// <summary>
	/// Calculates the area of the shape.
	/// </summary>
	/// <returns>The area of the shape.</returns>
	public abstract double CalculateArea();
}

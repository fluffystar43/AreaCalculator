using AreaCalculator.Shapes;

namespace AreaCalculator.Tests.ShapeTests;

/// <summary>
/// Unit tests for the <see cref="Trapezoid"/> class.
/// </summary>
[TestFixture]
public class TrapezoidTests
{
	/// <summary>
	/// Tests that the area calculation for a trapezoid with valid dimensions is correct.
	/// </summary>
	[Test]
	public void CalculateArea_ValidDimensions_ReturnsCorrectArea()
	{
		// Arrange
		var trapezoid = new Trapezoid(4.0, 6.0, 5.0);
		var expectedArea = 25.0;

		// Act
		var area = trapezoid.CalculateArea();

		// Assert
		Assert.That(area, Is.EqualTo(expectedArea).Within(1e-6),
			"The area calculated for the trapezoid is not correct.");
	}

	/// <summary>
	/// Tests that creating a trapezoid with invalid dimensions throws an exception.
	/// </summary>
	[Test]
	public void CalculateArea_InvalidDimensions_ThrowsException()
	{
		// Arrange & Act & Assert
		Assert.Throws<ArgumentException>(() => new Trapezoid(4.0, 6.0, 0),
			"Expected ArgumentException for zero height.");
		Assert.Throws<ArgumentException>(() => new Trapezoid(-4.0, 6.0, 5.0),
			"Expected ArgumentException for negative base length.");
		Assert.Throws<ArgumentException>(() => new Trapezoid(4.0, -6.0, 5.0),
			"Expected ArgumentException for negative base length.");
	}
}
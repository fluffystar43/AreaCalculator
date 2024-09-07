using AreaCalculator.Shapes;

namespace AreaCalculator.Tests.ShapeTests;

/// <summary>
/// Unit tests for the <see cref="Circle"/> class.
/// </summary>
public class CircleTests
{
	/// <summary>
	/// Tests that the area calculation for a circle with a valid radius is correct.
	/// </summary>
	[Test]
	public void CalculateArea_ValidRadius_ReturnsCorrectArea()
	{
		// Arrange
		var circle = new Circle(5.0);
		var expectedArea = Math.PI * Math.Pow(5.0, 2);

		// Act
		var area = circle.CalculateArea();

		// Assert
		Assert.That(area, Is.EqualTo(expectedArea).Within(1e-6), "The area calculated for the circle is not correct.");
	}

	/// <summary>
	/// Tests that creating a circle with an invalid radius throws an exception.
	/// </summary>
	[Test]
	public void CalculateArea_InvalidRadius_ThrowsException()
	{
		// Arrange & Act & Assert
		Assert.Throws<ArgumentException>(() => new Circle(0), "Expected ArgumentException for radius 0.");
		Assert.Throws<ArgumentException>(() => new Circle(-5.0), "Expected ArgumentException for negative radius.");
	}
}
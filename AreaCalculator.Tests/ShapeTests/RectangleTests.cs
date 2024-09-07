using AreaCalculator.Shapes;

namespace AreaCalculator.Tests.ShapeTests;

/// <summary>
/// Unit tests for the <see cref="Rectangle"/> class.
/// </summary>
[TestFixture]
public class RectangleTests
{
	/// <summary>
	/// Tests that the area calculation for a rectangle with valid dimensions is correct.
	/// </summary>
	[Test]
	public void CalculateArea_ValidDimensions_ReturnsCorrectArea()
	{
		// Arrange
		var rectangle = new Rectangle(4.0, 6.0);
		var expectedArea = 24.0;

		// Act
		var area = rectangle.CalculateArea();

		// Assert
		Assert.That(area, Is.EqualTo(expectedArea).Within(1e-6),
			"The area calculated for the rectangle is not correct.");
	}

	/// <summary>
	/// Tests that creating a rectangle with invalid dimensions throws an exception.
	/// </summary>
	[Test]
	public void CalculateArea_InvalidDimensions_ThrowsException()
	{
		// Arrange & Act & Assert
		Assert.Throws<ArgumentException>(() => new Rectangle(0, 1.0), "Expected ArgumentException for zero width.");
		Assert.Throws<ArgumentException>(() => new Rectangle(1.0, -1.0),
			"Expected ArgumentException for negative height.");
	}
}
using AreaCalculator.Shapes;

namespace AreaCalculator.Tests.ShapeTests;

/// <summary>
/// Unit tests for the <see cref="Hexagon"/> class.
/// </summary>
[TestFixture]
public class HexagonTests
{
	/// <summary>
	/// Tests that the area calculation for a hexagon with a valid side length is correct.
	/// </summary>
	[Test]
	public void CalculateArea_ValidSideLength_ReturnsCorrectArea()
	{
		// Arrange
		var hexagon = new Hexagon(6.0);
		var expectedArea = (3 * Math.Sqrt(3) / 2) * Math.Pow(6.0, 2);

		// Act
		var area = hexagon.CalculateArea();

		// Assert
		Assert.That(area, Is.EqualTo(expectedArea).Within(1e-6), "The area calculated for the hexagon is not correct.");
	}

	/// <summary>
	/// Tests that creating a hexagon with an invalid side length throws an exception.
	/// </summary>
	[Test]
	public void CalculateArea_InvalidSideLength_ThrowsException()
	{
		// Arrange & Act & Assert
		Assert.Throws<ArgumentException>(() => new Hexagon(0), "Expected ArgumentException for zero side length.");
		Assert.Throws<ArgumentException>(() => new Hexagon(-6.0),
			"Expected ArgumentException for negative side length.");
	}
}
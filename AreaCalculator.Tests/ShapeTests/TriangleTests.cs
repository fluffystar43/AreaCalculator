using AreaCalculator.Shapes;

namespace AreaCalculator.Tests.ShapeTests;

/// <summary>
/// Unit tests for the <see cref="Triangle"/> class.
/// </summary>
[TestFixture]
public class TriangleTests
{
	/// <summary>
	/// Tests that the area calculation for a triangle with valid sides is correct.
	/// </summary>
	[Test]
	public void CalculateArea_ValidSides_ReturnsCorrectArea()
	{
		// Arrange
		var triangle = new Triangle(3.0, 4.0, 5.0);
		var expectedArea = 6.0;

		// Act
		var area = triangle.CalculateArea();

		// Assert
		Assert.That(area, Is.EqualTo(expectedArea).Within(1e-6),
			"The area calculated for the triangle is not correct.");
	}

	/// <summary>
	/// Tests that the area calculation for a triangle with valid sides is correct.
	/// </summary>
	[Test]
	public void CalculateArea_InvalidSides_ThrowsException()
	{
		// Arrange & Act & Assert
		Assert.Throws<ArgumentException>(() => new Triangle(1.0, 2.0, 3.0),
			"Expected ArgumentException for sides that do not form a valid triangle.");
		Assert.Throws<ArgumentException>(() => new Triangle(-3.0, 4.0, 5.0),
			"Expected ArgumentException for negative side length.");
	}
	
	/// <summary>
	/// Tests if the triangle correctly identifies as a right triangle.
	/// </summary>
	[Test]
	public void IsRightTriangle_RightTriangle_ReturnsTrue()
	{
		// Arrange
		var triangle = new Triangle(3, 4, 5);

		// Act
		var isRightTriangle = triangle.IsRightTriangle();

		// Assert
		Assert.That(isRightTriangle, Is.True, "3-4-5 should be a right triangle.");
	}

	/// <summary>
	/// Tests if the triangle correctly identifies as not a right triangle.
	/// </summary>
	[Test]
	public void IsRightTriangle_NotRightTriangle_ReturnsFalse()
	{
		// Arrange
		var triangle = new Triangle(3, 4, 6);

		// Act
		var isRightTriangle = triangle.IsRightTriangle();

		// Assert
		Assert.That(isRightTriangle, Is.False, "3-4-6 should not be a right triangle.");
	}
}
using SberTask;

namespace SberTasks.Tests;

public class PathHelperTests
{
    [Test]
    [TestCase(0, 0)]
    [TestCase(0, 3)]
    [TestCase(3, 0)]
    public void GetPathCount_ShouldReturnZero_WhenMOrNIsZero(int m, int n)
    {
        // Arrange
        // Act
        var result = PathHelper.GetPathCount(m, n);

        // Assert
        Assert.That(result, Is.Zero);
    }
    
    [Test]
    [TestCase(1, 1, 1)]
    [TestCase(1, 3, 1)]
    [TestCase(3, 1, 1)]
    [TestCase(3, 2, 3)]
    [TestCase(3, 3, 6)]
    public void GetPathCount_ShouldReturnPathCount_WhenNAndNIsMoreThanZero(int n, int m, int expected)
    {
        // Arrange
        // Act
        var result = PathHelper.GetPathCount(m, n);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
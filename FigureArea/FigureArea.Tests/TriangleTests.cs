using System;
using FigureArea.Figures;
using Xunit;
using FluentAssertions;

namespace FigureArea.Tests;

public class TriangleTests
{
    [Fact]
    public void Constructor_ShouldCreateTriangle_WhenValidSides()
    {
        var actual = () => new Triangle(2, 3, 4);
        actual.Should().NotThrow<ArgumentException>();
    }

    [Theory]
    [InlineData(-22, -22, -22)]
    [InlineData(1, 1, 3)]
    [InlineData(2, 5, 3)]
    [InlineData(0, 0, 0)]
    public void Constructor_ShouldThrowException_WhenNotValidSides(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }

    [Theory]
    [InlineData(3, 4, 5)]
    [InlineData(5, 13, 12)]
    [InlineData(145, 144, 17)]
    [InlineData(60, 61, 11)]
    public void IsRectangular_ShouldReturnTrue_WhenRectangularTriangle(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);

        var isRectangular = triangle.IsRectangular();

        Assert.True(isRectangular);
    }

    [Theory]
    [InlineData(3, 3, 3)]
    [InlineData(3, 5, 6)]
    [InlineData(6, 5, 4)]
    [InlineData(13, 18, 17)]
    [InlineData(22, 40, 19)]
    public void IsRectangular_ShouldReturnFalse_WhenNotRectangularTriangle(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);

        var isRectangular = triangle.IsRectangular();

        Assert.False(isRectangular);
    }

    [Theory]
    [InlineData(3, 3, 3, 3.9)]
    [InlineData(3, 4, 5, 6)]
    [InlineData(76, 64, 39, 1247.37)]
    [InlineData(55, 83, 69, 1884.20)]
    [InlineData(69, 83, 55, 1884.20)]
    public void GetArea_ShouldCalculateArea_WhenCorrectTriangle(double a, double b, double c, double expectedArea)
    {
        var triangle = new Triangle(a, b, c);

        var area = triangle.GetArea();

        Assert.Equal(expectedArea, area, 2);
    }
}
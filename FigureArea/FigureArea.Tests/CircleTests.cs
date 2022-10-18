using System;
using FigureArea.Figures;
using Xunit;

namespace FigureArea.Tests;

public class CircleTests
{
    [Fact]
    public void Constructor_ShouldCreateCircle_WhenValidRadius()
    {
        var circle = new Circle(5);
    }

    [Fact]
    public void Constructor_ShouldThrowException_WhenNotValidRadius()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-5));
    }

    [Theory]
    [InlineData(5, 78.54)]
    [InlineData(10, 314.16)]
    [InlineData(61, 11689.87)]
    [InlineData(0, 0)]
    public void GetArea_ShouldCalculateArea_WhenCorrectCircle(double radius, double expectedArea)
    {
        var circle = new Circle(radius);

        var area = circle.GetArea();

        Assert.Equal(expectedArea, area, 2);
    }
}
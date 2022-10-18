using System;
using FigureArea.Domain.Figures;
using Xunit;
using FluentAssertions;

namespace FigureArea.Tests;

public class CircleTests
{
    [Fact]
    public void Constructor_ShouldCreateCircle_WhenValidRadius()
    {
        var act = () => new Circle(5);
        act.Should().NotThrow<ArgumentException>();
    }

    [Fact]
    public void Constructor_ShouldThrowException_WhenNotValidRadius()
    {
        var act = () => new Circle(-5);
        act.Should().Throw<ArgumentException>();
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
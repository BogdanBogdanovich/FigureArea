using FigureArea.FigureCalculation;
using FigureArea.FigureObject;
using NUnit.Framework;

namespace FigureArea.Test;

public class FigureAreaTests
{
    [Test]
    public void TestingCalculateCircleArea()
    {
        const double expectedValue = 63.617251235193308;

        var figureParameter = new FigureParameter()
        {
            Radius = 4.5
        };

        var circleCalc = new Circle();
        FigureParameter result = circleCalc.Calculate(figureParameter);

        Assert.AreEqual(expectedValue, result.Area);
    }
    [Test]
    public void TestingCalculateTriangleArea()
    {
        const double expectedValue = 3.799671038392666;

        var figureParameter = new FigureParameter()
        {
            FirstSide = 2,
            SecondSide = 4,
            ThirdSide = 5
        };

        var triangleCalc = new Triangle();
        FigureParameter result = triangleCalc.Calculate(figureParameter);

        Assert.AreEqual(expectedValue, result.Area);
    }
    [Test]
    public void TestingCalculateRightTriangleArea()
    {
        const double expectedValue = 6;

        var figureParameter = new FigureParameter()
        {
            FirstSide = 4,
            SecondSide = 5,
            ThirdSide = 3
        };

        Triangle triangleCalc = new Triangle();
        FigureParameter result = triangleCalc.Calculate(figureParameter);
        double a = figureParameter.FirstSide;
        double b = figureParameter.SecondSide;
        double c = figureParameter.ThirdSide;
        bool right = triangleCalc.TriangleCheck(a, b, c) || 
                     triangleCalc.TriangleCheck(a, c, b) ||
                     triangleCalc.TriangleCheck(c, b, a);
        Assert.AreEqual(expectedValue, result.Area);
        Assert.True(right);
    }
    [Test]
    public void TestingCalculateRectangleArea()
    {
        const double expectedValue = 20;

        var figureParameter = new FigureParameter()
        {
            FirstSide = 4,
            SecondSide = 5
        };

        var rectangleCalc = new Rectangle();
        FigureParameter result = rectangleCalc.Calculate(figureParameter);

        Assert.AreEqual(expectedValue, result.Area);
    }
    [Test]
    public void TestingCalculateUnknownArea()
    {
        const double expectedValue = 314.15926535897933;

        var figureParameter = new FigureParameter()
        {
            FigureType = FigureType.Circle,
            Radius = 10
        };

        var unknownFigure = new UnknownFigure();
        FigureParameter result = unknownFigure.Calculate(figureParameter);

        Assert.AreEqual(expectedValue, result.Area);
    }
}
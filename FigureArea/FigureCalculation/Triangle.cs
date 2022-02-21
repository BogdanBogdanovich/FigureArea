using FigureArea.FigureObject;

namespace FigureArea.FigureCalculation;

public class Triangle : Calculation
{
    public override FigureParameter Calculate(FigureParameter figureParameter)
    {
        if (figureParameter.FirstSide > 0 && figureParameter.SecondSide > 0 && figureParameter.ThirdSide > 0)
        {
            figureParameter.Perimeter = figureParameter.FirstSide + 
                                        figureParameter.SecondSide + 
                                        figureParameter.ThirdSide;//Вычисление периметра
            double semiPer = 0.5 * figureParameter.Perimeter;//Полупериметр
            
            figureParameter.Area = Math.Sqrt(semiPer * (semiPer - figureParameter.FirstSide) * (semiPer - figureParameter.SecondSide) * (semiPer - figureParameter.ThirdSide));//Вычисление площади

            figureParameter.Messege += $"Площадь треугольника равна {Math.Round(figureParameter.Area, 2)};\n{RightTriangle(figureParameter)}";
            return figureParameter;
        }
        figureParameter.Messege = "Некорректные параметры";
        return figureParameter;
    }

    private string RightTriangle(FigureParameter figureParameter)//Проверка на то, является ли треугольник прямоугольным
    {
        double a = figureParameter.FirstSide;
        double b = figureParameter.SecondSide;
        double c = figureParameter.ThirdSide;
        if (TriangleCheck(a, b, c) || 
            TriangleCheck(a, c, b) || 
            TriangleCheck(c, b, a))
        {
            return figureParameter.Messege = "Треугольник является прямоугольный";
        }
        else
        {
            return figureParameter.Messege = "Треугольник не является прямоугольным";
        }
    }
    public bool TriangleCheck(double firstLeg, double secondLeg, double hypotenuse)//Проверка переданных значений
    {
        return Math.Pow(firstLeg, 2) + Math.Pow(secondLeg, 2) == Math.Pow(hypotenuse, 2);
    }
}
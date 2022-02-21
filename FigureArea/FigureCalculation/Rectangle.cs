using FigureArea.FigureObject;

namespace FigureArea.FigureCalculation;

public class Rectangle : Calculation
{
    public override FigureParameter Calculate(FigureParameter figureParameter)
    {
        if (figureParameter.FirstSide > 0 && figureParameter.SecondSide > 0)//Проверка на корректный ввод
        {
            figureParameter.Area = figureParameter.FirstSide * figureParameter.SecondSide;
            figureParameter.Messege += $"Площадь прямоугольника равна {Math.Round(figureParameter.Area, 2)};\n{SquareCheck(figureParameter)}";
            return figureParameter;
        }
        
        figureParameter.Messege = "Некорректные параметры";
        return figureParameter;
    }
    private string SquareCheck(FigureParameter figureParameter)//Проверка на то, является ли треугольник прямоугольным
    {
        double a = figureParameter.FirstSide;
        double b = figureParameter.SecondSide;
        if (TriangleCheck(a, b))
        {
            return "Стороны прямоугольника равны => квадрат";
        }
        else
        {
            return figureParameter.Messege = "Стороны прямоугольника не равны. Не является квадратом";
        }

        bool TriangleCheck(double firstSide, double secondSide)//Проверка переданных значений
        {
            return firstSide == secondSide;
        }
    }
}
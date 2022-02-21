using FigureArea.FigureObject;

namespace FigureArea.FigureCalculation;

public class Circle : Calculation
{
    public override FigureParameter Calculate(FigureParameter figureParameter)
    {
        if (figureParameter.Radius > 0)//Проверка радиуса, в том случае, если радиус меньше или равен 0
        {
            figureParameter.Area = Math.PI * Math.Pow(figureParameter.Radius, 2);
            figureParameter.Messege += $"Площадь круга с радиусом {figureParameter.Radius} равна {Math.Round(figureParameter.Area, 2)}";
            return figureParameter;
        }
        figureParameter.Messege = "Радиус должен быть больше 0";
        return figureParameter;
    }
}
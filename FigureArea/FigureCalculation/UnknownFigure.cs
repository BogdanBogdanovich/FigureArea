using FigureArea.FigureObject;

namespace FigureArea.FigureCalculation;

public class UnknownFigure : Calculation
{
    //Реализовал вычисление площади фигуры (без типа фигуры) через количество значений, которые введёт пользователь.
    //Если пользователь передаст лист значений с одним значением, то, вероятнее всего,
    //фигура будет являться кругом(т.к. площадь круга вычислаяетя через её радиус и константу числа Пи)
    //Другие фигуры по той же схеме...
    public object TypeCheckForConsoleApp()//Для консольного приложения
    {
        var values = new List<double?>();
        Console.WriteLine("Введите значения!\nЗначения должны быть больше 0\nЕсли значений нет, нажмите клавишу 'Enter': ");
        for (int i = 1; i <= 3; i++)
        {
            Console.Write($"{i})");
            string getValue = Console.ReadLine();
            if (getValue != "")
            {
                double value = Convert.ToDouble(getValue);
                if (value > 0)
                    values.Add(value);
                else if (value <= 0)
                    Console.WriteLine("Некорректное значение!");
            }
            else
            {
                return ListSplit(values);
            }
        }

        return ListSplit(values);
    }
    public object ListSplit(List<double?> values)//Перебор списка со значениями
    {
        FigureParameter figureParameter = new FigureParameter();
        if (values.Count == 1)
        {
            figureParameter.Radius = (double)values[0];
            figureParameter.FigureType = FigureType.Circle;
        }
        else if (values.Count == 2)
        {
            figureParameter.FirstSide = (double)values[0];
            figureParameter.SecondSide = (double)values[1];
            figureParameter.FigureType = FigureType.Rectangle;
        }
        else if (values.Count == 3)
        {
            figureParameter.FirstSide = (double)values[0];
            figureParameter.SecondSide = (double)values[1];
            figureParameter.ThirdSide = (double)values[2];
            figureParameter.FigureType = FigureType.Triangle;
        }

        return figureParameter;
    }
    public override FigureParameter Calculate(FigureParameter figureParameter)
    {
        //Исходя из типа фигуры вызываем метод соответствующий для данной фигуры
        if (figureParameter.FigureType == FigureType.Circle)
        {
            Circle circle = new Circle();
            figureParameter.Messege = "Фигура является кругом\n";
            circle.Calculate(figureParameter);
            return figureParameter;
        }
        else if (figureParameter.FigureType == FigureType.Rectangle)
        {
            Rectangle rectangle = new Rectangle();
            figureParameter.Messege = "Тип фигуры - прямоугольник\n";
            rectangle.Calculate(figureParameter);
            return figureParameter;
        }
        else if (figureParameter.FigureType == FigureType.Triangle)
        {
            Triangle triangle = new Triangle();
            figureParameter.Messege = "Тип фигуры - треугольник\n";
            triangle.Calculate(figureParameter);
            return figureParameter;
        }

        return figureParameter;
    }
}
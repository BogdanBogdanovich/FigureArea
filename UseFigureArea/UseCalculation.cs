using FigureArea;
using FigureArea.FigureCalculation;
using FigureArea.FigureObject;


Console.WriteLine("Выберите тип фигуры:");
Console.WriteLine("1.Круг");
Console.WriteLine("2.Треугольник");
Console.WriteLine("3.Неизвестная фигура");
var typeFigure = Convert.ToInt32(Console.ReadLine());

if (typeFigure == 1)
{
    Console.WriteLine("Введите радиус круга: ");
    var rad = Convert.ToDouble(Console.ReadLine());
    
    var paramCircle = new FigureParameter()
    {
        FigureType = FigureType.Circle,
        Radius = rad
    };
    
    Calculation circle = new Circle();
    circle.Calculate(paramCircle);
    Console.WriteLine(paramCircle.Messege);
}

else if (typeFigure == 2)
{
    Console.WriteLine("Введите стороны треугольника: ");
    Console.Write("1)");
    var firstSide = Convert.ToDouble(Console.ReadLine());
    Console.Write("2)");
    var secondSide = Convert.ToDouble(Console.ReadLine());
    Console.Write("3)");
    var thirdSide = Convert.ToDouble(Console.ReadLine());
    
    var paramTriangle = new FigureParameter()
    {
        FigureType = FigureType.Triangle,
        FirstSide = firstSide,
        SecondSide = secondSide,
        ThirdSide = thirdSide
    };
    Calculation triangle = new Triangle();
    triangle.Calculate(paramTriangle);
    Console.WriteLine(paramTriangle.Messege);
}

else if (typeFigure == 3)
{
    UnknownFigure unknown = new UnknownFigure();
    FigureParameter figureParameter = unknown.Calculate((FigureParameter)unknown.TypeCheckForConsoleApp());
    Console.WriteLine(figureParameter.Messege);
}

else
{
    Console.WriteLine("Фигуры с таким номером на данный момент не существует");
}




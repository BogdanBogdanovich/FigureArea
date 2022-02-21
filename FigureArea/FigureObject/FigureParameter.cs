namespace FigureArea.FigureObject;

public class FigureParameter//Параметры фигур(выбрал данный способ для использования всей информации о фигуре).
{
    public double FirstSide { get; set; }
    public double SecondSide { get; set; }
    public double ThirdSide { get; set; }
    public double Radius { get; set; }
    public FigureType FigureType { get; set; }
    public double Perimeter { get; set; }
    public double Area { get; set; }
    public string Messege { get; set; }
    
}
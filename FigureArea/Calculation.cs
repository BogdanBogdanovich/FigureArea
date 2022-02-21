using FigureArea.FigureObject;

namespace FigureArea;

public abstract class Calculation//Базовый класс для всех фигур
{
    public abstract FigureParameter Calculate(FigureParameter figureParameter);
}
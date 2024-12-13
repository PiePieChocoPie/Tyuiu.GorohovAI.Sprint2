using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GorohovAI.Sprint2.Task7.V8.Lib
{
    public class DataService : ISprint2Task7V8
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool isInside = (x <= 1 && y <= Math.Pow(x, 2)) || (x > 1 && y <= 4);
            return isInside;
        }
    }
}

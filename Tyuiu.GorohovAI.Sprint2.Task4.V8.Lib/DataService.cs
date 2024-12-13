using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GorohovAI.Sprint2.Task4.V8.Lib
{
    public class DataService : ISprint2Task4V8
    {
        public double Calculate(double x, double y)
        {

            double z = 0;
            if (x * 2 > y + 15)
            {
                z = Math.Pow((5 + (Math.Pow(y + 5, 1 / 2) / Math.Pow(x, 3))), x);
            }
            else
            {
                z = 2 * Math.Pow(x,2) + 2 * x - (4 + (6/Math.Pow(y,2)));
            }
            return z;
        }
    }
}

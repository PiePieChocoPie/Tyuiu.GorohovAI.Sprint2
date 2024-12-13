using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GorohovAI.Sprint2.Task3.V8.Lib
{
    public class DataService : ISprint2Task3V8
    {
        public double Calculate(double x)
        {
            double y;
            if (x > 0)
            {
                y = Math.Sin(x) + Math.Cos(x);
            }
            else if (x == 0)
            {
                y = Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10;
            }
            else if (x > -12 && x < 0)
            {
                y = Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12 / x;
            }
            else if (x <= -12)
            {
                y = x + 10 * x - (5 / x);
            }
            else
            {
                y = 1 + (3 / Math.Pow(x, 2));
            }

            // Округление до трёх знаков
            y = Math.Round(y, 3);

            return y;
        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GorohovAI.Sprint2.Task2.V24.Lib
{
    public class DataService : ISprint2Task2V24
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool isInShadedArea =
            (x >= 3 && x <= 6 && y >= 3 && y <= 6) ||  // Верхний левый квадрат
            (x >= 10 && x <= 13 && y >= 3 && y <= 6) || // Верхний правый квадрат
            (x >= 4 && x <= 12 && y >= 7 && y <= 9) ||  // Средняя горизонтальная полоса
            (x >= 3 && x <= 6 && y >= 10 && y <= 13) || // Нижний левый квадрат
            (x >= 10 && x <= 13 && y >= 10 && y <= 13); // Нижний правый квадрат

            if (isInShadedArea)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

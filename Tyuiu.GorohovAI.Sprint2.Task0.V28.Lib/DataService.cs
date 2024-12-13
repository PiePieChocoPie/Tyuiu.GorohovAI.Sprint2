using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GorohovAI.Sprint2.Task0.V28.Lib
{
    public class DataService : ISprint2Task0V28
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            // Логические операции
            bool[] results = new bool[6];
            results[0] = x == y;      // Равны ли x и y
            results[1] = x != y;      // Не равны ли x и y
            results[2] = x < y;       // Меньше ли x, чем y
            results[3] = x > y;       // Больше ли x, чем y
            results[4] = x <= y;      // Меньше или равно ли x, чем y
            results[5] = x >= y;      // Больше или равно ли x, чем y

            // Вывод результатов
            return results;
        }
    }
}

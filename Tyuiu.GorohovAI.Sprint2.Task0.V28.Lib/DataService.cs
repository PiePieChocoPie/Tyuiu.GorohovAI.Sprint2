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
            results[1] = false;      // Не равны ли x и y
            results[2] = false;       // Меньше ли x, чем y
            results[3] = false;       // Больше ли x, чем y
            results[4] = false;      // Меньше или равно ли x, чем y
            results[5] = false;      // Больше или равно ли x, чем y

            // Вывод результатов
            return results;
        }
    }
}

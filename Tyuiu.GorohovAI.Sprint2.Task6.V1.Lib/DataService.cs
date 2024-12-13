using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GorohovAI.Sprint2.Task6.V1.Lib
{
    public class DataService : ISprint2Task6V1
    {
        public int FindMonthDaysCount(int value)
        {
            int daysInMonth = value switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31, // Январь, Март, Май, Июль, Август, Октябрь, Декабрь
                4 or 6 or 9 or 11 => 30,              // Апрель, Июнь, Сентябрь, Ноябрь
                2 => 28,                              // Февраль (без учёта високосного года)
                _ => -1                               // Некорректный ввод
            };

            if (daysInMonth != -1)
            {
                Console.WriteLine($"В месяце {value} дней: {daysInMonth}");
            }
            else
            {
                Console.WriteLine("Ошибка: номер месяца должен быть в диапазоне от 1 до 12.");
            }
            return daysInMonth;
        }
    }
}

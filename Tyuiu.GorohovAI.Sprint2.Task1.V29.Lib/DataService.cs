using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GorohovAI.Sprint2.Task1.V29.Lib
{
    public class DataService : ISprint2Task1V29
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            // Логические операции
            bool[] results = new bool[6];
            results[0] = (a == c) & (b < a);           // True: a равно c И b меньше a
            results[1] = (b != d) | (a >= c);         // True: b не равно d ИЛИ a больше или равно c
            results[2] = !(b > a) && (c == d);        // True: b не больше a И c равно d
            results[3] = (a < b) ^ (c != d);          // False: a меньше b XOR c не равно d
            results[4] = (a <= d) && !(b >= c);       // True: a меньше или равно d И b не больше или равно c
            results[5] = (a == b) || (c == d);        // True: a равно b ИЛИ c равно d

            return results;

        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ChashkovTA.Sprint6.Task2.V27.Lib
{
    public class DataService : ISprint6Task2V27
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int arraySize = stopValue - startValue + 1;
            double[] functionValues = new double[arraySize];

            for (int x = startValue; x <= stopValue; x++)
            {
                double result = CalculateFunction(x);
                functionValues[x - startValue] = result;
            }

            return functionValues;
        }
        private double CalculateFunction(int x)
        {
            try
            {
                double numerator = 2 * x - 3;
                double denominator = Math.Cos(x) - 2 * x;

                if (denominator == 0)
                {
                    return 0; // Возвращаем 0 при делении на ноль
                }

                double result = (numerator / denominator) + 5 * x - Math.Sin(x);
                return Math.Round(result, 2); // Округление до 2 знаков после запятой
            }
            catch (Exception)
            {
                return 0; // Обработка ошибок, если вдруг что-то пойдет не так
            }
        }
    }
}


using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ChashkovTA.Sprint6.Task4.V17.Lib
{
    public class DataService : ISprint6Task4V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int size = stopValue - startValue + 1; 
            double[] result = new double[size];

            for (int i = 0; i < size; i++)
            {
                int x = startValue + i;

                if (x == 0)
                {
                    result[i] = 0; 
                }
                else
                {
                    // Функция F(x)
                    result[i] = (Math.Sin(x) / x) + 1.7 - (Math.Cos(x) * 4 * x) - 6;
                }

                result[i] = Math.Round(result[i], 2);
            }

            return result;
        }
    }
}

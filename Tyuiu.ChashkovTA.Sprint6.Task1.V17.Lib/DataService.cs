using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ChashkovTA.Sprint6.Task1.V17.Lib
{
    public class DataService : ISprint6Task1V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = stopValue - startValue + 1;
            double[] results = new double[count];

            for (int i = 0; i < count; i++)
            {
                double x = startValue + i;
                double y;

                try
                {
                    y = CalculateF(x);
                }
                catch (DivideByZeroException)
                {
                    y = 0; // Handle division by zero
                }

                results[i] = y;
            }

            return results;
        }
    }
}

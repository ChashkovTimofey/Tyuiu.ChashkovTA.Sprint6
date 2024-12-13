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
    }
}

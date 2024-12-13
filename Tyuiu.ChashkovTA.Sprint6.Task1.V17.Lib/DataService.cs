using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ChashkovTA.Sprint6.Task1.V17.Lib
{
    public class DataService : ISprint6Task1V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {

            Func<int, double> function = x => Math.Pow(x, 2) + 2 * x - 5;

            int step = 1; 

            double[] result = new double[(stopValue - startValue) / step + 1];  

            int index = 0;
            for (int x = startValue; x <= stopValue; x += step)
            {
                try
                {
                    result[index] = function(x);
                    index++;
                }
                catch (Exception ex)
                {
                    return null; 
                }
            }

            return result;
        }
    }
}

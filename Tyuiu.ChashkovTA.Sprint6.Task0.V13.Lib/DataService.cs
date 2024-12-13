using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ChashkovTA.Sprint6.Task0.V13.Lib
{
    public class DataService : ISprint6Task0V13
    {
        public double Calculate(int x)
        {
            double numerator = Math.Pow(x, 3);
            double denominator = Math.Pow(x, 2) - 1;

            if (denominator == 0)
            {
                return 0;
            }

            double result = numerator / denominator;
            return Math.Round(result, 3);
        }
    }
}

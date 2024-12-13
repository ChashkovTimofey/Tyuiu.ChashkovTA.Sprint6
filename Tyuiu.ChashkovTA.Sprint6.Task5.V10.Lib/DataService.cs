using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ChashkovTA.Sprint6.Task5.V10.Lib
{
    public class DataService : ISprint6Task5V10
    {
        public double[] LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл по пути {path} не найден.");
            }

            List<double> dataList = new List<double>();

            foreach (var line in File.ReadLines(path))
            {
                string[] parts = line.Split(new[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var part in parts)
                {
                    if (double.TryParse(part, out double value))
                    {
                        double roundedValue = Math.Round(value, 2); // Округление до 2 знаков после запятой
                        if (roundedValue != 0) // Игнорировать нули
                        {
                            dataList.Add(roundedValue);
                        }
                    }
                }
            }

            return dataList.ToArray();
        }
    }
}

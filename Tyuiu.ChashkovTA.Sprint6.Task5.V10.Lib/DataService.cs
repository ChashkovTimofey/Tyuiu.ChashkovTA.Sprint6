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

                string[] parts = line.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var part in parts)
                {
                    if (double.TryParse(part, out double value))
                    {
                        dataList.Add(Math.Round(value, 3));
                    }
                }
            }

            List<double> filteredData = new List<double>();
            foreach (var data in dataList)
            {
                if (data != 0)
                {
                    filteredData.Add(data);
                }
            }

            return filteredData.ToArray();
        }
    }
}

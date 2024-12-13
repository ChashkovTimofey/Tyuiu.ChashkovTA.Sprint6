using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ChashkovTA.Sprint6.Task7.V30.Lib
{
    public class DataService : ISprint6Task7V30
    {
        public int[,] GetMatrix(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Файл не найден.");
            }

            try
            {
                string[] lines = File.ReadAllLines(path);
                int rowCount = lines.Length;
                int colCount = lines[0].Split(',').Length;
                int[,] matrix = new int[rowCount, colCount];

                for (int i = 0; i < rowCount; i++)
                {
                    int[] rowValues = lines[i].Split(',').Select(int.Parse).ToArray();
                    for (int j = 0; j < colCount; j++)
                    {
                        matrix[i, j] = rowValues[j];
                    }
                }

                for (int i = 0; i < rowCount; i++)
                {
                    if (matrix[i, 0] != 4)
                    {
                        matrix[i, 0] = 8;
                    }
                }

                return matrix;
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка обработки файла: " + ex.Message);
            }
        }

        public void SaveMatrix(string path, int[,] matrix)
        {
            try
            {
                int rowCount = matrix.GetLength(0);
                int colCount = matrix.GetLength(1);
                string[] lines = new string[rowCount];

                for (int i = 0; i < rowCount; i++)
                {
                    string[] rowValues = new string[colCount];
                    for (int j = 0; j < colCount; j++)
                    {
                        rowValues[j] = matrix[i, j].ToString();
                    }
                    lines[i] = string.Join(",", rowValues);
                }

                File.WriteAllLines(path, lines);
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка сохранения файла: " + ex.Message);
            }
        }
    }
}

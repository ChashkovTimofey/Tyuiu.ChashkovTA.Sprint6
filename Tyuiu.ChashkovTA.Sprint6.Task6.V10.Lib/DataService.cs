using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ChashkovTA.Sprint6.Task6.V10.Lib
{
    public class DataService : ISprint6Task6V10
    {
        public string CollectTextFromFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Файл не найден.");
            }

            try
            {
                string content = File.ReadAllText(path);
                string[] words = content.Split(new[] { ' ', '\t', '\n', '\r', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                string[] wordsWithW = words.Where(word => word.Contains("w") ).ToArray();
                return string.Join(" ", wordsWithW);
            }
            catch (Exception ex) 
            {
                throw new Exception("Ошибка обработки файла: " + ex.Message);
            }
        }
    }
}

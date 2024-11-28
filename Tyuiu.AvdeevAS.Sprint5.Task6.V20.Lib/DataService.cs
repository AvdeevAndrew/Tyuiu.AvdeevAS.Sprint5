using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AvdeevAS.Sprint5.Task6.V20.Lib
{
    public class DataService : ISprint5Task6V20
    {
        public int LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл по пути {path} не найден.");
            }

            int count = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Разделяем строку на слова
                    string[] words = line.Split(new[] { ' ', '\t', '\n', '\r', ',', '.', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

                    // Считаем слова длиной 6 символов
                    foreach (string word in words)
                    {
                        if (word.Length == 6)
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }
    }
}

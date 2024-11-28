using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AvdeevAS.Sprint5.Task7.V6.Lib
{
    public class DataService : ISprint5Task7V6
    {
        public string LoadDataAndSave(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл по пути {path} не найден.");
            }

            // Чтение содержимого файла
            string fileContent = File.ReadAllText(path);

            // Замена всех латинских букв на #
            string updatedContent = Regex.Replace(fileContent, "[a-zA-Z]", "#");

            // Путь для сохранения нового файла
            string outputPath = Path.Combine(Path.GetDirectoryName(path), "OutPutDataFileTask7V6.txt");

            // Сохранение результата в новый файл
            File.WriteAllText(outputPath, updatedContent);

            return outputPath;
        }
    }
}

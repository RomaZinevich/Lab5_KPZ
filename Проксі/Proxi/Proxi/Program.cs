using Proxi;

class Program
{
    static void Main(string[] args)
    {
        //Головний клас
        SmartTextReader reader = new SmartTextReader("file.txt");
        char[][] chars = reader.ReadFile();

        Console.WriteLine($"Кiлькiсть рядкiв: {chars.Length}");

        //Перевірка логування
        SmartTextChecker checker = new SmartTextChecker("file.txt");
        chars = checker.ReadFile();

        //Перевірка чи дозволено доступ до цього файлу
        SmartTextReaderLocker locker = new SmartTextReaderLocker("file.txt", "file.txt");
        chars = locker.ReadFile();
    }
}
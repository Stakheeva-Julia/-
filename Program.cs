using System;
using System.IO;

class CreateFile
{
    static void Main()
    {
        // Расположение файла вместе с расширением писать
        Console.WriteLine("Введите путь к файлу, который вы хотите создать:");
        string filePath = Console.ReadLine();

        try
        {
            // Создание файла и запись в него текста
            using (StreamWriter writer = new StreamWriter(filePath))

            Console.WriteLine("Файл успешно создан по пути: " + filePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
    }
}

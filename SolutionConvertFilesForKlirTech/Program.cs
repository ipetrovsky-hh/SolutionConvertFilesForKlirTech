// See https://aka.ms/new-console-template for more information
using SolutionConvertFilesForKlirTech.Models;

Console.WriteLine(MessageType.introMessage);

Console.WriteLine(" Начата обработка файлов-логов проекта.");

FileInfo fileFirst = new FileInfo(@MessageType.testFilePathF);
await InformationFile.CreateAsync(fileFirst,"Type1");

FileInfo fileSecond = new FileInfo(@MessageType.testFilePathS);
await InformationFile.CreateAsync(fileSecond, "Type2");

// Читаем содержимое и записываем
WriteInformationFiles wIF = new WriteInformationFiles();
wIF.ConcatFiles();

Console.WriteLine(" Обработка завершена. Результат: " + AppDomain.CurrentDomain.BaseDirectory.ToString());

Console.ReadLine();


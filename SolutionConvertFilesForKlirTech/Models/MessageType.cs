using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionConvertFilesForKlirTech.Models
{
    public static class MessageType
    {
        public static string fileFirst = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
            "Files", "format1Result.txt");

        public static string fileSecond = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
            "Files", "format2Result.txt");

        public static string fileErrors = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
            "Files", "problems.txt");

        public static string fileConcatResults = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
        "Files", "results.txt");


        public static Dictionary<string, string> messagesDict = new Dictionary<string, string>()
        {
            { "INFORMATION", "INFO" },
            { "ERROR", "ERROR" },
            { "DEBUG", "DEBUG" },
            { "WARNING", "WARN" },
            { "INFO", "INFO" },
            { "WARN", "WARN" },
        };   
        
        public static string introMessage = "Задача 3" +
"\r\nКонсольная программа для стандартизации лог-файлов" +
"\r\nЭта программа предназначена для обработки лог-файлов, " +
"\r\nсодержащих записи в двух разных форматах. " +
"\r\nЦель программы – привести все записи к единому, стандартному виду, " +
"\r\nупрощая анализ и обработку логов. " +
"\r\nНеобходимо преобразовать записи из входного лог-файла в единый формат " +
"\r\nи сохранить их в выходной файл. " +
"\r\nВажно замечание:" +
"\r\nВ случае, если входная запись оказывается невалидной," +
"\r\nнеобходимо ее записывать в другой выходной файл с названием problems.txt." +
"\r\n Формат записи исходный.\r\n";

        public static string testFilePathF = Path.Combine(
    AppDomain.CurrentDomain.BaseDirectory, "Files", "format1.txt");

        public static string testFilePathS = Path.Combine(
    AppDomain.CurrentDomain.BaseDirectory, "Files", "format2.txt");
    }
}

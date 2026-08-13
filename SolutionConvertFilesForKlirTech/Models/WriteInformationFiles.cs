using SolutionConvertFilesForKlirTech.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionConvertFilesForKlirTech.Models
{
    public class WriteInformationFiles: AbstractWriteInformationFiles
    {
        public override void WriteFileTypeFirst(string fileName, string[] words)
        {
            using (StreamWriter sw = File.AppendText(fileName))
            {
                // Записываем строки
                sw.WriteLineAsync("Дата : " + words[0]);
                sw.WriteLineAsync("Время : " + words[1]);
                sw.WriteLineAsync("УровеньЛогирования : " +
                    MessageType.messagesDict[words[2]]);
                sw.WriteLineAsync("ВызвавшийМетод: DEFAULT");
                sw.WriteLineAsync("Сообщение : " +
                    words[3].Replace("Версияпрограммы", "Версия программы") + " " +
                    words[4]);
                sw.WriteLineAsync("");
            }
        }

        public override void WriteFileTypeSecond(string fileName, string[] words)
        {
            using (StreamWriter sw = File.AppendText(fileName))
            {
                string[] wordsSecond = words[0].Split(new char[] { ' ' });
                // Записываем строки
                sw.WriteLineAsync("Дата : " + DateTime.Parse(wordsSecond[0]).ToString("dd.MM.yyyy"));
                sw.WriteLineAsync("Время : " + wordsSecond[1]);
                sw.WriteLineAsync("УровеньЛогирования : " +
                    MessageType.messagesDict[words[1].Trim()]);
                sw.WriteLineAsync("ВызвавшийМетод : " + words[3]);
                sw.WriteLineAsync("Сообщение : " + words[4]);
                sw.WriteLineAsync("Код устройства: " + words[4].Split(new char[] { ' ' })[3]);
                sw.WriteLineAsync("");
            }
        }

        public override void WriteProblems(string fileName, string words)
        {
            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLineAsync(words);
            }
        }

        public void ConcatFiles()
        {            
            string content1 = File.ReadAllText(MessageType.fileFirst);
            string content2 = File.ReadAllText(MessageType.fileSecond);
            File.WriteAllText(MessageType.fileConcatResults, content1 + content2);
        }
    }
}

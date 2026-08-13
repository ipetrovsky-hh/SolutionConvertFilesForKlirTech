using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SolutionConvertFilesForKlirTech.Models
{
    public class InformationFile
    {
        private string testFilePathF;
        private string testFilePathS;
        private string testFilePathErrors;

        public InformationFile()
        {
            testFilePathF = MessageType.fileFirst;
            testFilePathS = MessageType.fileSecond;
            testFilePathErrors = MessageType.fileErrors;
        }

        public static async Task<InformationFile> CreateAsync(FileInfo filename, string typeFormat)
        {
            var instance = new InformationFile();
            await instance.InitializeAsync(filename, typeFormat); // Асинхронная инициализация
            return instance;
        }

        private async Task InitializeAsync(FileInfo fileName,string typeFormat)
        {
            WriteInformationFiles wIF = new WriteInformationFiles();

            using (StreamReader reader = fileName.OpenText())
            {
                string[] words;

                string textReader;

                while ((textReader = await reader.ReadLineAsync()) != null)
                {
                    switch (typeFormat)
                    {
                        case "Type1":

                            textReader = textReader.Replace("Версия программы",
                                "Версияпрограммы");

                            words = textReader.Split(new char[] { ' ' });
                            try 
                            {
                                wIF.WriteFileTypeFirst(testFilePathF, words);
                            }
                            catch 
                            {
                                wIF.WriteProblems(testFilePathErrors, textReader);
                            }
                            break;
                        case "Type2":

                            textReader = textReader.Replace("Версия программы",
                                "Версияпрограммы");

                            words = textReader.Split(new char[] { '|' });
                            try
                            {
                                wIF.WriteFileTypeSecond(testFilePathS, words);
                            }
                            catch
                            {
                                wIF.WriteProblems(testFilePathErrors, textReader);
                            }
                    break;
                        default:
                            break;
                    }
                }
            }
        }           
    }
}

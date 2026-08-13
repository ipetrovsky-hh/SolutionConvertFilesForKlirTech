using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionConvertFilesForKlirTech.Abstracts
{
    public abstract class AbstractWriteInformationFiles
    {
        public abstract void WriteFileTypeFirst(string fileName, string[] words);
        public abstract void WriteFileTypeSecond(string fileName, string[] words);
        public abstract void WriteProblems(string fileName, string words);
    }
}

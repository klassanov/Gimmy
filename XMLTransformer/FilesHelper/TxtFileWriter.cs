using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesHelper
{
    public class TxtFileWriter
    {
        private static ILog Logger = LogManager.GetLogger(typeof(TxtFileWriter));
        public static void WriteFile(string filePath=null)
        {            
            filePath = filePath ?? "D:/SW Development/Customers/Gimmy/XML Transformer/MyTextFile.txt";
            string fileContent = string.Format("{0}{1}{2}{3}{4}", "Prova", Environment.NewLine, "Jimmy", Environment.NewLine, "Schettini");
            File.WriteAllLines(filePath, new string[] {fileContent});
            Logger.DebugFormat("File {0} successfully written.", filePath);
        }
    }
}

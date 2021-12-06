using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoText
{
    class DataFile
    {
        public static readonly string FILE_NAME = "Data.txt";

        public static void saveRowInFile(String key, String value)
        {
            StreamWriter writer = new StreamWriter(FILE_NAME, true);
            writer.WriteLine(key + ':' + value);
            writer.Close();
        }

        public static void updateRowInFile(String beforeKey, String beforeValue, String afterKey, String afterValue)
        {
            StreamReader reader = new StreamReader(FILE_NAME);
            String text = reader.ReadToEnd();
            String newText = text.Replace(beforeKey + ':' + beforeValue, afterKey + ':' + afterValue);
            reader.Close();
            File.WriteAllText(FILE_NAME, newText);
        }

        public static void deleteRowInFile(int selectedRowIndex)
        {
            List<String> lines = File.ReadAllLines(FILE_NAME).ToList();
            lines.RemoveAt(selectedRowIndex);
            File.WriteAllLines(FILE_NAME, lines);
        }
    }
}

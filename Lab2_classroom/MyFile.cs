using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab2_classroom
{
    abstract class MyFile
    {
        protected string Path;
        protected string AllText;

        public abstract void Open();
        public abstract void Close();
        public abstract string Seek(string word);
        public abstract string Read();
        public abstract void Write(string data);
        public abstract int GetPosition(string word);
        public abstract int GetLength();
    }

    class MyDataFile1 : MyFile
    {
        public MyDataFile1(string path)
        {
            Path = path;
            AllText = "";
        }

        public override void Open()
        {
            Console.WriteLine(File.Exists(Path) ? "Файл типа MyDataFile1 открыт." : "Файл типа MyDataFile1 не найден.");
        }

        public override void Close()
        {
            Console.WriteLine(File.Exists(Path) ? "Файл типа MyDataFile1 закрыт." : "Файл типа MyDataFile1 не найден.");
        }

        public override string Seek(string word)
        {
            if (AllText == "")
            {
                Console.WriteLine("Данные из файла не считаны. Поиск невозможен.");
                return "";
            }
            var words = AllText.Split(' ');
            var found = "";
            foreach (var s in words.Where(s => s == word))
                found = s;
            return found == "" ? "Такого слова нет в файле." : "Такое слово есть в файле.";
        }

        public override string Read()
        {
            AllText = File.ReadAllText(Path);
            return AllText;
        }

        public override void Write(string data)
        {
            using (var fs = File.OpenWrite(Path))
            {
                var info = new UTF8Encoding(true).GetBytes(AllText + data);
                fs.Write(info, 0, info.Length);
            }
        }

        public override int GetPosition(string word)
        {
            var words = AllText.Split(' ');
            var position = 0;
            for (var i = 0; i != words.Length; i++)
            {
                if (words[i] != word) continue;
                position = i + 1;
                break;
            }
            return position;
        }

        public override int GetLength()
        {
            return AllText.Length;
        }
    }

    class Test
    {
        static void Main()
        {
            const string path = @"c:\users\ilshat\test.txt";
            var file = new MyDataFile1(path);
            file.Open();
            file.Read();
            Console.WriteLine(file.Seek("Vaider"));
            file.Write("And Full Of Power.");
            Console.WriteLine("Слово Darth стоит {0} в файле.", file.GetPosition("Darth"));
            Console.WriteLine("В файле {0} символов.", file.GetLength());
            file.Close();
        }
    }
}

using System;
using System.IO;

namespace Lab2_classroom
{
    abstract class MyFile
    {
        protected string Path;

        public abstract void Open();
        public abstract void Close();
        public abstract string Seek();
        public abstract string Read();
        public abstract void Write(string data);
        public abstract int GetPositioin();
        public abstract int GetLength();
    }

    class MyDataFile1 : MyFile
    {
        public MyDataFile1(string path)
        {
            Path = path;
        }

        public override void Open()
        {
            var file = new FileInfo(Path);
            Console.WriteLine(file.Exists ? "Файл типа MyDataFile1 открыт." : "Файл типа MyDataFile1 не найден.");
        }

        public override void Close()
        {
            var file = new FileInfo(Path);
            Console.WriteLine(file.Exists ? "Файл типа MyDataFile1 закрыт." : "Файл типа MyDataFile1 не найден.");
        }

        public override string Seek()
        {
            var file = new FileInfo(Path);
            string[] readText;
            using (var fs = file.OpenRead())
            {
                
            }
        }
    }
}

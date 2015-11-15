using System;
using System.IO;

namespace Lab2_classroom
{
    abstract class File
    {
        public abstract void Open(string path);
        public abstract void Close();
        public abstract string Seek();
        public abstract string Read();
        public abstract void Write(string data);
        public abstract int GetPositioin();
        public abstract int GetLength();
    }

    class MyDataFile1 : File
    {
        public override void Open(string path)
        {
            var file = new FileInfo(path);
            Console.WriteLine(file.Exists ? "Файл типа MyDataFile1 открыт." : "Файл типа MyDataFile1 не найден.");
        }
    }
}

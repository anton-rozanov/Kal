using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace App2.Views
{
    static class FileWorker
    {
        static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        static string filename = "data.dat";
        // сохранение текста в файл
        async static void Save(object output)
        {
            if (String.IsNullOrEmpty(filename)) return;
            // перезаписываем файл
            File.WriteAllLines(Path.Combine(folderPath, filename), Data.ToStringArray());
            Label outL = (Label)output;
            outL.Text = "Save done!";
        }
        async static void Load(object output)
        {
            if (String.IsNullOrEmpty(filename)) return;
            // перезаписываем файл
            string[] inp = File.ReadAllLines(Path.Combine(folderPath, filename));
            Data.data = new Day[365];
            Data.FromStringArray(inp);
            Label outL = (Label)output;
            outL.Text = "Load done!";
        }
    }
}

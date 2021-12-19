using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Views
{
    static class Data
    {
        public static Day [] data = new Day [365];
        public static int qrentDay;
        public static Year[] years = new Year[1];
        public static int qrentMonth;
        public static string[] monthsNames = { "January", "February", "March", "April", "May", "June", "Jule", "August", "September", "October", "November", "December" };
        public static List<Month> months = new List<Month>();
        public static string[] ToStringArray()
        {
            string[] data = new string[365];
            for (int i = 0; i < 365; i++)
            {
                string output = "";
                if (Data.data[i].notification.Notification.Count > 0 && Data.data[i].tasks.Content.Count > 0)
                {
                    for (int j = 0; j < Data.data[i].tasks.Content.Count;)
                    {
                        List<Task> t = Data.data[i].tasks.Content;
                        output += t[j].name + '|' + t[j].dopname + '|' + t[j].time.ToString() + ';';
                        j = j + 1;
                    }
                    output += "_;";
                    for (int j = 0; j < Data.data[i].notification.Notification.Count;)
                    {
                        List<Notification> t = Data.data[i].notification.Notification;
                        output += t[j].name + '|' + t[j].time.ToString() + ';';
                        j = j + 1;
                    }
                    data[i] = output + '\n';
                } 
                else
                {
                    data[i] = "" + '\n';
                }
            }
            return data;
        }
        public static void FromStringArray(string[] FromFile)
        {
            for(int i = 0; i < FromFile.Length;i++)
            {
                if (FromFile.Length != 0) 
                { 
                    string[] lines = FromFile[i].Split('_');
                
                    string[] tasks = lines[0].Split(';');
                    string[] notifications = lines[1].Split(';');
                    for (int j = 0; j < tasks.Length; j++ )
                    {
                        string name = tasks[j].Split('|')[0];
                        string dopname = tasks[j].Split('|')[1];
                        time Time = time.FromString(tasks[j].Split('|')[2]);
                        Data.data[i].tasks.Content.Add(new Task(name, dopname, Time));
                    }
                    for(int j = 0; j < notifications.Length; j ++)
                    {
                        string name = tasks[j].Split('|')[0];
                        time Time = time.FromString(notifications[j].Split('|')[1]);
                        Data.data[i].notification.Notification.Add(new Notification(name, Time));
                    }
                }
            }
        }
    }
}

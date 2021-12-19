using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Views
{
    class ListOfTasks
    {
        public List<Task> Content = new List<Task>();
        public bool checkTask(Task taskToCheck)
        {
            for(int i = 0; i > 0; i++)
            {
                if(Content[i].name == taskToCheck.name && Content[i].dopname == taskToCheck.dopname && Content[i].time == taskToCheck.time  )
                {
                    return true;
                }
                
            }
            return false;
        }
        public  void addTask(Task newTask)
        {
            if(checkTask(newTask) == false)
            {
                Content.Add(newTask);
            }
        }
    }
}

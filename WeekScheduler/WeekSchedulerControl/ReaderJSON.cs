using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WeekSchedulerControl
{
    public class ReaderJSON
    {

        public static void addNewTask(Task task)
        {
            List<Task> data = getTasksList();
            data.Add(task);
            //_data.Add(task);

            string json = System.Text.Json.JsonSerializer.Serialize(data);
            //string json = JsonSerializer.Serialize(_data);
            File.WriteAllText(@"E:\csharp_projects\advanced_programming2\WeekScheduler\WeekSchedulerControl\TaskData.json", json);
        }

        public static void deleteTask(Task taskToRemove)
        {
            List<Task> data = getTasksList();
            List<Task> newData = new List<Task>();
            foreach(Task task in data){
                if(task.taskName == taskToRemove.taskName)
                {
                    continue;
                }
                newData.Add(task);
            }

            string json = System.Text.Json.JsonSerializer.Serialize(newData);
            //string json = JsonSerializer.Serialize(_data);
            File.WriteAllText(@"E:\csharp_projects\advanced_programming2\WeekScheduler\WeekSchedulerControl\TaskData.json", json);
        }

        public static List<Task> getTasksList()
        {
            List<Task> items;
            // TODO: REMBEMBER TO CHANGE IT"S LOCATION TO RELATIVE FROM ABSOLUTE!
            using (StreamReader r = new StreamReader(@"E:\csharp_projects\advanced_programming2\WeekScheduler\WeekSchedulerControl\TaskData.json"))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<Task>>(json);
            }
            return items;
        }

        public static Task getTaskByName(string taskName)
        {
            List<Task> tasks = getTasksList();
            foreach(Task task in tasks)
            {
                if(task.taskName == taskName)
                {
                    return task;
                }
            }
            return new Task("Non-existing task", "ERROR", "ERROR", "ERROR", "ERROR", "ERROR");
        }

        public static List<string> getTaskNames()
        {
            List<Task> tasks = getTasksList();
            List<string> names = new List<string>();

            foreach (Task task in tasks)
            {
                names.Add(task.taskName);
            }

            return names;
        }

        public string getColorForPriority(string priority)
        {
            if (priority == "")
            {
                return "";
            }
            return "";
        }
    }
}

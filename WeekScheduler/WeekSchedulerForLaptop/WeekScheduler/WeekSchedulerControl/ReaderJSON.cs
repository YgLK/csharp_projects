using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Diagnostics;

namespace WeekSchedulerControl
{
    public class ReaderJSON
    {
        public static string filePath = @"TaskData.json";


        public static void addNewTask(Task task)
        {
            Debug.Write(System.AppDomain.CurrentDomain.BaseDirectory);
            // add task to tasks list
            List<Task> data = getTasksList();
            data.Add(task);

            // serialize list of tasks to string
            string json = System.Text.Json.JsonSerializer.Serialize(data);
            // save serialized list of tasks in JSON format to file
            File.WriteAllText(filePath, json);
        }

        public static void deleteTask(Task taskToRemove)
        {
            List<Task> data = getTasksList();
            List<Task> newData = new List<Task>();
            // omit task to delete
            foreach(Task task in data){
                if(task.taskName == taskToRemove.taskName)
                {
                    continue;
                }
                newData.Add(task);
            }

            // save list of tasks without deleted task
            string json = System.Text.Json.JsonSerializer.Serialize(newData);
            File.WriteAllText(filePath, json);

        }

        public static List<Task> getTasksList()
        {
            // create json file if doesnt exist yet
            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    // write sample tasks data 
                    sw.WriteLine("[{\"taskName\":\"Zakupy\",\"taskDescription\":\"Zrobi\\u0107 zakupy\",\"date\":\"26/05/2022\",\"dateInfo\":{\"dateString\":\"26/05/2022\",\"date\":\"2022-05-26T00:00:00\",\"dayName\":\"Thursday\",\"weekNumber\":21,\"year\":2022},\"timeStart\":\"09:30\",\"timeEnd\":\"11:00\",\"priority\":\"Casual\"},{\"taskName\":\"Wyprowadzi\\u0107 psa\",\"taskDescription\":\"P\\u00F3j\\u015B\\u0107 z psem na spacer\",\"date\":\"24/05/2022\",\"dateInfo\":{\"dateString\":\"24/05/2022\",\"date\":\"2022-05-24T00:00:00\",\"dayName\":\"Tuesday\",\"weekNumber\":21,\"year\":2022},\"timeStart\":\"17:00\",\"timeEnd\":\"18:00\",\"priority\":\"Important\"},{\"taskName\":\"Zaj\\u0119cia muzyczne\",\"taskDescription\":\"Pami\\u0119ta\\u0107 o zeszytach! \",\"date\":\"26/05/2022\",\"dateInfo\":{\"dateString\":\"26/05/2022\",\"date\":\"2022-05-26T00:00:00\",\"dayName\":\"Thursday\",\"weekNumber\":21,\"year\":2022},\"timeStart\":\"13:30\",\"timeEnd\":\"16:00\",\"priority\":\"Casual\"},{\"taskName\":\"Kino\",\"taskDescription\":\"Wyj\\u015B\\u0107 do kina\",\"date\":\"28/05/2022\",\"dateInfo\":{\"dateString\":\"28/05/2022\",\"date\":\"2022-05-28T00:00:00\",\"dayName\":\"Saturday\",\"weekNumber\":21,\"year\":2022},\"timeStart\":\"14:00\",\"timeEnd\":\"17:00\",\"priority\":\"Non-relevant\"},{\"taskName\":\"Zrobi\\u0107 obiad\",\"taskDescription\":\"Wykorzysta\\u0107 warzywa z ogrodu.\",\"date\":\"23/05/2022\",\"dateInfo\":{\"dateString\":\"23/05/2022\",\"date\":\"2022-05-23T00:00:00\",\"dayName\":\"Monday\",\"weekNumber\":21,\"year\":2022},\"timeStart\":\"15:00\",\"timeEnd\":\"16:30\",\"priority\":\"Important\"},{\"taskName\":\"P\\u00F3j\\u015B\\u0107 pobiega\\u0107\",\"taskDescription\":\"W parku otworzono now\\u0105 \\u015Bcie\\u017Ck\\u0119!\",\"date\":\"24/05/2022\",\"dateInfo\":{\"dateString\":\"24/05/2022\",\"date\":\"2022-05-24T00:00:00\",\"dayName\":\"Tuesday\",\"weekNumber\":21,\"year\":2022},\"timeStart\":\"12:00\",\"timeEnd\":\"14:30\",\"priority\":\"Non-relevant\"},{\"taskName\":\"Koncert\",\"taskDescription\":\"Koncert juwenaliowy\",\"date\":\"20/05/2022\",\"dateInfo\":{\"dateString\":\"20/05/2022\",\"date\":\"2022-05-20T00:00:00\",\"dayName\":\"Friday\",\"weekNumber\":20,\"year\":2022},\"timeStart\":\"20:00\",\"timeEnd\":\"23:30\",\"priority\":\"Important\"},{\"taskName\":\"Wzi\\u0105\\u0107 prysznic\",\"taskDescription\":\"Zimny\",\"date\":\"18/05/2022\",\"dateInfo\":{\"dateString\":\"18/05/2022\",\"date\":\"2022-05-18T00:00:00\",\"dayName\":\"Wednesday\",\"weekNumber\":20,\"year\":2022},\"timeStart\":\"06:00\",\"timeEnd\":\"06:30\",\"priority\":\"Casual\"},{\"taskName\":\"Wyj\\u015B\\u0107 do biura\",\"taskDescription\":\"Pieszo\",\"date\":\"18/05/2022\",\"dateInfo\":{\"dateString\":\"18/05/2022\",\"date\":\"2022-05-18T00:00:00\",\"dayName\":\"Wednesday\",\"weekNumber\":20,\"year\":2022},\"timeStart\":\"06:30\",\"timeEnd\":\"12:30\",\"priority\":\"Important\"}]");
                } 
            }
            List<Task> items;
            // deserialize list of tasks from JSON file
            using (StreamReader r = new StreamReader(filePath))
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
                // return task if found
                if(task.taskName == taskName)
                {
                    return task;
                }
            }
            // if task isn't found
            return new Task("Non-existing task", "ERROR", "ERROR", "ERROR", "ERROR", "ERROR", "ERROR");
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

        public static string getColorOfPriority(string priority)
        {
            var priorityColors = getPriorityColours();
            if (priority == "")
            {
                return "";
            } else
            {
                return priorityColors[priority];
            }
        }

        public static Dictionary<string, string> getPriorityColours()
        {
            Dictionary<string, string> priorityColours =  new Dictionary<string, string>();

            var tasks = getTasksList();
            // add color for each priority occuring in the task dataset
            foreach(var task in tasks)
            {
                if (!priorityColours.ContainsKey(task.priority))
                {
                    priorityColours.Add(task.priority, task.priorityColour);
                }
            }
            return priorityColours;
        }

        public static void saveTasksToFilepath(string filePath)
        {
            Debug.Write(System.AppDomain.CurrentDomain.BaseDirectory);

            List<Task> data = getTasksList();

            string json = System.Text.Json.JsonSerializer.Serialize(data);

            // create json file if doesnt exist yet
            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    // write sample tasks data 
                    sw.Write(json);
                }
            } else
            {
                File.WriteAllText(filePath, json);
            }
        }
    }
}

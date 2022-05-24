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
        //public static string filePath = @"E:\csharp_projects\advanced_programming2\WeekScheduler\WeekSchedulerControl\TaskData.json";
        public static string filePath = @"TaskData.json";


        public static void addNewTask(Task task)
        {
            Debug.Write(System.AppDomain.CurrentDomain.BaseDirectory);

            List<Task> data = getTasksList();
            data.Add(task);
            //_data.Add(task);

            string json = System.Text.Json.JsonSerializer.Serialize(data);
            //File.WriteAllText(@"E:\csharp_projects\advanced_programming2\WeekScheduler\WeekSchedulerControl\TaskData.json", json);
            File.WriteAllText(filePath, json);
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
            //File.WriteAllText(@"E:\csharp_projects\advanced_programming2\WeekScheduler\WeekSchedulerControl\TaskData.json", json);
            File.WriteAllText(filePath, json);

        }

        public static List<Task> getTasksList()
        {
            // create json file if doesnt exist yet
            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine("[{\"taskName\":\"Zamknij okno\",\"taskDescription\":\"Przyci\\u015Bnij r\\u0119k\\u0105 cz\\u0119\\u015B\\u0107 okna i go zamknij\",\"date\":\"22/5/2022\",\"dateInfo\":{\"dateString\":null,\"date\":\"0001-01-01T00:00:00\",\"dayName\":\"Monday\",\"weekNumber\":1,\"year\":1},\"timeStart\":\"06:30\",\"timeEnd\":\"07:00\",\"priority\":\"Non-relevant\"},{\"taskName\":\"Check\",\"taskDescription\":\"sprawdzam\",\"date\":\"22/05/2022\",\"dateInfo\":{\"dateString\":\"22/05/2022\",\"date\":\"2022-05-22T00:00:00\",\"dayName\":\"Sunday\",\"weekNumber\":20,\"year\":2022},\"timeStart\":\"03:00\",\"timeEnd\":\"03:30\",\"priority\":\"Important\"},{\"taskName\":\"Sniadanie\",\"taskDescription\":\"Zjesc sniadanie\",\"date\":\"26/05/2022\",\"dateInfo\":{\"dateString\":\"26/05/2022\",\"date\":\"2022-05-26T00:00:00\",\"dayName\":\"Thursday\",\"weekNumber\":21,\"year\":2022},\"timeStart\":\"05:30\",\"timeEnd\":\"06:30\",\"priority\":\"Casual\"},{\"taskName\":\"Karol\",\"taskDescription\":\"ka\",\"date\":\"25/05/2022\",\"dateInfo\":{\"dateString\":\"25/05/2022\",\"date\":\"2022-05-25T00:00:00\",\"dayName\":\"Wednesday\",\"weekNumber\":21,\"year\":2022},\"timeStart\":\"05:00\",\"timeEnd\":\"11:00\",\"priority\":\"Important\"},{\"taskName\":\"Karol\",\"taskDescription\":\"d\",\"date\":\"27/05/2022\",\"dateInfo\":{\"dateString\":\"27/05/2022\",\"date\":\"2022-05-27T00:00:00\",\"dayName\":\"Friday\",\"weekNumber\":21,\"year\":2022},\"timeStart\":\"02:30\",\"timeEnd\":\"09:00\",\"priority\":\"Non-relevant\"},{\"taskName\":\"test\",\"taskDescription\":\"test\",\"date\":\"23/05/2022\",\"dateInfo\":{\"dateString\":\"23/05/2022\",\"date\":\"2022-05-23T00:00:00\",\"dayName\":\"Monday\",\"weekNumber\":21,\"year\":2022},\"timeStart\":\"02:00\",\"timeEnd\":\"06:00\",\"priority\":\"Important\"},{\"taskName\":\"test\",\"taskDescription\":\"test\",\"date\":\"22/05/2022\",\"dateInfo\":{\"dateString\":\"22/05/2022\",\"date\":\"2022-05-22T00:00:00\",\"dayName\":\"Sunday\",\"weekNumber\":20,\"year\":2022},\"timeStart\":\"02:00\",\"timeEnd\":\"04:00\",\"priority\":\"Important\"}]");
                } 
            }
            List<Task> items;
            // TODO: REMBEMBER TO CHANGE IT"S LOCATION TO RELATIVE FROM ABSOLUTE!
            //using (StreamReader r = new StreamReader(@"E:\csharp_projects\advanced_programming2\WeekScheduler\WeekSchedulerControl\TaskData.json"))
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

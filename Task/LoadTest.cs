//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Task
//{
//    internal class LoadTest
//    {
//        static async Tasks Main(string[] args)
//        {
//            int numberOfUsers = 100; // Количество пользователей, имитирующих нагрузку
//            Tasks[] tasks = new Tasks[numberOfUsers];

//            for (int i = 0; i < numberOfUsers; i++)
//            {
//                tasks[i] = SimulateUserLoad(i);
//            }

//            await Tasks.WhenAll(tasks);
//        }

//        static async Tasks SimulateUserLoad(int userId)
//        {
//            using (HttpClient client = new HttpClient())
//            {
//                // Пример выполнения POST-запроса для добавления задачи
//                var content = new FormUrlEncodedContent(new[]
//                {
//                new KeyValuePair<string, string>("title", "Test Task " + userId),
//                new KeyValuePair<string, string>("description", "This is a test task."),
//                new KeyValuePair<string, string>("priority", "средний"),
//                new KeyValuePair<string, string>("status", "в ожидании")
//            });

//                HttpResponseMessage response = await client.PostAsync("http://your-api-url/addtask", content);
//                Console.WriteLine($"User {userId} received response: {response.StatusCode}");
//            }
//        }
//    }
//}

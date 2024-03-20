using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List
{
    class Program
    {
        class Task
        {
            public string tasktext { get; set; }
            public string taskstatus { get; set; }
        }
        static List<Task> tasks = new List<Task>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Yapılacaklar listene hoşgeldin, lütfen yapmak istediğiniz işlemi seçiniz.");
                Console.WriteLine("1 - Görev Ekle");
                Console.WriteLine("2 - Görev Durumunu Düzenle");
                Console.WriteLine("3 - Görev Kaldır");
                Console.WriteLine("4 - Listeyi Görüntüle");
                Console.WriteLine("Seçiminizi yapın... (1/2/3/4)");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        AddTask();
                        break;
                    case "2":
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        EditTask();
                        break;
                    case "3":
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        DeleteTask();
                        break;
                    case "4":
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        ShowTasks();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Geçersiz seçim, tekrar giriniz.");
                        break;
                }
            }
        }

        static void AddTask()
        {
            Console.WriteLine("Yapılacak görevi giriniz.");
            string tasktext = Console.ReadLine();
            string taskstatus = "X";

            Task newTask = new Task { tasktext = tasktext, taskstatus = taskstatus };
            tasks.Add(newTask);
            Console.WriteLine("Görev başarıyla eklendi.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        static void ShowTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("Listenizde bir görev bulunmuyor.");
            }
            else
            {
                Console.WriteLine("Yapılacaklar Listesi:");
                foreach (var Task in tasks)
                {
                    Console.WriteLine($"{Task.tasktext}, Durum: {Task.taskstatus}");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        static void DeleteTask()
        {
            ShowTasks();

            if (tasks.Count == 0)
            {
                return;
            }

            Console.Write("Silmek istediğiniz görevin sıra numarasını girin.");
            int index = int.Parse(Console.ReadLine());

            if (index >= 1 && index <= tasks.Count)
            {
                tasks.RemoveAt(index - 1);
                Console.WriteLine("Görev başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Geçersiz sıra numarası, lütfen tekrar deneyiniz.");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        static void EditTask()
        {
            ShowTasks();

            if (tasks.Count == 0)
            {
                return;
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Lütfen durumunu değiştirmek istediğiniz görevin sıra numarasını girin.");
            int index = int.Parse(Console.ReadLine());

            if (index >= 1 && index <= tasks.Count)
            {
                string alreadyStatus = tasks[index - 1].taskstatus;
                if (alreadyStatus == "X")
                {
                    tasks[index - 1].taskstatus = "+";
                    Console.WriteLine("Görev durumu güncellendi.");
                }
                else
                {
                    tasks[index - 1].taskstatus = "X";
                    Console.WriteLine("Görev durumu güncellendi.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz bir değer verdiniz. Lütfen tekrar deneyin.");
                return;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}


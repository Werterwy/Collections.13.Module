using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections._13.Module
{

    internal class Program
    {
        static Queue<Client> clientQueue = new Queue<Client>();

        /// <summary>
        /// 1. Добавить клиента в очередь
        /// </summary>
        static void AddClientToQueue()
        {
            Console.Write("Введите ИИН: ");
            string iin = Console.ReadLine();

            Console.Write("Выберите тип услуги (1 - кредитование, 2 - открытие вклада, 3 - консультация): ");
            int serviceType = int.Parse(Console.ReadLine());

            Client client = new Client(iin, (ServiceType)serviceType);
            clientQueue.Enqueue(client);

            Console.WriteLine("Вы добавлены в очередь.");
            DisplayQueueStatus();
        }

        /// <summary>
        /// 2. Обслужить следующего клиента
        /// </summary>
        static void ServeNextClient()
        {
            if (clientQueue.Count == 0)
            {
                Console.WriteLine("Очередь пуста.");
            }
            else
            {
                Client servedClient = clientQueue.Dequeue();
                Console.WriteLine($"Клиент {servedClient.IIN} обслужен.");
                if (clientQueue.Count == 0)
                {
                    Console.WriteLine("Очередь пуста.");
                }
                else
                {
                    DisplayQueueStatus();
                }
            }
        }

        /// <summary>
        /// показывает состояние очереди:
        /// </summary>
        static void DisplayQueueStatus()
        {
            Console.WriteLine("Текущее состояние очереди:");
            int counter = 1;
            foreach (var client in clientQueue)
            {
                Console.WriteLine($"{counter++}. ИИН: {client.IIN}, Тип услуги: {client.ServiceType}");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Добавить клиента в очередь");
                Console.WriteLine("2. Обслужить следующего клиента");
                Console.WriteLine("3. Выйти");
                Console.Write("Выберите действие: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddClientToQueue();
                        break;
                    case "2":
                        ServeNextClient();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор.");
                        break;
                }

                Console.WriteLine();
            }

        }
    }
}

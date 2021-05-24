using System;
using System.Collections.Generic;
using System.Threading;

namespace Algoritms
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем и заполняем колекцию юзеров
            var users = new List<User>();
            users.Add(new User("Петя", "Петя", false));
            users.Add(new User("Коля", "Коля", true));

            foreach (var user in users)
            {
                Console.WriteLine("Привет, {0}", user.Name);
                if (!user.IsPremium)
                {
                    ShowAds();
                }
            }

            Console.ReadKey();
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}

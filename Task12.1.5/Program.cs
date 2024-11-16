using System.Security.Cryptography.X509Certificates;

namespace Task12._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User() { Login ="", Name="", IsPremium=false };
            
            bool isFilmEnd = false;
            int countFilmMinute = 60;

            Console.WriteLine("Добро пожаловать на сайт Filmes");

            while (!isFilmEnd)
            {
                Console.WriteLine("Идет просмотр фильма"); // 20 минут
                countFilmMinute -= 20;

                if (countFilmMinute <= 0) 
                {
                    break;
                }

                if (user.IsPremium) {
                    continue;
                }

                ShowAds(); // показ рекламы

                Console.WriteLine("Хотите ли купить премиум-подписку?");
                string answer = Console.ReadLine();

                if (answer == "да") {
                    user = User.Registration();
                }
            }

            Console.WriteLine("Фильм закончился!");
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

    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public static User Registration()
        {
            string login;
            string name;

            Console.WriteLine("Введите логин");
            login = Console.ReadLine();
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();

            return new User { Login = login, Name = name, IsPremium = true };
        }
    }
}
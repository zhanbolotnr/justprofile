using System;

namespace Profile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Фамилия: ");
            string lastname = Console.ReadLine();

            Console.WriteLine("Имя: ");
            string firstname = Console.ReadLine();

            Console.WriteLine("Возвраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Вес: ");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Рост: ");// можно и в метрах спросить тогда
            double height = double.Parse(Console.ReadLine());

            double bodyMassIndex = weight / (height / 100 * height / 100); // Тогда делить на 100 не надо

            string profile =
                $"Your profile: {Environment.NewLine}"
               + $"Полное имя : {lastname} {firstname}{Environment.NewLine}"
               + $"Возвраст: {age}{Environment.NewLine}"
               + $"Вес: {weight}{Environment.NewLine}"
               + $"Рост: {height}{Environment.NewLine}"
               + $"Индекс тело массы: {bodyMassIndex}";

            Console.WriteLine(profile);
        }
    }
}

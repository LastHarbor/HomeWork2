using System;

namespace HomeWork2
{
    internal class Program
    {
        static void Main()

        {
            #region Задание 1 
            
            //Работа с переменными и форматированный вывод.

            Console.WriteLine("Введите имя: ");   string Name = Console.ReadLine();

            Console.WriteLine("Введите возраст: ");   int Age = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Введите Email: ");   string Email = Console.ReadLine();
           
            Console.WriteLine("Балл по программированию: ");   float ProgScore = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Балл по математике: ");   float MathScore = float.Parse(Console.ReadLine());

            Console.WriteLine("Балл по физике: ");   float PhysScore = float.Parse(Console.ReadLine());
            Console.Clear();

            
            string Pattern = "Имя - {0}\nВозраст - {1}\nEmail - {2}\nПрограммирование - {3}\tМатематика - {4}\tФизика - {5} ";
            Console.WriteLine(Pattern,Name,Age,Email,ProgScore,MathScore,PhysScore);
            Console.ReadKey(); Console.Clear();

            #endregion

            #region Задание 2

            float AllScore = ProgScore + MathScore + PhysScore;
            
            float midScore = (PhysScore + MathScore + PhysScore) / 3;

            Console.WriteLine($"Сумма баллов - {AllScore}\nСредний балл - {midScore}");

            #endregion
        }
    }
}

/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
// Получение числа
// int GetNumber(string message)
// {
//     bool isCorrect = false;
//     int result = 0;

//     while (!isCorrect)
//     {
//         Console.WriteLine(message);
//         if (int.TryParse(Console.ReadLine(), out result))
//         {
//             isCorrect = true;
//         }
//         else
//         {
//             Console.WriteLine("Ввели не число");
//         }
//     }
//     return result;
// }

// int GetSumm(int numberA, int numberB)
// {
//     int summ = 1;
//     for (int i = 1; i <= numberB; i++)
//     {
//         summ *= numberA;
//     }
//     return summ;
// }

// int numberA = GetNumber("Введите число A");
// int numberB = GetNumber("Введите число B");

// int summ = GetSumm(numberA, numberB);

// Console.WriteLine($"Натуральная степень {numberA} = {summ}");

// ...................................................................................
/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
// Console.WriteLine("введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int count = 0;

// while (a > 0)
// {
//     count += a % 10;
//     a /= 10;
// }
// Console.WriteLine($"Сумма цифр в числе = {count}");

/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int[] array = new int[8];
Random rnd = new Random();

for (long i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0, 20);
    Console.Write($"{array[i]}, ");
}

Console.WriteLine();

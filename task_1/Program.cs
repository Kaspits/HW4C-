// напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.

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

// int GetSumm(int number)
// {
//     int summ = 0;
//     for (int i = 1; i <= number; i++)
//     {
//         summ += i;
//     }
//     return summ;
// }

// int number = GetNumber("Введите число");
// int summ = GetSumm(number);

// Console.WriteLine($"Сумма чисел от 1 до {number} = {summ}");


// ...........................................................................
// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int count = 0;

// while (a > 0)
// {
//     a = a / 10;
//     count++;
// }

// Console.WriteLine($"Количество цифр в числе = {count}");

// .........................................................................
// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Получение числа
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}

int num = GetNumber("Введите число:");
int result = 1;

for (int i = 1; i <= num; i++)
{
    result *= i;
}

Console.WriteLine($"Производства от 1 до {num} равно {result}");

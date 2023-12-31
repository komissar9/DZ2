﻿// 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.Write("Введите трёхзначное число: ");
int numberUser = Convert.ToInt32(Console.ReadLine());
if (numberUser >=100 && numberUser <1000)
{
    int secondDigital = (numberUser % 100 - numberUser % 10) / 10;
    Console.WriteLine($"В числе {numberUser} -> {secondDigital} вторая цифра");
}
else
    Console.Write($"Число {numberUser} не трёхзначное");

// 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. До 10 символов
Console.Write("Введите число, содержащее до 10 символов: ");
string? numberUser = Console.ReadLine();
int numberint;
bool number = int.TryParse(numberUser, out numberint);
if (number)
{
    if (numberUser.Length <= 2)
    {
        Console.WriteLine($"В числе {numberUser} нет третьей цифры");
    }
    if (numberUser.Length > 2)
    {
        Console.WriteLine($"В числе {numberUser} третья цифра {numberUser[2]}");
    }
} 
else
{
    Console.WriteLine("Требуется ввести число");
}

// 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.Write("Введите число дня недели, чтобы проверить выходной это или нет: ");
int numberDay = Convert.ToInt32(Console.ReadLine());
if (numberDay <= 5)
{
    Console.WriteLine($"Нет, {numberDay} день недели является рабочим днём");
}
if (numberDay > 5 && numberDay <=7)
{
    Console.WriteLine($"Да, {numberDay} день недели является выходным днём");
}
if (numberDay > 7)
{
    Console.WriteLine("В неделе только 7 дней, пожалуйста, придерживайтесь этого диапозона");
}

// Доп. Назовём число «интересным» если его произведение цифр делится на их сумму БЕЗ остатка. Напишите программу, 
// которая заполняет массив на 10 «интересных» случайных целых чисел от 10 до 1000(999 - последнее). (каждый эл-т массива – сгенерирован случайно)
int[] unusialNumbers = new int[10];
Random randNumber = new Random();
int i = 0;
while ( i < unusialNumbers.Length)
      {
          unusialNumbers[i] = randNumber.Next(10,1000);
          int firstDigital =  unusialNumbers[i] / 100;
          int secondDigital = (unusialNumbers[i] % 100 - unusialNumbers[i] % 10) / 10;
          int thirdDigital = (unusialNumbers[i] % 10);
          int unusialNumber = (firstDigital * secondDigital * thirdDigital) % (firstDigital + secondDigital + thirdDigital);
          if (unusialNumber==0)
          {
            Console.WriteLine(unusialNumbers[i]);
            i++;
          }
          else
          {
            unusialNumbers[i] = randNumber.Next(10,1000);
          }
      }
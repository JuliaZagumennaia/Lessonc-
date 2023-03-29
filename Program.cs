/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

int max =0;
int min =0;

Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());

if(firstNumber > secondNumber)
{
    max = firstNumber;
    min = secondNumber;
}
else
{
    max = secondNumber;
    min = firstNumber;
}
Console.WriteLine("a = " + firstNumber  + "; b = " + secondNumber  + " -> " + "max =" + max); */

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

/*int max = 0;

Console.Write("Введите первое число: ");
int FirstNumber = int.Parse (Console.ReadLine());

Console.Write("Введите второе число: ");
int SecondNumber = int.Parse (Console.ReadLine());

Console.Write("Введите третье число: ");
int ThirdNumber = int.Parse (Console.ReadLine());

if(FirstNumber > max)
{
    max = FirstNumber;
}
if(SecondNumber > max)
{
    max = SecondNumber;
}
if(ThirdNumber > max)
{
    max = ThirdNumber;
}

Console.WriteLine("a = " + FirstNumber + "; b = " + SecondNumber + "; c = " + ThirdNumber + " -> " + max);*/

/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

/*Console.Write("Введите число: ");

int number = int.Parse(Console.ReadLine());

int N = number % 2;

if (N == 0)
{
    Console.WriteLine(number + "; -> ДА!");
}
else 
{
    Console.WriteLine(number + "; -> НЕТ!");
}*/


Console.Clear();
/* Задача 1: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.
*/

void PrintNumber(int a, int b)
{
    Console.Write($"{a}, ");
    if (a == b || a < 0 || b < 0)
    {
        return;
    }
    a += 1;
    PrintNumber(a, b);

}
Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine()!);
PrintNumber(firstNumber, secondNumber);


/* Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы.
*/
void PrintMassiv(int[] array, int n = 1)
{
    if (n > array.Length)
    {
        return;
    }
    Console.Write($"{array[array.Length - n]} ");
    PrintMassiv(array, n + 1);

}
int[] numbers = { 5, 6, 7, 8, 9, 10 };
PrintMassiv(numbers);

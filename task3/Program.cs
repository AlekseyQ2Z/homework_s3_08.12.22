// Напишите программу, которая принимает на вход число 
// (N) и помещает в массив таблицу кубов чисел от 1 до N. 
// Полученный массив вывести на экран.
// Вывод массива вынести в отдельную функцию.

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count-1)
    {
        Console.Write(col[position] + ", ");
        position++;
    }
    Console.Write(col[position]);
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
for (int i = 1; i <= number; i++)
{
    int temp = i * i * i;
    array[i-1] = temp;
}
PrintArray(array);
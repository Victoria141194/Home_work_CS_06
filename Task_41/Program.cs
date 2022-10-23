/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int size = GetNumberFromUser("Введите количество элементов массива: ", "Ошибка ввода!");
int[] array = FillArray(size);
int count = GetPositiveCount(array);
Console.Write(String.Join(" ", array));
Console.WriteLine($" -> {count}");


//...................................МЕТОДЫ...........................................
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}


int[] FillArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
    }
    return array;
}


int GetPositiveCount(int[] array)
{
    count = 0;
    foreach (int el in array)
    {
        if (el > 0) count++;
    }
    return count;
}
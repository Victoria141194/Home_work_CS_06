/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

int b1 = GetNumberFromUser("Введите целое значение b1: ", "Ошибка ввода!");
int k1 = GetNumberFromUser("Введите целое значение k1: ", "Ошибка ввода!");
int b2 = GetNumberFromUser("Введите целое значение b2: ", "Ошибка ввода!");
int k2 = GetNumberFromUser("Введите целое значение k2: ", "Ошибка ввода!");
double x = GetXCoord(b1, k1, b2, k2);
double y = GetYCoord(k1, x, b1);
Console.Write($"Точка пересечения двух прямых: {x}; {y}");



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


double GetXCoord(int b1, int k1, int b2, int k2)
{
    x = (double)(b2 - b1) / (k1 - k2);
    return x;
}


double GetYCoord(int k1, double x, int b1)
{
    y = (double) k1 * x + b1;
    return y;
}
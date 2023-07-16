// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Prompt(string message)                // Запрос ввода числа пользователем
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

double RaiseToDegree(double num, double deg)  // Возводим в степень
{
    return Math.Pow(num, deg);
}

double number = Prompt("Введите число: ");
double degree = Prompt("Введите степень числа: ");

Console.WriteLine($"{number}, {degree} -> {RaiseToDegree(number, degree)}");

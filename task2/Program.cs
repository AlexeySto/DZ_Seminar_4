// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumber(string mes)              //Ввод числа пользователем
{
    Console.Write(mes);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSumReg(int num)
{
    int sumReg = 0;
    for(int temp = num; temp != 0; temp /= 10) sumReg += temp % 10;
    return sumReg;
}

int number = GetNumber("Введите целое число: ");

Console.WriteLine($"{number} -> {GetSumReg(Math.Abs(number))}");

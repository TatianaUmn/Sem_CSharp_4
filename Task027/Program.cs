// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

int SumNumber(int a)
{
    int result = 0;
    while (a > 0)
    {
        result += a % 10;
        a = a / 10;
    }
    return result;
}
Console.WriteLine(SumNumber(452));
Console.WriteLine(SumNumber(82));
Console.WriteLine(SumNumber(9012));

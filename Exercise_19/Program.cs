//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText[0] == anyNumberText[4] && anyNumberText[1] == anyNumberText[3])
{
    Console.WriteLine($"{anyNumber} -> число является полиндромом");
}
else
{
    Console.WriteLine($"{anyNumber} -> число не является полиндромом");
}
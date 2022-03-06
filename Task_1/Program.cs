// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
M: Console.Write("Введите 5-ти значное число: ");
string? a = Convert.ToString(Console.ReadLine());
if (a.Length != 5)
{
Console.WriteLine($"Число {a} содержит {a.Length} знаков, а нужно 5, попробуйте ввести заного");
goto M;
}
char[] array = a.ToCharArray();
Array.Reverse(array);
string b = new string(array);
if (a == b)
{
    Console.WriteLine($"Число {a} является полиндромом");
}
else
{
    Console.WriteLine($"Число {a} не является полиндромом");
}
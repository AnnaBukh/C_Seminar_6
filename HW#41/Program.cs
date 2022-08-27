// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через пробел: ");

string[] str = Console.ReadLine().Split();

void KollDigit()
{
int n = 0;
int kol = 0;
foreach (var word in str)
{
     int digit = int.Parse(word);
     //Console.Write($"{digit} ");
     n ++;
     if (digit > 0) kol++;
}
Console.Write($"Количество чисел больше нуля: {kol}");
}
KollDigit();
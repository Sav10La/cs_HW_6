// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

Console.Clear();

void Zadacha41()
{
    Console.Write("Введите количество чисел для ввода: ");
    int count = Convert.ToInt32(Console.ReadLine());
    EnterNumbers(count);
}

void EnterNumbers(int count)
{
    int result = 0;
    for (int i = 0; i < count; i++)
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            result = result + 1;
        }
    }
    Console.WriteLine(result);
}

Zadacha41();
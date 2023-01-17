// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

// это функция, которую можно вызвать. ввод числа с консоли
int InputInt(string message)  // Параметр - подсказка пользователю
{
    Console.Write(message + " > ");                   // Вывод сообщения пользователь
    string inputValue = Console.ReadLine();           // Ввод строки пользователем
    int result = Convert.ToInt32(inputValue);         // Преобразование в целое введенной строки
    return result;                                    // возврат результата
}
// проверка на 3-х значность
bool ValidateNumberRank3(int number)
{
    if (number > 99 && number < 1000)                 // проверка на трехзначность
    {
        return true;
    }
    System.Console.WriteLine("Число не трехзначное")  // пользователь ввел не трехзначное число
    return false;
}

int number = InputInt ("Введите трехзначне число");   // Вывод функции ввода
if (ValidateNumberRank3(number))
{
    int lastRank = number %10;
    System.Console.WriteLine($"Последняя цифра числа {number} ")
}
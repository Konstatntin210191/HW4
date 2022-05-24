// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetNumber(string msg)
{
    while(true)
    {
    Console.WriteLine(msg);
    string valueFromConsole = Console.ReadLine();
    

        if(int.TryParse(valueFromConsole, out int number))
        {
                return number;     
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число.");
        }
    }
}  

int GetSummOfDigit(int number)
{
    int summ = 0;
    while (number > 0)
    {
        summ = summ + number % 10;
        number = number /10 ;
    }
    return summ;
}


string message = "Введите число: ";
int number = GetNumber(message);


int summ = GetSummOfDigit(number);

Console.WriteLine($"Сумма цифр заданного числа: {summ}");
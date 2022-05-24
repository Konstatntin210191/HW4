// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

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

int GetDegree(int a, int b)
{
    int degree = Convert.ToInt32(Math.Pow(a, b));
    return degree;
}

string messageA = "Введите число, которое хотите возвести в степень: ";
string messageB = "Введите степень числа: ";

int a = GetNumber(messageA);
int b = GetNumber(messageB);

int quarter = GetDegree(a, b);

Console.WriteLine($"Число {a} в степени {b} равно: {quarter}");


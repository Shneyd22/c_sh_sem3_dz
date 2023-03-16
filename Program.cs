// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

void CheckPalNum (int number, int number1, int number2, int number4, int number5)
{
    if (number > -100000 & number < 100000 & number < -9999 & number > 9999)
    {
        number1 = number / 10000;
        number2 = (number / 1000) % 10;
        number4 = (number / 10) % 10;
        number5 = number % 10;
        if (number1 == number5 & number2 == number4)
        {
            Console.WriteLine ("Это число - палиндром");
        }
        else
        {
            Console.WriteLine ("Это число - НЕ палиндром");
        }
    }
    else
    {
        Console.WriteLine ("Введите ПЯТИЗНАЧНОЕ число!!!");
    }
}




try
{
    Console.WriteLine ("Введите пятизначное число");
    int number = Convert.ToInt32(Console.ReadLine());
    int number1 = 0;
    int number2 = 0;
    int number4 = 0;
    int number5 = 0;
    CheckPalNum (number, number1, number2, number4, number5);
}
catch
{
    Console.WriteLine ("Введено неверное значение");
}
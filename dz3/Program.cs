// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// try
// {
    Console.WriteLine("Введите число");
    int N = Convert.ToInt32(Console.ReadLine());
    NumCubTable (N);      //Почему-то с проверкой функция не работает
// }
// catch
// {
//     Console.WriteLine("Введено некорректное значение");
// }





void NumCubTable (int i)
{
    for (i = 1; i < N; i++)
    {
        int cub = i * i * i;
        Console.Write($"{cub}, ");
    }
    if (i == N) Console.WriteLine(N * N * N);
}
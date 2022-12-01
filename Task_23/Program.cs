// Задача 23 Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// Console.Clear();
// Console.WriteLine("Напишите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int index = 1;
// while (index < number)
// {
//     double cube = Math.Pow(index, 3);
//     Console.Write(cube + ",");
//     index++;
// }
// Console.Write(Math.Pow(number, 3));

int Cube (string str)
{
    Console.Write(str);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

void Result (int n)
{
    int index = 1;
    while(index <= n - 1)
    {
        Console.Write(index*index*index + ", ");
        index++;
    }
    Console.Write(index*index*index);
}

int number = Cube("Введите число ");
Result (number);
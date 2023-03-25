// Урок 9. Рекурсия


//посчитаем сумму числе от 1 до N, которое вводится пользователем

// Console.WriteLine("Введите число N");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"сумма чисел равна {Summa(num)}");
// Console.WriteLine($" рекурсией сумма чисел равна {SummaRec(num)}");



// int Summa(int num)
// {
//     int sum = 0;
//     while (true)
//         {
//             if (num==0)
//                 break;
//             sum=sum+num;
//             num--;
//         }
//     return sum;
// }

// //SummaRec(4)
// // 4 + ( 3 + ( 2 + (1 + 0)))

// int SummaRec(int num)
// {
//     if (num==0) return 0; // строчки 13 и 14
//     return num + SummaRec(num-1);  //строчки 15 и 16
// }


// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"



// Console.WriteLine(" ВВедите число N ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($" рекурсией все натуральные числа N {NaturalChisla(num)} ");

// string NaturalChisla(int num)
// {
//     if (num==0) return "";
//     return NaturalChisla(num-1) + " " + num;
// }



// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


// Console.WriteLine(" ВВедите число M ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" ВВедите число N ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($" рекурсией все натуральные числа в промежутке от M до N {} ");

// string NaturalChisla(int num1, int num2)
// {
//     if (num2==0) return "";
//     return NaturalChisla(num-1) + " " + num;
// }


// Варинат № 2

// void printRange(int N, int M)
// {
//     if (N > M)
//     {
//         return;
//     }
//     Console.Write($"{N}, ");
//     printRange(N + 1, M);
// }

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());


// printRange(N, M);


// Варинат №3

// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// void Natural(int m, int n)
// {
// if (m > n)
// return;

// Console.Write($"{m}, ");

// Natural(m+1,n);

// }
// Natural(m,n);


// Задача 67: Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма цифр числа N: {SumRec(N)}");

// int Summa(int N)
// {
//     int M = 0;
//     while(true)
//     {
//         M+=N%10;
//         N=N/10;
//         if (N==0) break;
//     }
//     return N%10 + SumRec(N/10);
// }

// // Вариант №2

// int printRange(int N)
// {
//     int sum = 0;
//     int remains = 0;
//     if (N == 0)
//     {
//         return sum;
//     }
//     remains = N % 10;
//     sum += remains;
//     return sum + printRange(N / 10);
// }

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// printRange(N);

// int result = printRange(N);
// Console.WriteLine(result);


// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


// Console.WriteLine("Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B: ");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Число A в степени B: {Stepen(A,B)}");

// int Stepen(int A, int B)
// {
//     if(B == 0) return 1;
//     return A*Stepen(A,B-1);
// }


// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");

// int functionAkkerman = Ack(m, n);

// Console.Write($"Функция Аккермана = {functionAkkerman} ");

// int Ack(int m, int n)
// {
//   if (m == 0) return n + 1;
//   else if (n == 0) return Ack(m - 1, 1);
//   else return Ack(m - 1, Ack(m, n - 1));
// }

// int InputNumbers(string input) 
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }



{
    // Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
    // N = 5. -> "5, 4, 3, 2, 1"
    // N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"

    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int count = 1;
    NaturalToLow(number, count);


    void NaturalToLow(int n, int count)
    {
        if (count > n)
        {
            return;
        }
        else
        {
            NaturalToLow(n, count + 1);
            Console.Write(count + " ");
        }
    }
}


void Task66()
{
    // // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    // // M = 1; N = 15 -> 120
    // // M = 4; N = 8. -> 30

    Console.Write("Введите число M: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());

    SumFromMToN(m, n);

    // вызов функции "сумма чисел от M до N"
    void SumFromMToN(int m, int n)
    {
        Console.Write(SumMN(m - 1, n));
    }

    // функция сумма чисел от M до N
    int SumMN(int m, int n)
    {
        int res = m;
        if (m == n)
            return 0;
        else
        {
            m++;
            res = m + SumMN(m, n);
            return res;
        }
    }
}


void Task68()
{
    // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    // m = 2, n = 3 -> A(m,n) = 9
    // m = 3, n = 2 -> A(m,n) = 29

    Console.Write("Введите число M: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());

    AkkermanFunction(m, n);


    // вызов функции Аккермана
    void AkkermanFunction(int m, int n)
    {
        Console.Write(Akkerman(m, n));
    }

    // функция Аккермана
    int Akkerman(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0 && m > 0)
        {
            return Akkerman(m - 1, 1);
        }
        else
        {
            return (Akkerman(m - 1, Akkerman(m, n - 1)));
        }
    }
}
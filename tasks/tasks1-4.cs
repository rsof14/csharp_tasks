//1.1
Console.WriteLine("Введите имя:");
string name = Console.ReadLine();
Console.WriteLine("Введите фамилию:");
string last_name = Console.ReadLine();
Console.WriteLine("{0} {1}", name, last_name);
//1.2
Console.WriteLine("Введите год рождения:");
int year = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(2023 - year);
//1.3
Console.WriteLine("Введите первое число:");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(first + second);
//1.4
Console.WriteLine("Введите число:");
int numb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("{0}, {1}, {2}", numb - 1, numb, numb + 1);
//1.5
Console.WriteLine("Введите первое число:");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма: {0}, Разность: {1}", first + second, first - second);
//2.1
Console.WriteLine("Введите число:");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb % 3 == 0)
{
    Console.WriteLine("Число {0} делится на 3", numb);
}
else
{
    Console.WriteLine("Число {0} не делится на 3", numb);
}
//2.2
Console.WriteLine("Введите число:");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb % 5 == 2 && numb % 7 == 1)
{
    Console.WriteLine("Число {0} делится на 5 с остатком 2 и на 7 с остатком 1", numb);
}
else
{
    Console.WriteLine("Число {0} не делится на 5 с остатком 2 и на 7 с остатком 1", numb);
}
//2.3
Console.WriteLine("Введите число:");
int numb = Convert.ToInt32(Console.ReadLine());
int numb_4 = numb / 1000 % 10;
Console.WriteLine(numb_4);
//2.4
Console.WriteLine("Введите число:");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb >= 5 && numb <= 10)
{
    Console.WriteLine("Число {0} попадает в диапазон от 5 до 10", numb);
}
else
{
    Console.WriteLine("Число {0} не попадает в диапазон от 5 до 10", numb);
}
//3.1
try
{
    Console.WriteLine("Введите число:");
    int numb = Convert.ToInt32(Console.ReadLine());
    if (numb % 3 == 0 && numb % 7 == 0)
    {
        Console.WriteLine("Число {0} делится на 3 и на 7", numb);
    }
    else
    {
        Console.WriteLine("Число {0} не делится на 3 и на 7", numb);
    }
}
catch
{
    Console.WriteLine("Необходимо ввести целое число");
};
//3.2
try
{
    Console.WriteLine("Введите первое число:");
    int first = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int second = Convert.ToInt32(Console.ReadLine());
    if (first == second)
    {
        Console.WriteLine("Числа равны");
    }
    else if (first > second)
    {
        Console.WriteLine("Первое число больше второго");
    }
    else
    {
        Console.WriteLine("Второе число больше первого");
    }
}
catch
{
    Console.WriteLine("Необходимо ввести целые числа");
};
//3.3
string[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
bool flag = true;
int numb = 0;
while (flag)
{
    Console.WriteLine("Введите число от 1 до 7");
    try
    {
        numb = Convert.ToInt32(Console.ReadLine());
        if (numb >= 1 && numb <= 7)
        {
            flag = false;
        }
    }
    catch
    {
        Console.WriteLine("Необходимо ввести целое число");
    };
};
Console.WriteLine(week[numb - 1]);
//3.4
Console.WriteLine("Введите начало интервала");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конец интервала");
int finish = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = start; i <= finish; i++)
{
    if (i % 2 != 0)
    {
        sum += i;
    };
};
Console.WriteLine(sum);
//3.5
Console.WriteLine("Введите количество чисел Фибоначчи");
int num = Convert.ToInt32(Console.ReadLine());
int first = 0;
int second = 1;
int next = 1;
for (int i = 1; i <= num; i++)
{
    if (i == 1) { Console.WriteLine(first); }
    else if (i == 2) { Console.WriteLine(second); }
    else
    {
        next = first + second;
        first = second;
        second = next;
        Console.WriteLine(second);
    }
}
//4.1
using System.Collections;
using System.Globalization;

bool flag = true;
int numb = 0;
while (flag)
{
    Console.WriteLine("Введите размер массива");
    try
    {
        numb = Convert.ToInt32(Console.ReadLine());
        if (numb > 0)
        {
            flag = false;
        }
    }
    catch
    {
        Console.WriteLine("Необходимо ввести целое положительное число");
    };
};
ArrayList numbs = new ArrayList();
for (int i = 1; i <= numb; i++)
{
    numbs.Add(5 * i + 2);
};
foreach (int i in numbs)
{
    Console.WriteLine(i);
};
//4.2
using System.Collections;

ArrayList powers2 = new ArrayList();
for (int i = 0; i < 11; i++)
{
    powers2.Add(Math.Pow(2, i));
};
Console.WriteLine("Массив в прямом порядке");
foreach (double i in powers2)
{
    Console.WriteLine(i);
};
Console.WriteLine("Массив в обратном порядке");
powers2.Reverse();
foreach (double i in powers2)
{
    Console.WriteLine(i);
};
//4.3
Console.WriteLine("Введите фразу");
string phrase = Console.ReadLine();
Array symbol_arr = phrase.Split(' ');
Console.WriteLine("Массив в прямом порядке");
foreach (string i in symbol_arr)
{
    Console.WriteLine(i);
};
Array.Reverse(symbol_arr);
Console.WriteLine("Массив в обратном порядке");
foreach (string i in symbol_arr)
{
    Console.WriteLine(i);
};
//4.4
Console.WriteLine("Введите длину массива");
int numb = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[numb];
int count_pos = 0;
int count_neg = 0;
Console.WriteLine("Введите {0} чисел", numb);
for (int i = 0; i < numb; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
    if (arr[i] > 0)
    {
        count_pos++;
    };
    if (arr[i] < 0)
    {
        count_neg++;
    };
};
Console.WriteLine("Количество положительных чисел: {0}; Количество отрицательных чисел: {1}", count_pos, count_neg);

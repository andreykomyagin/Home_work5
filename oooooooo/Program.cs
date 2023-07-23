// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int [] massiv,int minvalue = 10, int maxvalue = 20)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = new Random().Next(minvalue, maxvalue + 1);
    }
}

void PrintArray (int [] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write($"{massiv[i]} ");
    }
    Console.WriteLine();
}



void Task31()
{
int [] array = new int [12];
FillArray(array, -9, 9);
Console.WriteLine("Распечатаем исходный массив");
PrintArray(array);
int sum_plus = 0;
int sum_minus = 0;
for(int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sum_plus = sum_plus + array[i];
    }
    else if (array[i] < 0)
    {
        sum_minus = sum_minus + array[i];
    }
}
Console.WriteLine($"{sum_plus} - сумма положительных чисел");
Console.WriteLine($"{sum_minus} - сумма отрицательных чисел");
}

//Task31();

void Task32()
{
    int size = new Random().Next(1,9);
    int [] array = new int [size];
    FillArray(array, -10, 10);
    Console.WriteLine("Распечатаем исходный массив!");
    PrintArray(array);
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    Console.WriteLine("Распечатаем конечный массив!"); 
    PrintArray(array);
}

//Task32();

void Task33()
{
    int size = new Random().Next(1,9);
    int [] array = new int [size];
    FillArray(array, 0, 100);
    Console.WriteLine("Распечатаем исходный массив!");
    PrintArray(array);
    int nom = Input("Искомое число: ");
    int a = -1;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] == nom)
        {
            a = a * (-1);
            break;
        }
    }
    if(a == 1)
    {
        Console.WriteLine("Yes!");
    }
    else if (a == -1)
    {
         Console.WriteLine("No!");
    } 
}

//Task33();

void Task35()
{
    int size = 10;
    int [] array = new int [size];
    FillArray(array, 0, 1000);
    Console.WriteLine("Распечатаем исходный массив!");
    PrintArray(array);
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= 99 && array[i] >= 10)
        {
            count = count + 1;
        }
    }
    Console.WriteLine($"Количество элементов, лежащих в отрезке [10,99] = {count}");
}
//Task35();

void Task37()
{
    int size = new Random().Next(1,10);
    int [] array = new int [size];
    FillArray(array, -10, 10);
    PrintArray(array);
    if (size == 1)
    {
        Console.WriteLine(array[0]);
    }
    else if (size % 2 == 0)
    {
        int [] post_array = new int [size/2];
        for (int i = 0; i < size/2; i++)
        {
            post_array[i] = array[i] * array[size - 1 - i];
        }
        Console.WriteLine("Распечатем итоговый массив!");
        PrintArray(post_array);
    }
    else if(size % 2 == 1)
    {
        int [] post_array = new int [size / 2 + 1];
        for (int i = 0; i < size / 2 ; i++)
        {
            post_array[i] = array[i] * array[size - 1 - i];
        }
        post_array[size/2] = array[size/2];
        Console.WriteLine("Распечатем итоговый массив!");
        PrintArray(post_array);
    }
}
Task37();
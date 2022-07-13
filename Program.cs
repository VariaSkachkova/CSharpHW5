void Task34()
{
Console.WriteLine("Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
int size = 8;
int [] array = new int[size];
FillArray(array, 100, 1000);
Console.WriteLine("Вывод массива: ");
PrintArray(array);
FindEvenCount(array);
} 
void FindEvenCount (int [] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    
    if (array[i] % 2 == 0)
    {
        count++;
              
    }    
        
}
Console.WriteLine($"Количество четных чисел в массиве: {count}");
}

void FillArray(int[] array, int startNumber = 0, int endNumber = 0)
{
    endNumber++;
    Random random = new Random();
    for (int i = 0; i <array.Length; i++)
    {
        array[i] = random.Next(startNumber,endNumber);
        
    }
        
}
void PrintArray (int [] array)
{
    for (int i = 0; i <array.Length; i++)
    {
        
        Console.Write(array[i] + " ");
        
    }
    Console.WriteLine();
}

Task34();
Console.WriteLine();
void Task36()
{
Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
Random random = new Random();
int size = random.Next(4,10);
int [] array = new int [size];
FillArray(array, 0, 10);
Console.WriteLine("Вывод массива: ");
PrintArray(array);
SumUpOddIndexValues (array);
void SumUpOddIndexValues (int [] array)
{
int sum = 0;
for (int i = 0; i < array.Length - 1; i++)
{
    if (i % 2 == 1) sum = sum + array[i];
    
}
Console.WriteLine("Сумма элементов с нечетными индексами: " + sum);
}
}
Task36();
Console.WriteLine();

void Task38()
{
Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.");

double[] array = new double [8];
FillArrayD(array);
Console.WriteLine("Вывод массива: ");
PrintArrayD(array);
Console.WriteLine($"Разность между максимальным значением {FindMax(array)} и минимальным значением {FindMin(array)} равна {Math.Round(FindMax(array)- FindMin(array), 2)}");
}

double FindMin (double [] array)
{ 
    
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) 
        {
            min = array[i];
        }
        
    }
    return min;  

}
double FindMax (double [] array)
{
    
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        
        if (array[i] > max) 
            {
                max = array[i];
            }
    }
    return max;

}
void FillArrayD(double [] array)
{
    Random random = new Random();
    for (int i = 0; i <array.Length; i++)
    {
        array[i] = Math.Round(random.NextDouble() * 10, 1);       
    }
    
        
}
void PrintArrayD (double [] array)
{
    for (int i = 0; i <array.Length; i++)
    {
        
        Console.Write(array[i] + " ");
        
    }
    Console.WriteLine();
}
Task38();
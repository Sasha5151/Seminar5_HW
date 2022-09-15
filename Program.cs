// Урок 5. Функции продолжение

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int size = 10;
// int[]array = new int[size];
// FillArray (array);
// System.Console.WriteLine("[{0}]" , string.Join(" , ", array));
// Check2(array);

// void FillArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//     array[i] = new Random().Next(100 , 999);
//     }
// }
// void Check2(int [] array)
// {
//     int Even = 0;
  
//     for (int i = 0; i < array.Length-1; i++)
//     {
//         if (array[i]%2 == 0)
//         Even = Even + 1;
//     }
// System.Console.WriteLine(Even);
// }

//End



// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int size = 10;
// int[]array = new int[size];
// FillArray (array);
// System.Console.WriteLine("[{0}]" , string.Join(" , ", array));
// Sum(array);

// void FillArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//     array[i] = new Random().Next(-100 , 100);
//     }
// }

// void Sum(int [] array)
// {
//   int Sum = 0 ;
//     for (int i = 1; i < array.Length; i=i+2)
//     {
//      Sum = Sum + array[i] ;
//     }
//      System.Console.WriteLine(Sum);
// }

//End



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// int size = 15;
// int[]array = new int[size];
// FillArray (array);
// System.Console.WriteLine("[{0}]" , string.Join(" , ", array));
// MaxMin(array);

// void FillArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//     array[i] = new Random().Next(0 , 100);
//     }
// }

// void MaxMin(int [] array )
// {
//      int max = array[0];
//      int min = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] > max)
//         max = array[i];
//         if (array[i] < min)
//         min = array[i];
//     }
//     int Delta = max - min ;
//     System.Console.WriteLine(Delta);

// }


int size = 15;
double[]array = new double[size];
FillArray (array);
System.Console.WriteLine("[{0}]" , string.Join(" , ", array));
MaxMin(array);

void FillArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    double array[i] = new Random().NextDouble(0 , 100);
    }
}

void MaxMin(int [] array )
{
     int max = array[0];
     int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        max = array[i];
        if (array[i] < min)
        min = array[i];
    }
    int Delta = max - min ;
    System.Console.WriteLine(Delta);

}
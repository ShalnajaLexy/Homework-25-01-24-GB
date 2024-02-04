//Homework (25.01.24)
// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// Console.WriteLine("Введите первое число m:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число n:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// PrintNumbers(num1, num2);

// void PrintNumbers(int firstNum, int endNum)
// {
//     if (num1 <= num2)
//     {
//         if (firstNum > endNum)
//         {
//             return;
//         }
//         Console.WriteLine(firstNum);
//         PrintNumbers(firstNum + 1, endNum);
//     }

//     if (num1 >= num2)
//     {
//         if (endNum > firstNum)
//         {
//             return;
//         }
//         Console.WriteLine(endNum);
//         PrintNumbers(firstNum, endNum + 1);
//     }
// }


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// Console.Write("Введите значение m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int Akkerman(int m, int n)
// {
//   if (m == 0) 
//   {
//     return n + 1;
//   }
//   else if (m > 0 && n == 0) 
//   {
//     return Akkerman(m - 1, 1);
//   }
//   else 
//   {
//     return Akkerman(m - 1, Akkerman(m, n - 1));
//   }
// }

// Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

// Console.WriteLine("Введите размер массива (число)"); 
// int sizeArray = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [sizeArray];
// int i = 0;

// void GetArray(int[] array, int i) 
// {
//     if (i == array.Length)
//     {
//         return;
//     }
//     array[i] = new Random().Next(10, 1000);
//     GetArray(array, ++i);
// }

// void PrintArray(int[] array, int i)
// {
//     if (i == array.Length)
//     {
//         return;
//     }    
//         Console.Write(array[i] + " ");
//         PrintArray(array, ++i);
// }   

// void GetFlippedArray(int[] array, int i) 
// {
//     int temp = array[i];
//     if (i == array.Length/2)
//     {
//         return;
//     }
    
//     array[i] = array[array.Length - 1 - i];
//     array[array.Length - 1 - i] = temp;
//     GetFlippedArray(array, ++i);
// }

// void PrintFlippedArray(int[] array, int i)
// {
//     if (i == array.Length)
//     {
//         return;
//     }
//     Console.Write(array[i] + " ");
//     PrintFlippedArray(array, ++i);
// }

// GetArray(array, i);
// PrintArray(array, i);
// Console.WriteLine();
// GetFlippedArray(array, i);
// PrintFlippedArray(array, i);




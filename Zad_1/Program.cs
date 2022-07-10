//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Console.WriteLine("Введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int  number2 = Convert.ToInt32(Console.ReadLine());
// double result = Math.Pow(number1, number2);
// Console.WriteLine(result);
// Цикл здесь не уместен - нечего циклить.


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Console.WriteLine("Введите число");
// int inputNumber = Convert.ToInt32(Console.ReadLine());
// int number = inputNumber; // Создал переменную для того, чтобы в выводе в интерполяции отобразить исходное число.
// int result = 0;
// while (number > 0)
// { 
//     result = result + number % 10;
//     number = number / 10;
// }
// Console.WriteLine($"Сумма всех цифр числа {inputNumber} равна {result}");


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// int [] array = new int [8];
//     for (int i = 0; i < array.Length; i++)
//     {
//     array[i] = new Random().Next(1, 100);   
//     }
// Console.WriteLine($"[{String.Join(", ", array)}]");

// Или с помощью метода:

// int [] array = RandomArray(8);
// int [] RandomArray(int size)
// {
//     int [] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//     array[i] = new Random().Next(1, 100);
//     }
//       return array;

// }
// Console.WriteLine($"[{String.Join(", ", array)}]");

﻿// Домашнее задание.

// 1 задача.
// Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

// int[]arr = new int[10];                        // задаем массив из 10 чисел
// int ind = 0;                          // счетчик для подсчета чисел в нужном диапазоне

// for (int i=0; i<10; i++)                      // задаем условие какой должен быть массив
// {
//     arr[i] = new Random().Next(1, 101);             // числа выбираются случайные от 1 до 100
//     Console.Write(arr[i] + "  ");                 // вывод массива будет в строку
// }

// for (int i=0; i<10; i++)                      // задаем условие какой должен быть массив
// {
//     if (arr[i]>19 && arr[i]<91)                   // задаем условие для поиска элементов в данном диапазоне
//     {    
//         ind=ind+1;                                // подсчитываем количество чисел из заданного диапазона
//     } 
// }
//     Console.WriteLine();                             // чтобы следующий вывод был на новой строке, не сливался с предыдущим выводом массива
//     Console.Write("Чисел от 20 до 90 в данном массиве: " + ind);      // вывод количества чисел массива из заданного диапазона     



// 2 задача.
// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

// Console.WriteLine("Введите целое число");  // задатть случайное число, которое определит край диапазона для рандомного саставления массива 
// int num = Convert.ToInt32(Console.ReadLine());

// int[] arr = new int[10];

// for (int i=0; i<10; i++)
// {
//     arr[i] = new Random().Next(1, num);           // выбираем рандомно от одного до введенного случайного числа
//     Console.Write(arr[i] + ", ");          
//    // вывод элементов массива - за каждый проход по циклу будет добавлять новый элемень - и на выходе весь массив
//    // Console.Write($"{arr[i]}, "); можно такую запитсь вывода в строку массива

// }

// Console.WriteLine();        // чтобы перевести курсор на новую строку

// int ind = 0; 

// for (int i=0; i<10; i++)
// {
//     if (arr[i]%2 == 0)       // проверяем каждый элемент массива (остаток от деления на два должен быть равен "0")
//     {
//         ind=ind+1;               // если элемент четный, то счетчик увеличивается на 1
//     }
// }
// Console.Write(ind);            // команда вывода результата за циклом!


// 3 задача.
// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// Random rnd = new Random();                       // Присвоение rnd
// double[] arr = new double[10];

// for (int i=0; i<10; i++)
// {
//     arr[i]= Math.Round(rnd.NextDouble()*(num-0), 3);   
//     // Настройка: 1) генирации случайных вещественных чисел от "0" до введенного числа "num". 2) И кол-ва цифр после запятой (3)
//     Console.Write(arr[i] + ";  ");
// }
// Console.WriteLine();               // Перевод курсора на новую строку

// double max = arr[0];
// double min = arr[0];

// for (int i=0; i<10; i++)
// {
//     if (arr[i]>max)  max = arr[i];
//     if (arr[i]<min)  min = arr[i];
// }
// Console.WriteLine("Максимальный элемент массива = " + max);
// Console.WriteLine("Минимальный элемент массива = " + min);
// Console.WriteLine("Разница между максимальным и минимальным элементами массива = " + String.Format("{0:F4}", max-min));
// // Запись ответа с нужным кол-вом цифр после запятой (4)


// 4 задача.
// Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен располагаться
//  на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.


// int num = new Random().Next(1, 100000);   //  случайное натуральное число в указанном диапазоне
// Console.Write(num);

// int num1 = num;   // создали равную переменную для работы в разных циклах
// int n = 0;

// while (num > 0)
//     {
//     num = num/10;
//     n=n+1;
//     }
// Console.WriteLine("  -  " + n + " значное число");

// int[] arr = new int[n];   // элементы выстроены: сначала последняя цифра числа и т.д.
// int[] arr2 = new int[n];  // для элементов в обратном порядке

// for(int i=0; i<n; i++)
//     {
//     arr[i] = num1%10;
//     num1=num1/10;
//     }  

// for(int i=0; i<n; i++)
//     {
//     arr2[i] = arr[n-1-i];
//     Console.Write(" " + arr2[i]);
//     }







// 1 задача

// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[5];

// bool isFind =false;

// for(int i =0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(0,4);   // -191   205
//     System.Console.Write(array[i]+ " ");

//     if(array[i] == num)
//     {
//         isFind=true;
//     }
// }

// if(isFind == true)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }


// 2 задача

// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

// int[] array = new int[10];

// for(int i =0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(-10,11); 
//     System.Console.Write(array[i]+ " ");
// }

// Console.WriteLine();

// for(int i =0; i<array.Length; i++)
// {
//     array[i] = array[i] *-1; 
//     System.Console.Write(array[i]+ " ");
// }


// 3 задача

// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5]

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[num];
// int[] array2 = new int[num/2];

// for(int i =0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(-10,20); 
//     System.Console.Write(array[i]+ " ");

// }

// System.Console.WriteLine();

// for(int i = 0; i<array2.Length; i++)
// {
//     if(i == array.Length-1-i)    // это если нечетное кол-во элементов, 
//     {
//         return;                  // когда центральный слева является центральным справа - одним и тем же
//     }

//     array2[i] = array[i] * array[array.Length-1-i]; 
//     Console.Write(array2[i]+ " ");
// }


// 4 задача

// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[3];

// if(num>99 && num<1000)
// {
//     array[0]= num%10;
//     array[1]= num/10 %10;
//     array[2] = num/100;

//     for(int i =0; i<array.Length; i++)
//     {
//         System.Console.Write(array[i]+ " ");
//     }
// }
// else
// {
//     System.Console.WriteLine("Число не подходит");
// }

// ______________________________________________________________________________________________________________________________
// ______________________________________________________________________________________________________________________________



// 1 задача

// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[5];

// bool isFind =false;

// for(int i =0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(0,4);   // -191   205
//     System.Console.Write(array[i]+ " ");

//     if(array[i] == num)
//     {
//         isFind=true;
//     }
// }

// if(isFind == true)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }


// 2 задача

// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

// int[] array = new int[10];

// for(int i =0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(-10,11); 
//     System.Console.Write(array[i]+ " ");
// }

// Console.WriteLine();

// for(int i =0; i<array.Length; i++)
// {
//     array[i] = array[i] *-1; 
//     System.Console.Write(array[i]+ " ");
// }


// 3 задача

// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5]

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[num];
// int[] array2 = new int[num/2];

// for(int i =0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(-10,20); 
//     System.Console.Write(array[i]+ " ");

// }

// System.Console.WriteLine();

// for(int i = 0; i<array2.Length; i++)
// {
//     if(i == array.Length-1-i)    // это если нечетное кол-во элементов, 
//     {
//         return;                  // когда центральный слева является центральным справа - одним и тем же
//     }

//     array2[i] = array[i] * array[array.Length-1-i]; 
//     Console.Write(array2[i]+ " ");
// }


// 4 задача

// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[3];

// if(num>99 && num<1000)
// {
//     array[0]= num%10;
//     array[1]= num/10 %10;
//     array[2] = num/100;

//     for(int i =0; i<array.Length; i++)
//     {
//         System.Console.Write(array[i]+ " ");
//     }
// }
// else
// {
//     System.Console.WriteLine("Число не подходит");
// }




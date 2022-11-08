// // Урок 8. Как не нужно писать код. Часть 2
// // Задача 54: Задайте двумерный массив. 
// // Напишите программу, которая упорядочит 
// // по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2

// // Решение задачи 54

// Console.WriteLine ("Задача 54:\n Задайте двумерный массив. \n Напишите программу," + 
//                   "которая упорядочит \n по убыванию элементы каждой строки двумерного массива. \n");

// Console.Write("Введите количество строк в массиве: ");
// int rowsCount = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов в массиве: ");
// int columnCount = Convert.ToInt32(Console.ReadLine());

// int [,] FillArray()

// {

// int [,] notSortArray = new int[rowsCount, columnCount];
//     Random random = new Random();
//     for (int i = 0; i < notSortArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < notSortArray.GetLength(1); j++)
//         {
//             notSortArray[i, j] = random.Next(1,100);            
            
//         }

//     }
//     return notSortArray;      
    
// }    

// void ShowNotSortArray(int[,] notSortArray)
// {  

//     for (int i=0; i < notSortArray.GetLength(0); i++)    
//      {           
//         for (int j=0; j < notSortArray.GetLength(1); j++)
//         {           
//          Console.Write(notSortArray[i, j]);          
//          Console.Write(" ");             
//         }
//            Console.WriteLine("");                                                   
                                        
//      }      
      
// }

// void OrderArrayLines(int[,] notSortArray)
// {
//  int [,] testArray = new int[rowsCount, columnCount];

//   for (int i = 0; i < notSortArray.GetLength(0); i++)
//   {
//     for (int j = 0; j < notSortArray.GetLength(1); j++)
//     {
//       for (int k = 0; k < notSortArray.GetLength(1) - 1; k++)
//       {
//         if (notSortArray[i, k] < notSortArray[i, k + 1])
//         {
//           int temp = notSortArray[i, k + 1];
//           notSortArray[i, k + 1] = notSortArray[i, k];
//           notSortArray[i, k] = temp;
//         }
//       }
//     }
//   }

//      for (int i=0; i < notSortArray.GetLength(0); i++)    
//      {           
//         for (int j=0; j < notSortArray.GetLength(1); j++)
//         {           
//          Console.Write(notSortArray[i, j]);          
//          Console.Write(" ");             
//         }
//            Console.WriteLine("");                                                   
                                        
//      }                                     
// }


// Console.WriteLine("Неотсортированный массив");
// int [,] myArray = FillArray ();
// ShowNotSortArray(myArray);
// Console.WriteLine();
// Console.WriteLine("Cортированный массив");
//  OrderArrayLines(myArray);

//  // Решение задачи 54 - завершено



// // Задача 56: Задайте прямоугольный двумерный массив. 
// // Напишите программу, которая будет находить 
// // строку с наименьшей суммой элементов.

// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // 1 строка

// // Решения задачи 56

// Console.WriteLine("Задача 56: \n Задайте прямоугольный двумерный массив.\n" + 
//                   "Напишите программу, которая будет находить \n" + 
//                   "строку с наименьшей суммой элементов.");

// Console.Write("Введите количество строк в массиве: ");
// int rowsCount = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов в массиве: ");
// int columnCount = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int [,] FillArray()

// {

// int [,] notСalculatedLine = new int[rowsCount, columnCount];
//     Random random = new Random();
//     for (int i = 0; i < notСalculatedLine.GetLength(0); i++)
//     {
//         for (int j = 0; j < notСalculatedLine.GetLength(1); j++)
//         {
//             notСalculatedLine[i, j] = random.Next(1,100);            
            
//         }

//     }
//     return notСalculatedLine;      
    
// }    

// void ShowArray(int[,] notСalculatedLine)
// {  

//     for (int i=0; i < notСalculatedLine.GetLength(0); i++)    
//      {           
//         for (int j=0; j < notСalculatedLine.GetLength(1); j++)
//         {           
//          Console.Write(notСalculatedLine[i, j]);          
//          Console.Write(" ");             
//         }
//            Console.WriteLine("");                                                   
                                        
//      }      
      
// }

// void СalculatedRate(int[,] notСalculatedLine)
// {

// int test2 =1;
// int test =0;
// int sumLine = 0;
// for (int i=0; i < notСalculatedLine.GetLength(0); i++)    
//      {          

//         for (int j=0; j < notСalculatedLine.GetLength(1); j++)
//         {           
//          sumLine += notСalculatedLine[i,j];        

//          }
          
//           if (i<1) {
//             test = sumLine;
//          }        
//          else
//          {
//             if (test > sumLine)
//             {
//                 test = sumLine;                
//                 test2 = i+1;
//             }
         
         
//         }
                
//          //test += sumLine;                                                 
//          sumLine=0;
         
//      }      
   
//    Console.WriteLine("Строкой с наименьшей суммой элементов является " + test2 + " строка");
//    Console.WriteLine("Сумма элементов строки = " + test);
   

// }

// Console.WriteLine();
// Console.WriteLine("Заданный массив");
// int [,] myArray = FillArray ();
// ShowArray(myArray);
// Console.WriteLine();
// СalculatedRate(myArray);
// Console.WriteLine();

// // Решения задачи 56 --- Завершено



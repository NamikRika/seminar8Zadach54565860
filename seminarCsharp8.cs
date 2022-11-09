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

//  // Решение задачи 54 - завершено -----------------------------------------------



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

// // Решения задачи 56 --- Завершено ----------------------------------------------


// // Задача 58: Задайте две матрицы. 
// // Напишите программу, которая будет находить 
// // произведение двух матриц. Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18

// Console.WriteLine ("Задача 58: \n Задайте две матрицы." + 
//                    "Напишите программу, которая будет находить \n"  +
//                    "произведение двух матриц. Например, даны 2 матрицы: \n");


// Console.Write("Введите количество строк первой матрицы: ");
// int numberRowsFirstMatrix = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов первой матрицы: ");
// int numberColumnFirstMatrix = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество строк второй матрицы: ");
// int numberRowsSecondMatrix = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов второй матрицы: ");
// int numberColumnSecondMatrix = Convert.ToInt32(Console.ReadLine());


// int [,] firstMatrix = new int[numberRowsFirstMatrix, numberColumnFirstMatrix];
// {
//     Random random = new Random();
//     for (int i = 0; i < firstMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < firstMatrix.GetLength(1); j++)
//         {
//             firstMatrix[i, j] = random.Next(1,10);            
            
//         }

//     }
    
// }

// void ShowArrayFirstMatrix(int[,] firstMatrix)
// {  

//     for (int i=0; i < firstMatrix.GetLength(0); i++)    
//      {           
//         for (int j=0; j < firstMatrix.GetLength(1); j++)
//         {           
//          Console.Write(firstMatrix[i, j]);          
//          Console.Write(" ");             
//         }
//            Console.WriteLine("");                                                   
                                        
//      }      
      
// }

// Console.WriteLine("Значения первой матрицы");
// ShowArrayFirstMatrix(firstMatrix);

// int [,] secondMatrix = new int[numberRowsSecondMatrix, numberColumnSecondMatrix];
// {
//     Random random = new Random();
//     for (int i = 0; i < secondMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < secondMatrix.GetLength(1); j++)
//         {
//             secondMatrix[i, j] = random.Next(1,10);            
            
//         }

//     }
     
// }    

// void ShowArraySecondMatrix(int[,] secondMatrix)
// {  

//     for (int i=0; i < secondMatrix.GetLength(0); i++)    
//      {           
//         for (int j=0; j < secondMatrix.GetLength(1); j++)
//         {           
//          Console.Write(secondMatrix[i, j]);          
//          Console.Write(" ");             
//         }
//            Console.WriteLine("");                                                   
                                        
//      }      
      
// }

// Console.WriteLine("Значения второй матрицы");
// ShowArraySecondMatrix(secondMatrix);


// int[,] resultMatrix = new int[numberRowsFirstMatrix,numberColumnSecondMatrix];

// void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMatrix.GetLength(1); k++)
//       {
//         sum += firstMatrix[i,k] * secondMatrix[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }

// void ShowResultMatrix(int[,] resultMatrix)
// {  

//     for (int i=0; i < resultMatrix.GetLength(0); i++)    
//      {           
//         for (int j=0; j < resultMatrix.GetLength(1); j++)
//         {           
//          Console.Write(resultMatrix[i, j]);          
//          Console.Write(" ");             
//         }
//            Console.WriteLine("");                                                   
                                        
//      }      
      
// }


// MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
// Console.WriteLine("Произведение первой и второй матриц:");
// ShowResultMatrix(resultMatrix);

// // // Решения задачи 58 --- Завершено ----------------------------------------------

// Задача 60: 
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.

Console.Write("Введите размер массива X: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива Y: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива Z: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,,] Fill3dArray()
{
      
  int[,,] array3D = new int[size, min, max];
  
    Random random = new Random();

    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
               {
                   array3D[i,j,k] = random.Next(10,30);
               }
               
     } 
        
    }    

    int temp = array3D[0,0,0];

for (int ii = 0; ii < array3D.GetLength(0); ii++) // -----2
    {
        for (int jj = 0; jj < array3D.GetLength(1); jj++)
        {
            for (int kk = 0; kk < array3D.GetLength(2); kk++)
               {
                   if (array3D[ii,jj,kk] == temp)
                   array3D[ii,jj,kk] = temp;
                //    ii=0;
                //    jj=0;
                //    kk=0;                   
               }
               
     } 
    
    }  //--------  

   return array3D;
}    


void Show3dArray(int[,,] array3D)
{  

    for (int i=0; i < array3D.GetLength(0); i++)    
     {           
        for (int j=0; j < array3D.GetLength(1); j++)
        {           
                 for (int k=0; k < array3D.GetLength(2); k++)
                  {           
                      Console.Write(array3D[i, j, k]);          
                      Console.Write(" " + "(" + i + "," + j + "," + k  + ")" + "; ");             
                  }
                      Console.WriteLine("");                                                                                           
        }      
   
    }  
                                        
 }      
      

Console.WriteLine("Неотсортированный массив");
int [,,] myArray = Fill3dArray();
Show3dArray(myArray);
Console.WriteLine();

// Задача 60: завершена -----------------------
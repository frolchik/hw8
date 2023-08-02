

/*Task1 Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/
/*
int[,]  CreateNewMyArray(int rows, int columns, int minValue, int maxValue)
{
   int[,] array = new int[rows, columns];

   for (int i = 0; i < rows; i++)
   {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue +1);
        }
   }        
        return array;

}     

void ShowArray (int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine ();
    }
}

void SortArray (int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i,k] < array[i, k+1])
                {
                    int temp = array[i, k+1];
                    array[i, k+1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

Console.WriteLine ("Input a number of rows: ");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number of columns: ");
int columns = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number of minValue: ");
int minValue = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number of maxValue: ");
int maxValue = Convert.ToInt32 (Console.ReadLine());

int[,] myArray = CreateNewMyArray  (rows, columns, minValue, maxValue);
ShowArray(myArray);

Console.WriteLine("отсортированный массив: ");
SortArray(myArray);
ShowArray(myArray);

*/
/*Task2 Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.*/
/*
int[,]  CreateNewMyArray(int rows, int columns, int minValue, int maxValue)
{
   int[,] array = new int[rows, columns];

   for (int i = 0; i < rows; i++)
   {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue +1);
        }
   }        
        return array;

}     

void ShowArray (int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine ();
    }
}

int GetRowNumber (int [,] array)
    {
      int row = 0;
      int minsum = 0;
      for (int i = 0; i < array.GetLength(1); i++)
      {
        minsum = minsum + array[0,i];
      }

      for (int i = 1; i < array.GetLength(0); i++)
      {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
          sum = sum + array[i,j];
        }
        if (minsum > sum)
        {
          minsum = sum;
          row = i;
        }
      }
      return row + 1;
    }


Console.WriteLine ("Input a number of rows: ");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number of columns: ");
int columns = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number of minValue: ");
int minValue = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number of maxValue: ");
int maxValue = Convert.ToInt32 (Console.ReadLine());

int[,] myArray = CreateNewMyArray  (rows, columns, minValue, maxValue);
ShowArray(myArray);

Console.WriteLine($"Строка с наименьшей суммой - {GetRowNumber(myArray)}");
*/

/*Task3 Задайте две матрицы. Напишите программу,
 которая будет находить произведение двух матриц.*/

/*
int[,]  Matrix1 (int rows1, int columns1, int minValue, int maxValue)
{
   int[,] array = new int[rows1, columns1];

   for (int i = 0; i < rows1; i++)
   {
        for (int j = 0; j < columns1; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue +1);
        }
   }        
        return array;

}     

int[,]  Matrix2 (int rows2, int columns2, int minValue, int maxValue)
{
   int[,] array = new int[rows2, columns2];

   for (int i = 0; i < rows2; i++)
   {
        for (int j = 0; j < columns2; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue +1);
        }
   }        
        return array;

}     
void ShowArray (int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine ();
    }
}

int [,] GetMultiArray(int[,] array1, int[,] array2)
    {
      int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
      for (int i = 0; i < array1.GetLength(0); i++)
      {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
          for (int k = 0; k < array1.GetLength(1); k++)
          {
            array3[i, j] += array1[i, k] * array2[k, j];
          }
        }
      }
      return array3;
    }


Console.WriteLine ("Input a number of rows1: ");
int rows1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number of columns1: ");
int columns1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number of minValue: ");
int minValue = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number of maxValue: ");
int maxValue = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Input a number of rows2: ");
int rows2 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number of columns2");
int columns2 = Convert.ToInt32 (Console.ReadLine());

if (columns1 != rows2 || columns1 != columns2)
{
  Console.WriteLine("Такие матрицы умножать нельзя!");
  return;
}

Console.WriteLine("First Array: ");

int[,] myArray1 = Matrix1  (rows1, columns1, minValue, maxValue);
ShowArray(myArray1);

Console.WriteLine("Sesond Array: ");

int[,] myArray2 = Matrix2  (rows2, columns2, minValue, maxValue);
ShowArray(myArray2);

Console.WriteLine("MultiArray: ");
int[,] array3 = GetMultiArray(Matrix1, Matrix2);

ShowArray(array3);
*/
/*Task4 Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 Напишите программу, которая будет построчно выводить массив, 
 добавляя индексы каждого элемента*/
/*
void ShowArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void Create3DArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
Console.WriteLine ("Input a number of X: ");
int x = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number of Y: ");
int y = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input a number of Z: ");
int z = Convert.ToInt32 (Console.ReadLine());


int[,,] array3D = new int[x, y, z];
Create3DArray(array3D);
ShowArray(array3D);
*/

/*Task5 Напишите программу, которая заполнит спирально массив 4 на 4.*/

int n = 4;
int[,] spiralArray = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= spiralArray.GetLength(0) * spiralArray.GetLength(1))
{
  spiralArray[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < spiralArray.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= spiralArray.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > spiralArray.GetLength(1) - 1)
    j--;
  else
    i--;
}

ShowArray(spiralArray);

void ShowArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
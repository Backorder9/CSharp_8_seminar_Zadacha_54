/* Задача 54: Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int [,] Snake()
{
Console.WriteLine();
Console.Write("Введите количество строк массива целых чисел ~Змейка~: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите количество столбцов массива целых чисел ~Змейка~: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine();  
  int [,] snake = new int[a,b];
  snake[0,0] = 1;
  for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
        if (i > 0 && j == 0) snake[i,j] = snake[i-1,b-1] + 1;   
        if (j > 0) snake[i,j] = snake[i,j-1] + 1;
        }   
    }  
return snake;
}

int[,] SortArrayLinesByDescend(int[,] InputArray)
{
    int x = InputArray.GetLength(0);
    int y = InputArray.GetLength(1);
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y - 1; j++)
        {
            for (int z = 0; z < y - 1; z++)
            {
                if (InputArray[i, z] < InputArray[i, z + 1])
                {
                    int temp = 0;
                    temp = InputArray[i, z];
                    InputArray[i, z] = InputArray[i, z + 1];
                    InputArray[i, z + 1] = temp;
                }
            }
        }
    }
    return InputArray;
}
int[,] original = Snake();
PrintArray(original);
int[,] sorted = SortArrayLinesByDescend(original);

void PrintArray(int[,] array)
{
    System.Console.WriteLine();
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    System.Console.WriteLine();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
            System.Console.Write("{0}\t", array[i, j]);
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}


PrintArray(sorted);
// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows,colums,0, 100);
PrintArray(array);
Generation(array);
Console.WriteLine();
PrintArray(array);
void Generation(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            for (int g = 0; g < array.GetLength(1)-1; g++){
                if (array[i,g] < array[i,g+1]){
                    int temp = array[i,g+1];
                    array[i,g+1] = array[i,g];
                    array[i,g] = temp;
                }
            }
        }   
    }
}

int[,] GetArray (int m, int n, int minValue, int maxValue){
    int[,] mas = new int[m, n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            mas[i,j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return mas;
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}
*/

//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей 
//суммой элементов.
/*
Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int colums = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows,colums,0, 40);
if (rows == colums){
    Console.WriteLine("Матрица квадратная. Задайте значения, которые не равны");
} else {
    PrintArray(array);
    int[] res = SumRows(array);
    Console.WriteLine();
    int min = res[0];
    int result = 1;
    for (int i = 0; i < res.Length; i++){
        Console.Write(res[i]+ " ");
        if (min > res[i]){
            min = res[i];
            result = i+1;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Номер строки с наименьшей суммой: {result}");
}

int[] SumRows(int[,] array){
    int[] mas = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            mas[i] += array[i,j];
        }
    }
    return mas;
}

int[,] GetArray (int m, int n, int minValue, int maxValue){
    int[,] mas = new int[m, n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            mas[i,j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return mas;
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}
*/

//Задача 58: Задайте две квадратные матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
/*
Console.Write("Введите кол-во строк равных колво столбцов: ");
int rows = int.Parse(Console.ReadLine()!);

int[,] array1 = GetArray(rows, rows, 0, 10);
int[,] array2 = GetArray(rows, rows, 0, 10);
int[,] result = Multiply(array1,array2,rows);
Console.WriteLine("Первая матрица: ");
PrintArray(array1);
Console.WriteLine("Вторая матрица: ");
PrintArray(array2);
Console.WriteLine("Результирующая матрица: ");
PrintArray(result);

int[,] Multiply(int[,] ar1, int[,] ar2, int m){
    int[,] mas = new int[m,m];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < m; j++){
            int sum = 0;
            for (int k = 0; k < m; k++){
                sum += ar1[i,k]*ar2[k,j];
            }
            mas[i,j] = sum;
        }
    }
    return mas;
}

int[,] GetArray (int m, int n, int minValue, int maxValue){
    int[,] mas = new int[m, n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            mas[i,j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return mas;
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}
*/

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных 
//чисел. Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.
/*
int[,,] res = GetArray(10,20);
PrintArray(res);

int[,,] GetArray(int minValue, int maxValue){
    int[,,] array = new int[2,2,2];
    int[] mas = new int[8];
    int res = 0;

    for (int i = 0; i < mas.Length; i++){
        mas[i] = new Random().Next(minValue, maxValue);
        if (i > 0){
            for (int j = 0; j < i; j++){
                while (mas[i] == mas[j]){
                    mas[i] = new Random().Next(minValue, maxValue);
                    j = 0;
                }
            }
        }
    }

   for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            for (int k = 0; k < array.GetLength(2); k++){
                array[i, j, k] = mas[res];
                res++;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            for (int k = 0; k < array.GetLength(2); k++){
                Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}
*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows);
PrintArray(array);

int[,] GetArray(int m){
    int[,] array = new int[m, m];
    int i = 0;
    int j = 0;
    int peremen = 1;
    while ( peremen <= Math.Pow(m,2)){
        array[i, j] = peremen;
        peremen ++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1) j++;
        else if (i < j && i + j >= array.GetLength(0) - 1) i++;
        else if (i >= j && i + j > array.GetLength(1) - 1) j--;
        else i--;
    }
    return array;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if (array[i, j] < 10) Console.Write("0"+array[i,j]+ " ");
            else Console.Write(array[i,j]+ " ");
        }
    Console.WriteLine();
    }
}
*/
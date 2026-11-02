using System;

public class Task3
{

    private static float[,] ContingencyTable(float[][] data)
    {
        float[,] matrix = new float[2, 2];
        for (int k = 0; k < 2; k++)
        {
            for (int i = 0; i < 2; i++)
            {
                int sum = 0;
                for (int j = 0; j < data[0].Length; j++)
                {
                    if (data[0][j] == (1-k) && data[1][j] == (1-i))
                        sum += 1;
                }
                matrix[k,i] = sum;            
            }
        }
        return matrix;
    }
    private static void Print_Matrix(float[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write(matrix[i,j]+"\t");
            }
            System.Console.WriteLine();
        }
    }
    public static void ShowResults3_1()
    {
        float[][] x =
        {
            [1,1,0], // Форма навчання
            [2,1,0], // Оцінка участі
            [1,1,0] // Стипендія
        };

        int p = 3;
        float[,] d = new float[p, p];
        for (int k = 0; k < p; k++)
        {
            for (int i = k; i < p; i++)
            {
                int nezbig = 0;
                for (int j = 0; j < p; j++)
                {
                    if (x[j][k] != x[j][i])
                        nezbig++;
                }
                d[k,i] = (float)nezbig / p;
                d[i,k] = (float)nezbig / p;
            }
        }


        System.Console.WriteLine("Матриця несхожості");
        for (int i = 0; i < p; i++)
        {
            for (int j = 0; j < p; j++)
            {
                System.Console.Write(Math.Round(d[i,j], 2) + "\t");
            }
            System.Console.WriteLine();
        }


        System.Console.WriteLine();
        System.Console.WriteLine("Матриця подібності");
        for (int i = 0; i < p; i++)
        {
            for (int j = 0; j < p; j++)
            {
                System.Console.Write(Math.Round(1 - d[i,j], 2) + "\t");
            }
            System.Console.WriteLine();
        }
    }

    public static void ShowResults3_2()
    {
        float[][] data =
        {
            [1,1,0,1,1,0,1], // Форма навчання
            [1,1,0,1,1,0,0]  // Отримує стипендію
        };
        float[,] matrix = ContingencyTable(data);
        
        System.Console.WriteLine("Таблиця спряженості (спостережувані частоти O):");
        Print_Matrix(matrix);
        System.Console.WriteLine();

        int n = data[0].Length; // Загальна кількість об'єктів (N = 7)
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Масиви для сумарних значень по рядках (R) та стовпчиках (C)
        float[] rowSums = new float[rows];
        float[] colSums = new float[cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                rowSums[i] += matrix[i, j];
                colSums[j] += matrix[i, j];
            }
        }

        // 1. Розрахунок критерію хі-квадрат (chi-squared, χ²)
        float chiSquared = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                float e = (rowSums[i] * colSums[j]) / n; // Теоретична частота E_ij
                if (e > 0)
                {
                    float diff = matrix[i, j] - e;
                    chiSquared += (diff * diff) / e;
                }
            }
        }

        // 2. Розрахунок частотної міри φ² (коефіцієнт фі-квадрат)
        float phiSquared = chiSquared / n;

        // Виведення результатів
        System.Console.WriteLine($"Хі-квадрат (chi^2) = {Math.Round(chiSquared, 4)}");
        System.Console.WriteLine($"Частотна міра (phi^2) = {Math.Round(phiSquared, 4)}");
    }
}

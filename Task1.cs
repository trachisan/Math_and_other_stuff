class Task1
{
    static float[] first_oznaka = {1 ,1, 0}; // Форма навчання
    static float[] second_oznaka = {2, 1, 0}; // Оцінка участі
    static float[] third_oznaka = {19, 20, 20}; // Вік

    static void MatrixDiff(float[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a.Length; j++)
            {
                if (a[i] != a[j])
                    System.Console.Write(1 + "\t");
                else
                    System.Console.Write(0 + "\t");
            }
            System.Console.WriteLine();
        }
    }

    static void MatrixNearby(float[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a.Length; j++)
            {
                if (a[i] == a[j])
                    System.Console.Write(1 + "\t");
                else
                    System.Console.Write(0 + "\t");
            }
            System.Console.WriteLine();
        }
    }

    static void MatrixDiff2(float[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a.Length; j++)
            {
                System.Console.Write(Math.Round(Math.Abs(a[i] - a[j]) / 2, 1) + "\t");
            }
            System.Console.WriteLine();
        }

    }

    static void MatrixNearby2(float[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a.Length; j++)
            {
                System.Console.Write(Math.Round(1 - (Math.Abs(a[i] - a[j]) / 2), 1) + "\t");
            }
            System.Console.WriteLine();
        }
    }

    static float[,] MatrixDiff3(float[] a)
    {
        float[,] D = new float[a.Length, a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a.Length; j++)
            {
                D[i, j] = Math.Abs(a[i]-a[j]);
                System.Console.Write(D[i, j] + "\t");
            }
            System.Console.WriteLine();
        }
        return D;
    }

    static void MatrixNearby3(float[] a, float[,] D)
    {
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a.Length; j++)
            {
                System.Console.Write(Math.Round(1 / (1 + D[i, j]), 0) + "\t");
            }
            System.Console.WriteLine();
        }
    }

    public static void ShowResults()
    {
        System.Console.WriteLine("Матриця несхожості за номінальною ознакою:");
        MatrixDiff(first_oznaka);
        System.Console.WriteLine("Матриця подібності за номінальною ознакою");
        MatrixNearby(first_oznaka);

        System.Console.WriteLine("Матриця несхожості за порядковою ознакою");
        MatrixDiff2(second_oznaka);
        System.Console.WriteLine("Матриця подібності за порядковою ознакою");
        MatrixNearby2(second_oznaka);

        System.Console.WriteLine("Матриця несхожості за числовою ознакою");
        float[,] D = MatrixDiff3(third_oznaka);
        System.Console.WriteLine("Матриця подібності за числовою ознакою");
        MatrixNearby3(third_oznaka, D);
    }
}
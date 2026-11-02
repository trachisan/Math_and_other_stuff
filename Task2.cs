class Task2
{

    public static void ShowResults1()
    { 
        float[,] x =
        {
            {5,2,9,3,2,8,5,8},
            {9,1,5,8,4,7,10,7}
        };
        int n = 1;
        int k = 8;

        System.Console.Write("відстань Евкліда: ");
        double a = Math.Pow(x[0, n - 1] - x[0, k - 1], 2);
        double b = Math.Pow(x[1, n - 1] - x[1, k - 1], 2);
        System.Console.WriteLine(Math.Sqrt(a + b) + "\n");

        System.Console.Write("квадрата відстані Евкліда: ");
        System.Console.WriteLine(a + b + "\n");

        System.Console.Write("манхетенської відстані: ");
        double a1 = Math.Abs(x[0, n - 1] - x[0, k - 1]);
        double b1 = Math.Abs(x[1, n - 1] - x[1, k - 1]);
        System.Console.WriteLine(a1 + b1 + "\n");

        System.Console.Write("Відстані Чебишева: ");
        double a2 = Math.Abs(x[0, n - 1] - x[0, k - 1]);
        double b2 = Math.Abs(x[1, n - 1] - x[1, k - 1]);
        System.Console.WriteLine(Math.Max(a2, b2) + "\n");

        System.Console.Write("Пікової відстані: ");
        double a3 = Math.Abs(x[0, n - 1] - x[0, k - 1]) / (x[0, n - 1] + x[0, k - 1]);
        double b3 = Math.Abs(x[1, n - 1] - x[1, k - 1]) / (x[1, n - 1] + x[1, k - 1]);
        System.Console.WriteLine(0.5 * (a3 + b3) + "\n");

        System.Console.Write("відстані косинус: ");
        double a4 = (x[0, n - 1] * x[0, k - 1]) + (x[1, n - 1] * x[1, k - 1]);
        double b41 = Math.Sqrt(Math.Pow(x[0, n - 1],2) + Math.Pow(x[1, n - 1],2));
        double b42 = Math.Sqrt(Math.Pow(x[0, k - 1],2) + Math.Pow(x[1, k - 1],2));
        System.Console.WriteLine(1 - (a4 / (b41 * b42)) + "\n");

        System.Console.Write("Косинус подібності: ");
        double a5 = (x[0, n-1] * x[0, k-1]) + (x[1, n-1] * x[1, k-1]);
        double b51 = Math.Sqrt(Math.Pow(x[0, n-1], 2) + Math.Pow(x[1, n-1], 2)); 
        double b52 = Math.Sqrt(Math.Pow(x[0, k-1], 2) + Math.Pow(x[1, k-1], 2));
        System.Console.WriteLine(a5 / (b51 + b52));

        System.Console.Write("Кореляція Пірсона: ");
        double sum1 = 0;
        double sum2 = 0;
        for (int i = 0; i < x.GetLength(0); i++)
        {
            sum1 += x[0, i];
            sum2 += x[1, i];
        }
        
        double x1 =  sum1 / x.GetLength(0);
        double x2 =  sum2 / x.GetLength(0);

        double a6 = (x[0, n - 1] - x1)*(x[0, k - 1] - x1) + (x[1, n - 1] - x1)*(x[1, k - 1] - x1);
        double b61 = Math.Sqrt(Math.Pow(x[0, n - 1] - x1, 2)) + Math.Sqrt(Math.Pow(x[0, k - 1] - x2, 2));
        double b62 = Math.Sqrt(Math.Pow(x[1, n - 1] - x1, 2)) + Math.Sqrt(Math.Pow(x[1, k - 1] - x2, 2));

        System.Console.WriteLine(a6 / (b61 * b62));

    }

    public static void ShowResults2()
    {
        float[,] x =
        {
            {3,2,8,8},
            {8,4,7,7}
        };

        int numObj = x.GetLength(1);

        for (int i = 0; i < numObj; i++)
        {
            for (int j = 0; j < numObj; j++)
            {
                float x1_i = x[0, i];
                float x2_i = x[1, i];

                float x1_j = x[0, j];
                float x2_j = x[1, j];

                double d = Math.Max(Math.Abs(x1_i - x1_j), Math.Abs(x2_i - x2_j));

                System.Console.Write(d + "\t");
            }
            System.Console.WriteLine();
        }

        
    }
}
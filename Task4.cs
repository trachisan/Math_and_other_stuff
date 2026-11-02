using System;
public class Task4
{
    public static void ShowResults4()
    {
        int[] xi = { 0, 0, 0, 1, 1, 1, 0, 1 };
        int[] xj = { 0, 0, 0, 1, 1, 0, 1, 1 };
        int n = xi.Length;

        int q = 0, r = 0, s = 0, t = 0;

        for (int k = 0; k < n; k++)
        {
            if (xi[k] == 1 && xj[k] == 1) q++;
            else if (xi[k] == 1 && xj[k] == 0) r++;
            else if (xi[k] == 0 && xj[k] == 1) s++;
            else if (xi[k] == 0 && xj[k] == 0) t++;
        }

        Console.WriteLine("Таблиця спряженості");
        Console.WriteLine($"q (1, 1) = {q}");
        Console.WriteLine($"r (1, 0) = {r}");
        Console.WriteLine($"s (0, 1) = {s}");
        Console.WriteLine($"t (0, 0) = {t}");
        Console.WriteLine();

        double smc = (double)(q + t) / n;
        double dissimilaritySymmetric = (double)(r + s) / n;

        Console.WriteLine("бінарні атрибути що є симетричними");
        Console.WriteLine($"Коефіціент подібності: {smc:F4}");
        Console.WriteLine($"Міра несхожості: {dissimilaritySymmetric:F4}");
        Console.WriteLine();

        double jaccard = (q + r + s) == 0 ? 0 : (double)q / (q + r + s);
        double jaccardDistance = (q + r + s) == 0 ? 0 : (double)(r + s) / (q + r + s);

        Console.WriteLine("Асиметричні бінарні атрибути");
        Console.WriteLine($"Коефіцієнт Жаккара (подобие): {jaccard:F4}");
        Console.WriteLine($"Відстань Жаккара: {jaccardDistance:F4}");
    }
}

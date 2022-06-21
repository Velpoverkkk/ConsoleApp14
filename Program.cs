using System;
class Program
{   //Задана матрица размером NxM.Получить Массив В присвоив кго к-му элементу значение 1 , если все еслименты к-го столбца семетричны иначе 0
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int N, M, n = 0;
        System.Console.WriteLine("Razmer massiva NxM");
        N = System.Convert.ToInt32(Console.ReadLine());
        M = System.Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[N, M];
        int[] array1 = new int[N];
        for (int j = 0; j < N; j++)
        {
            for (int k = 0; k < M; k++)
            {
                array[j, k] = rnd.Next(0, 2);
                Console.Write(array[j, k]);
            }
            Console.WriteLine();
        }
        for (int j = 0; j < N; j++)
        {
            for (int k = 0; k < M/2; k++)
            {
                if (array[j,k] == array[j,M-k-1]) n++;
            }
            if (n == M/2) array1[j] = 1;
            else array1[j] = 0;
            n = 0;
        }
        for (int j = 0; j < N; j++) Console.WriteLine(array1[j]);
    }
}

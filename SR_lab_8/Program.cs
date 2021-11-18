using System;

namespace SR_lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] data1 ={ 0.09, 0.26, 0.16, 0.18, 0.17, 0.08, 0.06};
            double[] data2 = { 5, 25, 3, 0, 11, 3, 4 };
            int k = 7;
            double n0 = 20;
            double sum = 0;

            for (int i = 0; i < k; i++)
            {
                if(data2[i] == 0) data1[i] = 0;
                sum += (data1[i] * (data2[i] - 1)) / 100;
            }

            double r = n0 / 100 + sum;

            Console.WriteLine("Sum: {0}\nR: {1}", sum, r);
        }
    }
}

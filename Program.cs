using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._2
{
    class Program
    {
        public static void Main(String[] args)
        {
           //int[] array = { 9,5,2,8,7,3,1,6,7,4,6,3 };
           // int[] array = { 11, 14 ,13, 7 ,8 ,15 };
            int[] array = { 5,8, 7, 1, 9  };
            //int[] array = { 3, 10, 2, 1, 20 };
          // int [] array= { 50, 3, 10, 7, 40, 80 };
           //  int[] array = { 10, 22, 9, 33, 21, 50, 41, 60, 80 };
     
            List<int> list = new List<int>();
            List<int> longestList = new List<int>();
            int max;
            int didziausias = 0;
            var dp = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                max = int.MinValue;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] > max)
                    {
                        list.Add(array[j]);
                        max = array[j];
                       
                    }
                }

                if (didziausias < list.Count)
                {
                    didziausias = list.Count;
                    longestList = new List<int>(list);
                }
                list.Clear();
            }
            Console.WriteLine();

            //ilgis

            for (int i = 0; i < array.Length; i++)
            {
                dp[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] >array[j])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);

                    }

                }
            }
            Console.WriteLine("Sekos: ");
            for (int i = 0; i < array.Length; i++) {
                Console.Write("{0}  ", array[i]);
            }
            Console.WriteLine();
            // spausdinimas
            Console.WriteLine("Ilgiausias posekis: ");
            foreach (int itr in longestList)
            {
                Console.Write(itr + " ");
            }
           
            Console.WriteLine();
            Console.WriteLine("Posekio ilgis: " + dp.Max());
        }
    }
}

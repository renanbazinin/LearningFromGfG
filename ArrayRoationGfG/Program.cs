using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRoationGfG
{
    class Program
    {
        // n - size of array
        public static void RotateAti(int[] ar, int d, int n) //anticlockwise

        {
            int[] tempar = new int[d];

            for (int i = 0; i < tempar.Length; i++)
            {
                tempar[i] = ar[i];
            }
            int nextIndex = 0;
            for(int i=0; i < ar.Length; i++)
            {

                if (i + d <= n - 1)
                    ar[i] = ar[i + d];
                else {
                    ar[i] = tempar[nextIndex];
                    nextIndex++;
                }
            }


        }


        static void Main(string[] args)
        {

            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            Random randNum = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i]= randNum.Next(1, 13);

            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + ", ");
            
            Console.WriteLine();
            RotateAti(array, 2, array.Length);
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + ", ");


            Console.WriteLine();
        }
    }
}

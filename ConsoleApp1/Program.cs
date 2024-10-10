using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Task 1
            //{
            //    int[] arr1 = new int[10];
            //    Random rnd = new Random();
            //    for(int i = 0; i < arr1.Length; i++)
            //    {
            //        arr1[i] = rnd.Next(-20, 20);
            //        Console.Write(arr1[i] + " ");
            //    }

            //    Console.WriteLine();

            //    Console.WriteLine("Четные элементы: ");

            //    for (int i = 0;i<arr1.Length;i++)
            //    {
            //        if(i%2==0)
            //            Console.Write(arr1[i] + " ");
            //    }

            //    Console.WriteLine();

            //    Console.WriteLine("Нечетные элементы: ");


            //    for (int i = 0; i < arr1.Length; i++)
            //    {
            //        if (i % 2 == 1)
            //            Console.Write(arr1[i] + " ");
            //    }

            //    Console.WriteLine();

            //    Array.Sort(arr1);

            //    Console.WriteLine("Отсортированные элементы: ");


            //    foreach (int i in arr1)
            //        Console.Write(i + " ");

            //    Console.WriteLine();

            //    Console.WriteLine("Уникальные элементы: ");

            //    for (int i = 0; i < arr1.Length; i++)
            //    {
            //        if (i == arr1.Length - 1 || arr1[i] != arr1[i + 1])
            //            Console.Write(arr1[i] + " ");

            //        else if (arr1[i] == arr1[i + 1])
            //            i++;
            //    }

            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine();


            //}

            ////Task 2 
            //{
            //    int[] arr2 = new int[10];
            //    Random rnd = new Random();
            //    for (int i = 0;i< arr2.Length; i++)
            //    {
            //        arr2[i] = rnd.Next(-20, 20);
            //        Console.Write(arr2[i] + " ");
            //    }
            //    Console.WriteLine();

            //    Console.WriteLine("Введите параметр:");
            //    int param = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Значения строго меньше параметра: ");

            //    for(int i = 0;i< arr2.Length; i++)
            //    {
            //        if (arr2[i] < param)
            //        {
            //            Console.Write(arr2[i] + " ");
            //        }
            //    }

            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}

            ////Task 3
            //{
            //    int[] arr3 = new int[] { 7, 6, 5, 3, 4, 7, 6, 5, 3, 7, 6, 5 };
            //    Console.WriteLine("Введите последовательность из трех чисел:");


            //    int[] tmpArr = new int[3];
            //    for(int i = 0; i < tmpArr.Length; i++)
            //        tmpArr[i] = int.Parse(Console.ReadLine());

            //    int count = 0;
            //    bool flag;

            //    for(int i =0;i<arr3.Length; i++)
            //    {
            //        flag = false;
            //        for(int j =0;j<tmpArr.Length;j++)
            //        {
            //            if (tmpArr[j] == arr3[i] && i != arr3.Length-1)
            //            {
            //                i++;

            //                if (j == tmpArr.Length-1)
            //                    flag = true;
            //                continue;
            //            }
            //            else
            //                break;

            //        }
            //        if (flag)
            //            count++;

            //    }

            //    Console.WriteLine("Ваша последовательность встречается в массиве " + count + " раз");

            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine();

            //}

            //Task 4
            {
                int[] arr4 = new int[10];
                int[] arr5 = new int[10];

                int[] commonArr;
                int commonCount = 0;
                Random rnd = new Random();

                for(int i = 0; i < 10; i++)
                {
                    arr4[i] = rnd.Next(-20,20);
                    arr5[i] = rnd.Next(-20,20);
                }

                Console.WriteLine("Первый массив:");

                for (int i = 0; i < arr4.Length; i++)
                    Console.Write(arr4[i] + " ");

                Console.WriteLine();

                Console.WriteLine("Второй массив:");

                for (int i = 0; i < arr5.Length; i++)
                    Console.Write(arr5[i] + " ");

                Console.WriteLine();


                for (int i = 0;i<arr4.Length;i++)
                {
                    for(int j = 0;j<arr5.Length;j++)
                    {
                        if (arr4[i] == arr5[j])
                            commonCount++;
                    }
                }

                commonArr = new int[commonCount];

                int tmp = 0;
                
                for (int i = 0; i < arr4.Length; i++)
                {
                    for (int j = 0; j < arr5.Length; j++)
                    {
                        if (arr4[i] == arr5[j])
                            commonArr[tmp++] = arr4[i];
                    }
                }


                Array.Sort(commonArr);

                Console.WriteLine("Общие НЕ уникальные элементы из двух массивов:");


                foreach (int i in commonArr)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
                int updatedLength = commonCount;

                for(int i = 0; i < commonArr.Length; i++)
                {
                    if (i != commonArr.Length - 1 && commonArr[i] == commonArr[i+1] )
                        updatedLength--;
                }

                Console.WriteLine(updatedLength);
                Console.WriteLine();


                int[] updatedArr = new int[updatedLength];
                int updTmp = 0;

                for (int i = 0; i < commonArr.Length; i++)
                {
                    if (i == 0 || commonArr[i] != commonArr[i - 1])
                        updatedArr[updTmp++] = commonArr[i];
                }

                Console.WriteLine("Общие уникальные элементы из двух массивов:");
                foreach(int i in updatedArr)
                    Console.Write(i+ " ");
                Console.WriteLine();
                
            }
        }
    }
}

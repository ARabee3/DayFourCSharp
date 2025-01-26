using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text;

namespace Assignment;

internal class Program
{
    #region Q1 Function
    static void SwapNums(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    #endregion

    #region Q2 Function
    static int SumArray(ref int[] arr)
    {
        arr = new int[] { 1, 2, 33, 4, 5 };
        arr[0] = 10;
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }
    #endregion

    #region Q3 Function
    static void SumSub(int a, int b, out int sum, out int sub)
    {
        sum = a + b;
        sub = a - b;
    }

    #endregion

    #region Q4 Function
    static int SumDigits(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }
    #endregion

    #region Q5 Function
    static bool isPrime(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
    #endregion

    #region Q6 Function
    static int[] MinMaxArray(ref int[] arr)
    {
        int min = arr[0];
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min) min = arr[i];
            if (arr[i] > max) max = arr[i];
        }
        return new int[] { min, max };
    }
    #endregion

    #region Q7 Function
    static int FactorialIterative(int n)
    {
        if (n == 0) return 1;
        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }
        return fact;
    }
    #endregion

    #region Q8 Function
    static string ChangeChar(string str, char c, int index)
    {
        char[] arr = str.ToCharArray();
        arr[index] = c;
        return new string(arr);
    }
    #endregion

    #region Q9 Function
    static void PrintIdentityMatrix(int n)
    {
        int[,] arr = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j) arr[i, j] = 1;
                else arr[i, j] = 0;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    #endregion

    #region Q10 Function
    static int SumArray(int[] arr)
    {

        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }
    #endregion

    #region Q11 Function
    // this is merge sort algorithm
    static int[] MergeSortedArrays(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length + arr2.Length];
        int i = 0, j = 0, k = 0;

        while (i < arr1.Length && j < arr2.Length)
        {
            if (arr1[i] < arr2[j])
            {
                result[k++] = arr1[i++];
            }
            else
            {
                result[k++] = arr2[j++];
            }
        }

        while (i < arr1.Length)
        {
            result[k++] = arr1[i++];
        }

        while (j < arr2.Length)
        {
            result[k++] = arr2[j++];
        }


        return result;
    }
    #endregion

    #region Q12 Function
    // there is many approaches for this question but we can use frequency array
    static int[] CountFrequency(int[] arr)
    {
        int x = arr.Max();
        int[] freq = new int[x + 1];
        for (int i = 0; i < arr.Length; i++)
        {
            freq[arr[i]]++;
        }
        return freq;
    }
    #endregion

    #region Q13 Function
    static void MinMax(int[] arr, out int min, out int max)
    {
        min = arr[0];
        max = arr[0];
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] < min) min = arr[i];
            if (arr[i] > max) max = arr[i];
        }
    }
    #endregion

    #region Q14 Function
    static int SecondLargest(int[] arr)
    {
        Array.Sort(arr);
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] != arr[arr.Length - 1]) return arr[i];
        }
        return arr[arr.Length - 1];
    }
    #endregion

    #region Q15,16 Function
    static int MaxDistance(int[] arr)
    {
        int maxDistance = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    int distance = j - i - 1;
                    if (distance > maxDistance)
                    {
                        maxDistance = distance;
                    }
                }
            }
        }

        return maxDistance;
    }

    #endregion

    #region Q17 Function
    static string ReverseWords(string str)
    {
        string[] arr = str.Split(' ');
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            stringBuilder.Append(arr[i] + " ");
        }
        return stringBuilder.ToString();
    }
    #endregion

    #region Q19 Function
    static void PrintReversed(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
    }
    #endregion

    static void Main(string[] args)
    {
            #region Q1
            //// Difference between passing (Value type paramater) by reference and by value is:
            //// by value : only the value copied to the method and the original value will not be changed
            //// by reference : the original value will be changed because the address has been passed to the method
            //// Example:
            //int a = 5;
            //int b = 10;
            //SwapNums(a, b);
            //Console.WriteLine($"a: {a}, b: {b}");
            ////won't be replaced because the original value is not passed to the method
            //SwapNums(ref a, ref b);
            //Console.WriteLine($"a: {a}, b: {b}");

            #endregion

            #region Q2
            ////// Difference between passing (Reference type paramater) by reference and by value is:
            //// by value: the reference copied to the method and in the most cases it will be the same reference
            //// by reference: the original reference will be changed if it is changed inside the method using the keyword 'new'
            //// Example:
            //int[] arr = new int[] { 1, 2, 3, 4, 5 };
            //int sum = SumArray(ref arr);
            //Console.WriteLine(sum);
            //Console.WriteLine(arr[0]);
            //// will print the sum of the array inside the method
            #endregion
    
            #region Q3
            //SumSub(10, 5, out int sum, out int sub);
            //Console.WriteLine(sum);
            //Console.WriteLine(sub);
            #endregion

            #region Q4
            //Console.WriteLine(SumDigits(25));
            #endregion

            #region Q5
            //Console.WriteLine(isPrime(7));
            #endregion

            #region Q6
            //int[] arr = new int[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine(MinMaxArray(ref arr)[0]);
            //Console.WriteLine(MinMaxArray(ref arr)[1]);
            #endregion

            #region Q7   
            //Console.WriteLine(FactorialIterative(5));
            #endregion

            #region Q8
            //string str = "Hello";
            //Console.WriteLine(ChangeChar(str, 'a', 1));

            #endregion

            #region Q9
            //PrintIdentityMatrix(5);
            #endregion

            #region Q10
            //int[] arr = new int[] { 1, 2, 3, 4, 5 };
            //int sum = SumArray(arr);
            //Console.WriteLine(sum);
            #endregion

            #region Q11
            //int[] arr1 = { 1, 3, 5, 7 };
            //int[] arr2 = { 2, 4, 6, 8 };
            //int[] sorted = MergeSortedArrays(arr1, arr2);
            //foreach(var item in sorted)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion

            #region Q12
            //int[] arr = new int[] { 1, 2, 2, 3, 4, 4, 7, 8, 7 };
            //int[] freq = CountFrequency(arr);
            //for (int i = 0; i < freq.Length; i++)
            //{
            //    if (freq[i] != 0)
            //    {
            //        Console.WriteLine($"{i} : {freq[i]} times");
            //    }
            //}
            #endregion

            #region Q13
            //int[] arr = new int[] { 1, 2, 2, 3, 4, 4, 7, 8, 7 };
            //MinMax(arr, out int min, out int max);
            //Console.WriteLine(min);
            //Console.WriteLine(max);
            #endregion

            #region Q14
            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 2, 8 };
            //int result = SecondLargest(arr);
            //Console.WriteLine(result);

            #endregion

            #region Q15,16
            //int[] arr = { 7, 0, 0, 0 ,5, 6, 7, 5, 0, 7, 5, 3 };
            //Console.WriteLine(MaxDistance(arr));
            #endregion

            #region Q17
            //string str = "all your base";
            //string res = ReverseWords(str);
            //Console.WriteLine(res);
            #endregion

            #region Q18
            //Console.WriteLine("Enter the number of rows:");
            //int rows = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the number of columns:");
            //int cols = int.Parse(Console.ReadLine());

            //int[,] array1 = new int[rows, cols];
            //Console.WriteLine("Enter the elements of the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"Enter element at position [{i},{j}]: ");
            //        array1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //int[,] array2 = new int[rows, cols];
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        array2[i, j] = array1[i, j];
            //    }
            //}

            //Console.WriteLine("\nElements of the second array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(array2[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q19
            int[] arr = { 1, 2, 3, 4, 5 };
            PrintReversed(arr);
            #endregion
       
        }

    }






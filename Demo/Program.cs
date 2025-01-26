namespace Demo
{
    internal class Program
    {
        static void PrintShape() { 
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine("^-^");
            }
        }
        static void SwapNums(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static int SumArray(int[] arr)
        {
            arr[0] = 10;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static int SumNumber(int n1,int n2)
        {
            return n1 + n2;
        }
        static void SumMul(int a,int b, out int sum, out int mul)
        {
            sum = a + b;
            mul = a * b;
        }
        static void Main(string[] args)
        {
            #region OneDArr
            //// Fixed Size
            //// it allocates 8 bytes of memory in stack which stores its reference for the first element
            //// the equation of next index is (base address + (index * size of data type))
            //// it starts to be stored and refernced at heap when you add the keyword 'new'
            //int[] arr = new int[5];
            //int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //arr[3] = 4;
            //arr[4] = 5;
            ////arr[5] = 6; // out of range
            //// for printing/ adding array elements we can use looping
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    System.Console.WriteLine(arr[i]);
            //}
            //// or we can use foreach loop
            //foreach (var item in arr)
            //{
            //    System.Console.WriteLine(item);
            //}
            //// we also have Rank property to get the number of dimensions in the array
            //System.Console.WriteLine(arr.Rank);
            #endregion

            #region TwoDArrRect
            //// Array of arrays 
            //// 1. Rectangle means that all elements in the array have the same length
            //// it is formed into rows and columns
            //int[,] Marks = new int[3, 3];
            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Marks.GetLength(1); j++)
            //    {
            //        System.Console.WriteLine("Enter Marks for Student " + (i + 1) + " in Subject " + (j + 1));
            //        Marks[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Marks.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Marks for Student " + (i + 1) + " in Subject " + (j + 1) + " is " + Marks[i, j]);
            //    }
            //}


            #endregion

            #region TwoDArrJagged
            //// 2. Jagged means that all elements in the array have different length
            //int[][] nums = new int[3][];
            //nums[0] = new int[2];
            //nums[0] = new int[3];
            //nums[0] = new int[6];
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < nums[i].Length; j++)
            //    {
            //        System.Console.WriteLine("Enter Marks for Student " + (i + 1) + " in Subject " + (j + 1));
            //        nums[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}
            #endregion

            #region Function Prototype and stack frame
            //// Functions : A function is a block of code that performs a specific task
            //// Need to be called with its name
            //// DRY 

            //// Function Prototype
            //// 1. Signature
            //// 1.1 Name
            //// 1.2 Return Type
            //// 1.3 Parameters
            //// 2. Body

            //// Methods
            //// 1. Class member method (Static method) we want to call it with class name directly
            //// 2. Object member method
            //PrintShape();

            //// parameters can be passed by order or by their name

            //// Every function has stack frame allocated in memory 
            //// the stack frame holds the local variables, parameters, return address, and the state of the function
            //SumNumber(10, 20); // stack frame here will hold n1=10, n2=20, return address, and the state of the function

            //// after executing function the stack frame will be removed from the stack

            #endregion

            #region Passing By Refernce and Value
            //// Passing by value
            //int a=10, b = 20;
            //SwapNums(a,b); // a=10, b=20
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //// Passing by reference
            //int[] nums = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(SumArray(nums));
            //Console.WriteLine(nums[0]);
            #endregion

            #region Passing by out
            int sum, mul;
            SumMul(2, 6,out sum, out mul);
            Console.WriteLine(sum);
            Console.WriteLine(mul);
            #endregion

        }
    }
}

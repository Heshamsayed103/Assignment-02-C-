namespace Assignment_02_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q"1 Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            #region 1-Passing By Value
            static void Swap(int x, int y)
            {
                int temp = x;
                x = y;
                y = temp;
                
            }


            #endregion

            #region 2-Passing By Reference
            //static void SwapRef(ref int x, ref int y)
            //{
            //    int temp = x;
            //    x = y;
            //    y = temp;
            //}
            #endregion

            #endregion

            #region Q"2 Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example

            #region 1-Passing By Value
            //static void Func1(int[] arr)
            //{
            //    if (arr == null)
            //    {
            //        return;
            //    }
            //    arr[0] = 100;
            //    arr = new int[] { 4, 5, 6, 7 };
            //}
            #endregion

            #region 2-Passing By Reference
            //static void Func2(ref int[] arr)
            //{
            //    if (arr == null)
            //    {
            //        return;
            //    }
            //    arr[0] = 100;
            //    arr = new int[] { 4, 5, 6, 7 };
            //}
            #endregion

            #endregion

            #region Q"3 Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //static void Sum_Sub(int n1, int n2, out int sum, out int sub)
            //{
            //    sum = n1 + n2;
            //    sub = n1 - n2;
            //}

            //int a = 12, b = 5, s, sub;
            //Sum_Sub(a, b, out s, out sub); Console.WriteLine($"Sum = {s}, Sub = {sub}");


            #endregion

            #region Q"4 Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //static int SumOfDigit(int n)
            //{
            //    int sum = 0;
            //    while (n != 0)
            //    {
            //        sum += n % 10;
            //        n /= 10;

            //    }
            //    return sum;
            //}
            //Console.WriteLine(SumOfDigit(12345));

            #endregion

            #region Q"5 Create a function named "IsPrime", which receives an integer number and returns true if it is prime, or false if it is not:
            //static bool IsPrime(int n)
            //{
            //    if (n < 2)
            //        return false;
            //    for (int i = 2; i < n; i++)
            //    {
            //        if (n % i == 0)
            //        {
            //            return false;
            //        }
            //    }
            //    return true;
            //}

            //Console.WriteLine(IsPrime(7));

            #endregion

            #region Q"6 Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //static void MinMaxArray(int[] arr, ref int max, ref int min)
            //{
            //    if (arr is null)
            //        return;
            //    max = arr[0];
            //    min = arr[0];

            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (max < arr[i])
            //            max = arr[i];
            //        else if (min > arr[i])
            //            min = arr[i];
            //    }
            //}

            //int[] arr = { 5, 9, 2, 11, 3 };
            //int max = 0, min = 0;
            //MinMaxArray(arr, ref max, ref min);
            //Console.WriteLine($"Max = {max}, Min = {min}");



            #endregion

            #region Q"7 Create function to calculate the factorial of the number specified as parameter
            //static long factorial(int num)
            //{
            //    int result = 1;
            //    for (int i = 1; i <= num; i++)
            //    {
            //        result *= i;
            //    }
            //    return result;
            //}
            //Console.WriteLine(factorial(5));

            #endregion

            #region Q"8 Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

            //static string ChangeChar(string text, int index, char ch)
            //{
            //    text = text.Remove(index, 1);
            //    text = text.Insert(index, ch.ToString());
            //    return text;

            //}
            //Console.WriteLine(ChangeChar("hello", 1, 'a'));


            #endregion


            #region Q"9 Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //static void PrintIdentityMatrix(int n)
            //{
            //    for (int i = 0; i < n; i++)
            //    {
            //        for (int j = 0; j < n; j++)
            //        {
            //            if (i == j)
            //                Console.Write("1 ");
            //            else
            //                Console.Write("0 ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //PrintIdentityMatrix(4); 

            #endregion

            #region Q"10 Write a program in C# Sharp to find the sum of all elements of the array.
            //static int SumArray(int[] arr)
            //{
            //    int sum = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        sum += arr[i];
            //    }
            //    return sum;
            //}
            //Console.WriteLine(SumArray(new int[] { 1, 2, 3, 4, 5 }));

            #endregion

            #region Q"11 Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //static int[] MergeAndSortArrays(int[] arr1, int[] arr2)
            //{
            //    int[] merged = new int[arr1.Length + arr2.Length];
            //    arr1.CopyTo(merged, 0);
            //    arr2.CopyTo(merged, arr1.Length);
            //    Array.Sort(merged);
            //    return merged;
            //}

            //int[] result = MergeAndSortArrays(new int[] { 3, 1, 5 }, new int[] { 4, 2, 6 });
            //Console.WriteLine(string.Join(" ", result));

            #endregion

            #region Q"12 Write a program in C# Sharp to find maximum and minimum element in an array
            //static void FindMinMax(int[] arr, out int max, out int min)
            //{
            //    max = arr[0];
            //    min = arr[0];
            //    for (int i = 1; i < arr.Length; i++)
            //    {
            //        if (arr[i] > max)
            //            max = arr[i];
            //        else if (arr[i] < min)
            //            min = arr[i];
            //    }
            //}
            //int max, min;
            //FindMinMax(new int[] { 4, 7, 1, 9, 3 }, out max, out min);
            //Console.WriteLine($"Max = {max}, Min = {min}");

            #endregion

            #region Q"13 Write a program in C# Sharp to find the second largest element in an array.
            //static int SecondLargest(int[] arr)
            //{
            //    int max = int.MinValue;
            //    int secondMax = int.MinValue;

            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] > max)
            //        {
            //            secondMax = max;
            //            max = arr[i];
            //        }
            //        else if (arr[i] > secondMax && arr[i] != max)
            //        {
            //            secondMax = arr[i];
            //        }
            //    }

            //    return secondMax;
            //}
            //Console.WriteLine(SecondLargest(new int[] { 10, 20, 5, 8, 20, 15 }));

            #endregion


            #region Q"14 Consider an Array of Integer values with size N...
            //static int LongestDistance(int[] arr)
            //{
            //    Dictionary<int, int> firstIndex = new Dictionary<int, int>();
            //    int maxDistance = 0;

            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (firstIndex.ContainsKey(arr[i]))
            //        {
            //            int distance = i - firstIndex[arr[i]];
            //            if (distance > maxDistance)
            //                maxDistance = distance;
            //        }
            //        else
            //        {
            //            firstIndex[arr[i]] = i;
            //        }
            //    }
            //    return maxDistance;
            //}

            //int[] arr = { 7, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };
            //Console.WriteLine(LongestDistance(arr));         //8

            #endregion


            #region Q"15 Given a list of space separated words, reverse the order of the words
            //static void ReverseWords(string input)
            //{
            //    string[] words = input.Split(' ');
            //    Array.Reverse(words);
            //    Console.WriteLine(string.Join(" ", words));
            //}

            //ReverseWords("this is a test");            //test a is this


            #endregion


            #region Q"16 Write a program to create two multidimensional arrays of same size. Accept values from the user and store them in first array. Now copy all the elements of the first array on second array and print second array.
            //static void Copy2DArrays(int rows, int cols)
            //{
            //    int[,] arr1 = new int[rows, cols];
            //    int[,] arr2 = new int[rows, cols];

            //    Console.WriteLine("Enter values for the first array:");
            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < cols; j++)
            //        {
            //            Console.Write($"Element [{i},{j}]: ");
            //            arr1[i, j] = int.Parse(Console.ReadLine());
            //        }
            //    }


            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < cols; j++)
            //        {
            //            arr2[i, j] = arr1[i, j];
            //        }
            //    }


            //    Console.WriteLine("Second array:");
            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < cols; j++)
            //        {
            //            Console.Write(arr2[i, j] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //Copy2DArrays(2, 3);

            #endregion


            #region Q"17 Write a Program to Print One Dimensional Array in Reverse Order
            //static void PrintArrayReversed(int[] arr)
            //{
            //    for (int i = arr.Length - 1; i >= 0; i--)
            //    {
            //        Console.Write(arr[i] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //PrintArrayReversed(new int[] { 1, 2, 3, 4, 5 });

            #endregion




















        }
    }
}

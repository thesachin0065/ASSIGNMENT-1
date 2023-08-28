//1. Write a C# program to find the sum of all elements in an integer array using a loop.

using System;
using System.Collections.Generic;

namespace Inputoutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}



// 2. Create a C# program that calculates the average of values in a floating-point array using a loop
using System;

namespace Inputoutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] arr = { 1, 2, 3, 4 };
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            double avg = (sum * 1.0) / arr.Length;
            Console.WriteLine(avg);
        }
    }
}



// 3. Develop a C# program that finds the largest element in an integer array using a loop and if-else statements.

using System;
using System.Security.Cryptography;

namespace Inputoutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 8, 44, 67, 12, 90 };
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}



// 4.  Write a C# program that counts the number of even and odd elements in an integer array using a loop and if-else statements.

using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Inputoutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 8, 44, 67, 12, 90 };
            int max = arr[0];
            int even = 0, odd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] & 1) == 1)
                {
                    odd++;
                }
                else { even++; }
            }
            Console.WriteLine("Number of odd numbers = " + odd + " and even numbers = " + even);
        }
    }
}

// 5. Implement a C# program that reverses the elements of an integer array using a loop.


using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Inputoutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 8, 44, 67, 12, 90 };
            int l = 0, r = arr.Length - 1;
            while (l < r)
            {
                int temp = arr[l];
                arr[l] = arr[r];
                arr[r] = temp;
                l++;
                r--;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                Console.ReadLine();
            }
        }
    }
}


// 6. Create a C# program that multiplies each element in an integer array by a specified factor using a loop.



using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Inputoutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 8, 44, 67, 12, 90 };
            int mult = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * mult;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                Console.ReadLine();
            }
        }
    }
}


// 7. Write a C# program that searches for a specific value in an integer array using a loop and returns its index if found.



using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Inputoutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 8, 44, 67, 12, 90 };
            int search = Convert.ToInt32(Console.ReadLine());
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == search)
                {
                    index = i; break;
                }

            }
            Console.WriteLine(index);
            Console.ReadLine();
        }
    }
}



// 8. Develop a C# program that finds the second smallest element in an integer array using loops and sorting techniques.


using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Inputoutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 8, 44, 67, 12, 7 };
            int min = arr[0], min1 = arr[arr.Length - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine(min);
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] != min)
                {
                    if (arr[j] < min1)
                    {
                        min1 = arr[j];
                    }
                }
            }
            Console.WriteLine(min1);
            Console.ReadLine();
        }
    }
}



// 9. Create a C# program that removes all duplicates from an integer array using loops and additional data structures


using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 2, 3, 4, 4, 5, 6, 6, 7 };
        int[] uniqueNumbers = RemoveDuplicates(numbers);

        Console.WriteLine("Original Array: " + string.Join(", ", numbers));
        Console.WriteLine("Array with Duplicates Removed: " + string.Join(", ", uniqueNumbers));
    }

    static int[] RemoveDuplicates(int[] arr)
    {
        HashSet<int> uniqueSet = new HashSet<int>();
        List<int> result = new List<int>();

        foreach (int num in arr)
        {
            if (!uniqueSet.Contains(num))
            {
                uniqueSet.Add(num);
                result.Add(num);
            }
        }

        return result.ToArray();
        Console.ReadLine();
    }
}



// 10. Write a C# program that finds the common elements between two integer arrays using loops


using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 3, 4, 5, 6, 7 };

        int[] commonElements = FindCommonElements(array1, array2);

        Console.WriteLine("Common Elements: " + string.Join(", ", commonElements));
    }

    static int[] FindCommonElements(int[] arr1, int[] arr2)
    {
        System.Collections.Generic.List<int> commonElementsList = new System.Collections.Generic.List<int>();
        foreach (int num1 in arr1)
        {
            foreach (int num2 in arr2)
            {
                if (num1 == num2)
                {
                    if (!commonElementsList.Contains(num1))
                    {
                        commonElementsList.Add(num1);
                    }
                    break;
                }
            }
        }
        return commonElementsList.ToArray();
        Console.ReadLine();

    }
}

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = findTheFirstAndLastOccurrence(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9}, 5, true);
            int last = findTheFirstAndLastOccurrence(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9}, 5, false);
            Console.WriteLine($"First occurrence: {first}, Last occurrence: {last}");
        }

        public static int findTheFirstAndLastOccurrence(int[] arr, int target, bool findFirst)
        {
            int low = 0;
            int high = arr.Length - 1;
            int result = -1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (arr[mid] == target)
                {
                    result = mid;

                    if (findFirst)
                    {
                        high = mid - 1; // Continue searching in the left half
                    }
                    else
                    {
                        low = mid + 1; // Continue searching in the right half
                    }
                }
                else if (arr[mid] < target)
                {
                    low = mid + 1; // Search in the right half
                }
                else
                {
                    high = mid - 1; // Search in the left half
                }
            }

            return result;
        }
    }
}


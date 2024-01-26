namespace Debugging
{
    internal class Program
    {
        /*	Program name: Programming 2: Debugging Lecture
       Created by: Meghrig Terzian 
       Date:26/01/2024
       Code for Lab 2 to Reinforce debugging */
        static void Main(string[] args)
        {

            int[] numbers = new int[] { 6, 4, 3, 1, 7, 2, 10 };

            //Calling GetSmallests to get the 3 smallest numbers

            int[] smallests = GetSmallests(numbers, 3);

            //Printing the smallest elements 

            PrintArray("Smallest numbers:", smallests);

        }

        // GetSmallests takes an integer array and an integer and returns an integer array with the count smallest elements
        static int[] GetSmallests(int[] array, int count)
        {
            int[] smallests = new int[count];

            for (int i = 0; i < count; i++)
            {
                int minIndex = GetSmallestIndex(array);
                smallests[i] = array[minIndex];
                array[minIndex] = int.MaxValue;
            }

            return smallests;

        }

        // GetSmallestIndex takes an integer array and returns the index of the smallest element
        static int GetSmallestIndex(int[] array)
        {
            //Assume the first element is the smallest
            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[minIndex])
                    minIndex = i;
            }
            return minIndex;
        }

        // PrintArray takes a string and an int array and prints the string and the array elements
        static void PrintArray(string listName, int[] array)
        {

            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);

        }
    }
}
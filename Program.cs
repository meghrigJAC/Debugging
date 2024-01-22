namespace Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 6, 4, 3, 1, 7, 2, 10 };

            //Getting the 3 smallest numbers

            int[] smallests = GetSmallests(numbers, 3);

            PrintArray("Smallest numbers:", smallests);

        }

        static int[] GetSmallests(int[] array, int count)
        {
            int[] smallests = new int[count];

            for(int i=0;i< count; i++)
            {
                int minIndex = GetSmallestIndex(array);
                smallests[i] = array[minIndex];
                array[minIndex] = int.MaxValue;
            }

            return smallests;

        }

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

        static void PrintArray(string listName, int[] array)
        {
           
            for (int i=0; i<array.Length;i++)
                Console.WriteLine(array[i]);

        }
    }
}
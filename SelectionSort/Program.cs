using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Define array and fill it with random numbers
                Random number = new Random();

                int[] inputArray1 = new int[10];

                for (int i = 0; i < 10; i++)
                {
                    inputArray1[i] = number.Next(-100, 100);
                }

                Console.WriteLine("Array: " + string.Join(" ", inputArray1) + "\n");
                selectionSort(inputArray1);
                Lines("-", 100);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            //Hold console
            Console.Read();
        }

        private static void swap(int[] arr, int index1, int index2) //Swap values
        {
            Console.WriteLine(string.Join(" ", arr));
            var temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }

        private static int indexOfMinimum(int[] array, int startIndex)
        {
            int minValue = int.Parse(array[startIndex].ToString());
            int minIndex = int.Parse(startIndex.ToString());

            for (int i = minIndex; i < array.Length; i++)
            {
                if (int.Parse(array[i].ToString()) < minValue)
                {
                    minIndex = i;
                    minValue = int.Parse(array[i].ToString());
                }
            }

            return minIndex;
        }
        
        public static void selectionSort(int[] inputArray)
        {
            int x;

            Lines("/", 100);
            Console.WriteLine("\n//                            S E L E C T I O N      S O R T                                      //");
            Lines("/", 100);
            Console.Write("\n");

            for (int i = 0; i < inputArray.Length; i++)
                {
                      x = indexOfMinimum(inputArray, i);
                      swap(inputArray, i, x);
                }
        }

        public static void Lines(string sym, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.Write(sym);
            }
        }
    }
}

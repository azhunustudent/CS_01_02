namespace CS_01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Одномерный массив
            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            PrintArray(numbers);


            // 1) Найдем количество положительных чисел в массиве.
            Console.WriteLine("\n\nTask 1.");
            Console.WriteLine("Count: " + CountPositive(numbers));


            // 2) Инверсия массива, то есть переворот его в обратном порядке.
            Console.WriteLine("\nTask 2.");
            ReverseArray(numbers);
            PrintArray(numbers);
        }

        // ф-ция для печати массива
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        // ф-ция для вычисления кол-во положительных элементов в массиве
        public static int CountPositive(int[] arr)
        {
            int count = 0;
            foreach (var i in arr)
            {
                if (i > 0)
                    count++;
            }
            return count;
        }

        // ф-ция для инверсии массива 
        public static int[] ReverseArray(int[] arr)
        {
            int size = arr.Length;
            for (int i = 0; i < size / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[size - 1 - i];
                arr[size - 1 - i] = temp;
            }
            return arr;
        }
    }
}
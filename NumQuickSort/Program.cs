using System.ComponentModel.DataAnnotations;

namespace NumQuickSort
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number or 'stop' to end: ");
                var userInput = Console.ReadLine();
                if (userInput.Trim().ToLower() == "stop")
                {
                    break;
                }
                if (!int.TryParse(userInput, out int numUserInput))
                {
                    Console.WriteLine("This is not a number");
                    continue;
                }
                numbers.Add(numUserInput);
            }
            Console.WriteLine("The numbers you entered were... ");
            Console.WriteLine(string.Join(", ", numbers));

            QuickSort(numbers, 0, numbers.Count - 1);
            // Print the numbers in ascending order
            Console.WriteLine("Numbers in ascending order: " + string.Join(", ", numbers));

        }

        static List<int> QuickSort(List<int> arr, int low, int high)
        {
            if (low < high)
            {
                List<int> left = new List<int>();
                List<int> right = new List<int>();

                int pivot = arr[high];

                for (int i = low; i < high; i++)
                {
                    if (arr[i] <= pivot)
                    {
                        left.Add(arr[i]);
                    }
                    else
                    {
                        right.Add(arr[i]);
                    }
                }

                // Recursively sort the left and right parts of the pivot
                left = QuickSort(left, 0, left.Count - 1);
                right = QuickSort(right, 0, right.Count - 1);

                // Merge the left and right arrays back into the original array
                arr.Clear();
                arr.AddRange(left);
                arr.Add(pivot);
                arr.AddRange(right);
            }

            return arr;
        }
    }
}

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

        static void QuickSort(List<int> arr, int low, int high)
        {
            if (low < high)
            {
                //set pivot to the last field in array
                int pivot = arr[high];

                // set i to the left of lowest index
                int i = low - 1;

                //iterate the values, beginning with the left until the highest is reached
                for (int j = low; j < high; j++)
                {
                    //is the value at arr[j] lower than pivot?
                    if (arr[j] <= pivot)
                    {
                        //iterate i for the next iteration
                        i++;

                        //switch the values next to each other if i != j
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

                //set highest value
                int temp1 = arr[i + 1];
                arr[i + 1] = arr[high];
                arr[high] = temp1;

                int pivotIndex = i + 1;

                // Recursively sort the left and right parts of the pivot
                QuickSort(arr, low, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, high);
            }
        }
    }
}

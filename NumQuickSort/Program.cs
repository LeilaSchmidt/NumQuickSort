namespace NumQuickSort
{
    internal class Program
    {
        static int QuickSort(List<int> numbers)
        {
            List<int> biggerNumbers = new List<int>();
            List<int> smallerNumbers = new List<int>();
            if (numbers.Count == 1)
            {
                return numbers[0];
            }
            for (int j = 0; j < numbers.Count; j++)
            {
                int pivotPoint = numbers[numbers.Count - 1];
                for (int i = 0; i < pivotPoint; i++)
                {
                    if (numbers[i] < numbers[pivotPoint])
                    {
                        numbers[i] = smallerNumbers[i];
                    }
                    else
                    {
                        numbers[i] = biggerNumbers[i];
                    }
                }

            }
            return 0;
            Console.WriteLine("The numbers you entered were... ");
            Console.WriteLine(string.Join(", ", numbers));
        }
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

        }
    }
}
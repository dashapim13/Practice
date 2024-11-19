namespace Exercises
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    //Calling the static method directly
        //    //PrintFibonacci();


        //}
        //public static void PrintFibonacci()

        //{
        //    Console.WriteLine("Fibonacci numbers less than 21: ");

        //    int a = 0;   //First Fibonacci number 
        //    int b = 1;    //Second Fibonacci number

        //    //Print Fibonacci numbers using a while loop
        //    while (a < 21)
        //    { Console.WriteLine(a);

        //        //Calculate the next Fibonacci number

        //        int next = a + b;
        //        a = b;
        //        b = next;
        //    }
        //In class work
        //[1, 1, , 2, 3, , 5, , 8, 13, 21]
        //public static Fib(int num)
        //{
        //    int a = 1; Console.WriteLine(a);
        //    int b = 1; Console.WriteLine(b);
        //    int c = 0;
        //    while (c < num)
        //    {
        //        c = a + b; Console.WriteLine(c);
        //        a = b; b = c;
        //    }
        //}
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = TwoSum(nums, target);
            if (result.Length == 0)
            {
                Console.WriteLine("No two sum solution exists");
            }
            else
            {
                Console.WriteLine($"Indices: {result[0]}, {result[1]}");
            }
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            //Dictionary to store number and its index
            Dictionary<int, int> numMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                //Calculate the complement
                int complement = target - nums[i];

                //Check if the complement exists in the dictionary
                if (numMap.ContainsKey(complement))
                {
                    //Return the indices of the two numbers
                    return new int[] { numMap[complement], i };
                }
                //Add the current number and its index to the dictionary
                if (!numMap.ContainsKey(numMap[i]))
                {
                    numMap[nums[i]] = i;

                }
                //Return an empty array if no solution is found
                return new int[0];
            }


        }
    }
}




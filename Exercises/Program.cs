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
      
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = TwoSum(nums, target);

            Console.WriteLine($"Indices: {result[0]}, {result[1]}");

        }
        public static int[] TwoSum(int[] nums, int target)
        {
            //Dictionary to store number and its index
            Dictionary<int, int> numToIndex = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                //Find the complement
                int complement = target - nums[i];

                //Check if the complement exists in the dictionary
                if (numToIndex.ContainsKey(complement))
                {
                    //Return the indices of the two numbers
                    return new int[] { numToIndex[complement], i };
                }
                //Store the current number and its index to the dictionary

                numToIndex[nums[i]] = i;
            }

            throw new ArgumentException("No solution found");




        }
    }
}





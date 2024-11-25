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


        // Two Sum

        //static void Main(string[] args)
        //{
        //    int[] nums = { 2, 7, 11, 15 };
        //    int target = 9;
        //    int[] result = TwoSum(nums, target);

        //    Console.WriteLine($"Indices: {result[0]}, {result[1]}");

        //}
        //public static int[] TwoSum(int[] nums, int target)
        //{
        //    //Dictionary to store number and its index
        //    Dictionary<int, int> numToIndex = new Dictionary<int, int>();

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        //Find the complement
        //        int complement = target - nums[i];

        //        //Check if the complement exists in the dictionary
        //        if (numToIndex.ContainsKey(complement))
        //        {
        //            //Return the indices of the two numbers
        //            return new int[] { numToIndex[complement], i };
        //        }
        //        //Store the current number and its index to the dictionary

        //        numToIndex[nums[i]] = i;
        //    }

        //    throw new ArgumentException("No solution found");




        // Palindrome Number Math-Based Solution
        //static bool IsPalindrome(int x)
        //{
        //    //Negative numbers cannot be palindromes
        //    if (x < 0) return false;

        //    //Initialize variables

        //    int original = x;
        //    int reversed = 0;
        //    //Reverse the number

        //    while (x > 0)
        //    {
        //        int lastDigit = x % 10;                   // Get the last digit
        //        reversed = reversed * 10 + lastDigit;     //Append it to reversed number
        //        x /= 10;                                  //Remove the last digit from the number
        //    }

        //    return original == reversed;                  // Check if the number is the same when reversed
        //}

        //static void Main(string[] args) 
        //{
        //    Console.WriteLine(IsPalindrome(121));    //Output: True
        //    Console.WriteLine(IsPalindrome(-121));   //Output: False
        //    Console.WriteLine(IsPalindrome(10));
        //}



        // Palindrome Number String-Based Solution
        static bool IsPalindrome(int x)
        {
            // Negative numbers cannot be palindromes
            if (x < 0) return false;

            //Convert the number to a string
            string original = x.ToString();
            
            //Reverse the string

            char[] charArray = original.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);

            //Check if the original and reversed strings are the same
            return original == reversed;
        }

        static void Main(string[] args)

        {
            Console.WriteLine(IsPalindrome(121));   //Output: True
            Console.WriteLine(IsPalindrome(-121));  //Output: False
            Console.WriteLine(IsPalindrome(10));    //Output: False
        }


    }
}






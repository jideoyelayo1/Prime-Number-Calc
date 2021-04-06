using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();

            Console.WriteLine("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            
            watch.Start();
            List<int> listOfNums = Range(1, n);
            
            List<int> listOfPrimes = primeNums(listOfNums);
            
            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            foreach (int i in listOfPrimes)
                Console.WriteLine(i);
            Console.WriteLine("the Number of primes is: " + listOfPrimes.Count.ToString());
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");



        }

        public static List<int> Range(int a, int b)
        {
            List<int> nums = new List<int>();
            for(int i = a; i  <= b;i++)
                nums.Add(i);
            return nums;
        }

        public static List<int> primeNums(List<int> nums)
        {
            List<int> ans = new List<int>();
            int prime = 0;
            int i;
            while (nums.Count > 1)
            {
                if (nums[1] == 1)
                    nums.RemoveAt(0);
                i = 0;
                prime = nums[1];
                ans.Add(nums[1]);
                while (i<nums.Count)
                {
                    if(nums[i]% prime == 0)
                        nums.RemoveAt(i);
                    i++;
                }

            }

            return ans;
        }
    }
}

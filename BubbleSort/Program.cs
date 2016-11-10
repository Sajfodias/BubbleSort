using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]nums = new int[10];
            int temp;

            Console.WriteLine("Input 10 elements: ");
            Console.WriteLine();

            for(int i=0; i<nums.Length; i++)
            {
                Console.Write("{0} element: ", i+1);
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("*************************************************");
            Console.WriteLine();

            for(int i=0; i<nums.Length-1; i++)
            {
                for(int j=i+1; j<nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted array: ");
            for(int i=0; i<nums.Length; i++)
            {
                Console.WriteLine("{0} element: {1}", i+1, nums[i]);
            }
            Console.ReadKey();
        }
    }
}

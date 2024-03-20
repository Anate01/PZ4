//////////////////////  1
namespace PZ4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums = new int[50];
            int k = 0;

            for (int i = 0; i < 50; i++)
            {
                nums[i] = k;
                k = k + 2;
            }

            foreach (int i in nums) 
            {
                Console.WriteLine("Element: " + i);
            }

        }
    }
}

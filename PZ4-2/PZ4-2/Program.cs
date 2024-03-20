//////////////////////////////  2
namespace PZ4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[50];
            Random rand = new Random();
            int count = 0;  // кількість парних чисел
            int k = 0;  // лічильник парних чисел

            for (int i = 0; i < 50; i++)
            {
                nums[i] = rand.Next(0, 100);
                if (nums[i] % 2 == 0) count++;
            }

            Console.WriteLine("Arrays include " + count + " pair numbers.");
            Console.Write("It's: ");

            if (count == 0) k = 0; 
            else k = 1; // якщо парних чисел не 0, то лічильник уже має мати значення 1 для коректної роботи програми

            foreach (var w in nums)
            {
                if (w % 2 == 0 && k != count) // виводимо парне число з комою, якщо воно не останнє парне число
                {
                    Console.Write(w + ", ");
                    k++;
                }
                else if (w % 2 == 0 && k == count) Console.Write(w + ". "); // виводимо парне число з крапкою, якщо воно останнє парне число

            }
            
            Console.WriteLine("   ");

        }
    }
}

/////////////////////////////////////// 3.1
namespace PZ4_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write text: ");

            string str = Console.ReadLine();
            char[] charArray = str.ToLower().ToCharArray();
            int count = 0;

            Console.Write("What symbol do you want to find? - ");
            string str2 = Console.ReadLine();
            char[] wanted = str2.ToCharArray();

            if (wanted.Length > 1) Console.WriteLine("Incorrect input");

            foreach (char i in charArray)
            {
                if (i == wanted[0]) count++;
            }

            Console.WriteLine("Text: ``" + str + "`` include: " + charArray.Length + " symbols.");
            Console.WriteLine("Text include: " + count + " " + wanted[0] + " symbols.");
        }
    }
}

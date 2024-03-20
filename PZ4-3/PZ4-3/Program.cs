////////////////////////////////  3
namespace PZ4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Write text: ");

            string str = Console.ReadLine();
            char[] charArray = str.ToCharArray();

            Console.WriteLine("Text: ``" + str + "`` include: " + charArray.Length + " symbols.");

        }
    }
}

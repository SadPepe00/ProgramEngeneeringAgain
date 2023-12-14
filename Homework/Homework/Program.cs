using System.Diagnostics;
namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wow Ferm's theorem is true");
            Debug.Assert(1 == 1);
            Debug.Assert('a'=='a');
        }
    }
}
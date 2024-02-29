namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prompt for and fet number of squares to print
            Console.Write("Enter number of squares to print (0-10):");
            int n = int.Parse(Console.ReadLine());

            // print the numbers from 0 to n
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(i *2);
               
                Console.Write("Enter number of squares to print (1-10):");
                int n = int.Parse(Console.ReadLine());

                // print the squares from 1 to n
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}
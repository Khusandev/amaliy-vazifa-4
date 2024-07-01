namespace ConsoleApp14
{
    internal class Program

    {

        static void Main(string[] args)

        {
            Console.Write("N1  sonini kiriting: (input):");

            string N = Console.ReadLine();
            int N1 = Convert.ToInt32(N);
            Console.Write("Textni kiriting: (input):");
            string str = Console.ReadLine();
            string str2 = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str.Length < N1)
                {
                    if (str[i] > 'a')
                    { str2 += Convert.ToChar((str[i]) - ('a' - 'A')); }
                    else str2 += str[i];
                }
                else if (str.Length > N1)
                {
                    if (str[i] < 'a')
                    { str2 += Convert.ToChar((str[i]) + ('a' - 'A')); }
                    else str2 += str[i];
                }
            }
            Console.Write("Natija :");
            for (int i = 0; i < str2.Length; i++)
            {
                Console.Write(str2[i]);
            }
        }
    }
}
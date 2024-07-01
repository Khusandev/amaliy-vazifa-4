using System;

//String ustida amallar
//1) String tipida (string str) qiymat berilgan. Consoleda int tipidagi qiymat kiriting. Agar bu son str ning uzunligidan katta bo’lsa, str ni katta harflarga o’giring, aks holda kichik harflarga o’giring.
//Input: x = 13, str =”teLefOn”
//Output: “TELEFON”
//---------------
//Input: x = 4, str =”komPyuter”
//Output: “kompyuter”
///////////////////////////////////////////////////////////////////////////////////////////////////////
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


//2)Quyida ternary operator bilan ifodalandan qiymatni if-else yordamida ifodalang.
namespace ConsoleApp14
{
    internal class Program

    {

        static void Main(string[] args)

        {
            int x = 15;
            int y = 10;
            Console.Write("result :");
            if (x > y)
            {
                Console.WriteLine("x is greater then y");

            }
            else if (y > x)
            {
                Console.WriteLine("x is less then y");
            }
            else if (x == y)
            {
                Console.WriteLine("x is equal to y");
            }
            else Console.WriteLine("x and y are not comparable");
        }
    }
}


//3)Consoleda o’zbek tilida kiritilgan hafta kunini ingliz tiliga o’girib, natijani ekranga chiqaradigan dastur tuzing. Switch expression dan foydalaning!

namespace ConsoleApp14
{
    internal class Program

    {

        static void Main(string[] args)

        {
            Console.Write(" Hafta kunini kiriting :");
            string weekday = Console.ReadLine();
            string result = weekday switch
            {
                "Dushanba" => "Monday",
                "Seshanba" => "Thuesday",
                "Chorshanba" => "Wednesday",
                "Payshanba" => "Thursday",
                "Juma" => "Friday",
                "Shanba" => "Saturday",
                _ => "Sunday",
            };
            Console.Write("Natija:");
            Console.WriteLine(result);
        }
    }
}

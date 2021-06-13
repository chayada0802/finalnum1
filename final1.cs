using System;

namespace Final1
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int four = int.Parse(Console.ReadLine());
            int five = int.Parse(Console.ReadLine());
            int six = int.Parse(Console.ReadLine());
            int seven = int.Parse(Console.ReadLine());
            int eight = int.Parse(Console.ReadLine());
            int nine = int.Parse(Console.ReadLine());
            Console.WriteLine(one+" "+two+" "+three);
            Console.WriteLine(four+ " " + five + " " + six);
            Console.WriteLine(seven + " " + eight + " " + nine);
            int ten = int.Parse(Console.ReadLine());
            if(one==0)
            {
                one = ten;
                if(ten==two||ten==three||ten==four||ten==seven)
                {
                    Console.WriteLine("The number is available");

                }
            }
            if (two == 0)
            {
                two = ten;
                if (ten == one || ten == three || ten == five || ten == seven)
                {
                    Console.WriteLine("The number is available");

                }
            }
            if (three == 0)
            {
                three= ten;
                if (ten == one || ten == two || ten == six || ten == nine)
                {
                    Console.WriteLine("The number is available");

                }
            }
            if (four == 0)
            {
                four = ten;
                if (ten == one || ten == six || ten == five || ten == seven)
                {
                    Console.WriteLine("The number is available");

                }
            }
            if (five == 0)
            {
                five = ten;
                if (ten == four|| ten == six || ten == two || ten ==eight)
                {
                    Console.WriteLine("The number is available");

                }
            }
            if (six == 0)
            {
                six = ten;
                if (ten == four|| ten == three || ten == five || ten ==nine)
                {
                    Console.WriteLine("The number is available");

                }
            }
            if (seven == 0)
            {
                seven = ten;
                if (ten == one || ten == four || ten == eight || ten == nine)
                {
                    Console.WriteLine("The number is available");

                }
            }
            if (eight == 0)
            {
               eight = ten;
                if (ten == two || ten == nine || ten == five || ten == seven)
                {
                    Console.WriteLine("The number is available");

                }
            }
            if (nine == 0)
            {
               nine= ten;
                if (ten == six || ten == three || ten == eight || ten == seven)
                {
                    Console.WriteLine("The number is available");

                }
            }
            Console.WriteLine(one + " " + two + " " + three);
            Console.WriteLine(four + " " + five + " " + six);
            Console.WriteLine(seven + " " + eight + " " + nine);
        }
        }
    }


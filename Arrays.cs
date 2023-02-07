using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs
{
    internal class Arrays
    {
        static void Main(string[] args)
        {
            Console.Write("ввод строки - ");
            string line = Console.ReadLine();
            Console.WriteLine(line.ToUpper());
            Console.WriteLine(line.ToLower());
            int number = 1234;
            Console.WriteLine(number);
            string row = number.ToString();
            char[] array = row.ToCharArray();
            Array.Reverse(array);
            row = new String(array);
            number = Convert.ToInt32(row);
            Console.WriteLine(number);
            Console.Write("число=");
            number = Convert.ToInt32(Console.ReadLine());
            row = number.ToString();
            array = row.ToCharArray();
            Array.Reverse(array);
            row = new string(array);
            number = Convert.ToInt32(row);
            Console.WriteLine(number);
            int a = 3;
            int[][] massif = new int[4][];
            massif[0] = new int[3] { 3, 3, 3 };
            massif[1] = new int[4] { 4, 4, 4, 4 };
            massif[2] = new int[5] { 5, 5, 5, 5, 5 };
            massif[3] = new int[6] { 6, 6, 6, 6, 6, 6 };
            int x = 0;//начальное значение первого массива
            while(x < 4)
            {
                int y = 0;//начальное значение второго массива
                while (y < a)
                {
                    Console.Write(massif[x][y]);
                    y++;
                }
                Console.WriteLine();
                x++;
                a++;
            }
        }
    }
}

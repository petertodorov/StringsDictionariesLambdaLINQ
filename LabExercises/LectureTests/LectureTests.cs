using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class TriangleOfStars
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());

        Console.Write("*",input);
        Console.WriteLine();
        for (int row = 0; row < input-2; row++)
        {
            for (int col = 0; col <=row; col++)
            {
                Console.Write("*",row);
            }
            Console.WriteLine();
        }
        Console.Write("*", input);


    }
}

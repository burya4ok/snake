using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.GetEncoding(1251);

            HorizontalLine line = new HorizontalLine(3,10,4,'#');
            line.Draw();

            Console.ReadLine();
        }

    }
}

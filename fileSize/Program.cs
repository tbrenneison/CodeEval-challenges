using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileSize
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo info = new FileInfo(args[0]);

            long size = info.Length;

            Console.WriteLine(size);

        }
    }
}

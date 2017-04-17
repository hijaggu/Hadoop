using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Reducer
{
    public class Program
    {

        const int NOOFFIELDS = 5;

        public static void Main(string[] args)
        {

            string region = null;
            var count = 0L;

            var line = Console.ReadLine();

            while(line != null)
            {
                var parts = line.Split('\t');
                var key = parts[0];

                var value = long.Parse(parts[1]);

                if(key == region)
                {

                    count += value;
                }else
                {
                    if(region != null)
                    {
                        Console.WriteLine($"{region}\t{count}");
                    }

                    region = key;
                    count = value;

                }
                line = Console.ReadLine();

            }
            Console.WriteLine($"{region}\t{count}");

        }
    }
}

using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Mapper
{
    public class Program
    {

        const int NOOFFIELDS = 5;

        public static void Main(string[] args)
        {
            var line = Console.ReadLine();

            while(line != null)
            {
                using(var reader = new StringReader(line))
                using(var parser = new CsvParser(reader))
                {
                    var fields = parser.Read();
                    if(fields.Count() >= NOOFFIELDS)
                    {

                        Console.WriteLine($"{fields[NOOFFIELDS]}\t1");
                    }

                    line = Console.ReadLine();
                }


            }
        }
    }
}

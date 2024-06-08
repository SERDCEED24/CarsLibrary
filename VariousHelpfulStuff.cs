using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsLibrary
{
    public class VHS
    {
        public static int Input(string errorText, Predicate<int>? condition = null)
        {
            int x;
            string? buf;
            bool isConvert;
            do
            {
                buf = Console.ReadLine();
                isConvert = int.TryParse(buf, out x);
                if (condition != null)
                {
                    if (!condition(x))
                    {
                        isConvert = false;
                    }
                }
                if (!isConvert)
                {
                    Console.WriteLine(errorText);
                }
            } while (!isConvert);
            return x;
        }
    }
}

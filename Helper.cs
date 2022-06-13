using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method
{
    public static class Helper
    {
        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }

        public static bool IsDividedBy(this int i, int j)
        {
            return i % j == 0;
        }

        public static string ConvertToString<T>(this IEnumerable<T> collection)
        {
            var result = "";
            foreach (var item in collection)
            {
                result += item.ToString() + "\n";
            }
            return result;
        }

        public static Road CreateRandomRoad(this Road road, int min, int max)
        {
            var rnd = new Random(Guid.NewGuid().ToByteArray().Sum(x => x));
            road.Number = "M" + rnd.Next(1, 200);
            road.Length = rnd.Next(min, max);
            return road;
        }
       
    }
}

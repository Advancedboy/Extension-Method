using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IsEven
            //Console.WriteLine("Введите целое число: ");
            //var input = Console.ReadLine();
            //if (int.TryParse(input, out int result))
            //{
            //    //var isEven = IsEven(result);
            //    if (result.IsEven())
            //    {
            //        Console.WriteLine($"{result} - четное");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{result} - нечетное");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Введенное значение некорректно.");
            //}

            //int i = 101212;
            //Console.WriteLine(i.IsEven());
            #endregion

            #region IsDivivdedBy
            //int h = 123;
            //int v = 121;
            //Console.WriteLine(h.IsDividedBy(v));
            //Console.WriteLine(180.IsDividedBy(10));
            #endregion

            #region Road
            var list = new List<Road>();
            var roads = new List<Road>();
            for (int i = 0; i < 10; i++)
            {
                var road = new Road();
                road.CreateRandomRoad(1000, 10000);
                roads.Add(road);
            }

            var roadsName = roads.ConvertToString();
            Console.WriteLine(roadsName);
            #endregion
            Console.ReadLine();        
        }
    }
}

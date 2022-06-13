using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method
{
    public sealed class Road
    {
        public string Number { get; set; }
        public float Length { get; set; }

        public override string ToString()
        {
            return $"Дорога {Number} общей протяженностью {Length} миль.";
        }
    }
}

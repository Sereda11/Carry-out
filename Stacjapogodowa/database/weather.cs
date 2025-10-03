using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database
{
    public class weather
    {
        public int id; {  get; set; }
        public string MeasureBy { get; set; } = string.Empty;
        public  DateTime MeasurementBase { get; set; }
    }
}

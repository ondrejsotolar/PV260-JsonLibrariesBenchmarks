using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonBenchmark.TestDTOs
{
    public class Account
    {
        public string id { get; set; }
        public int index { get; set; }
        public string guid { get; set; }
        public bool isActive { get; set; }
        public double balance { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignment
{
    internal class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Food { get; set; }
        public string Sound { get; set; }
        public string Enclosure { get; set; }
        public List<string> Features { get; set; }
    }
}

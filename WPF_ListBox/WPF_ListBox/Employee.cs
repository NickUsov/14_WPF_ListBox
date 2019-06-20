using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_ListBox
{
    public class Employee
    {
        public string Name { get; set; }
        public string Birth { get; set; }
        public string Rank { get; set; }
        public override string ToString()
        {
            return $"{Name} {Birth} {Rank}";
        }
    }
}

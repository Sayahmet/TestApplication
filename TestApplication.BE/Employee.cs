using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.BE
{
    public class Employee
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronomyc { get; set; }
        public int Birthday { get; set; }
        public string Position { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Computer
    {
        public string Address { get; set; }
        public List<string> Users { get; set; }
        public string FailureMode { get; set; }

        public Computer()
        {
            Users = new List<string>();

        }
    }
}

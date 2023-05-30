using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class ComputerList
    {
        private List<Computer> computers;

        public ComputerList()
        {
            computers = new List<Computer>();
        }

        public void AddComputer(Computer computer)
        {
            computers.Add(computer);
        }

        public List<string> GetUsersByFailureMode(string failureMode)
        {
            List<string> users = new List<string>();

            foreach (Computer computer in computers)
            {
                if (computer.FailureMode == failureMode)
                {
                    users.AddRange(computer.Users);
                }
            }

            return users;
        }
    }
}

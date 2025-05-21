using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal class Terrorist
    {
        string Name {  get; set; }
        int Rank;
        string Status;
        string[] Weapon;
        public int rank
        {
            get {  return Rank; }
            set
            {
                if (value < 1)
                {
                    Rank = 1;
                }else if (value > 5)
                {
                    Rank = 5;
                }
                else
                {
                    Rank = value;
                }
            }
        }

        public Terrorist(string name, int rank, string status, string[] weapon)
        {
            Name = name;
            Rank = rank;
            Status = status;
            Weapon = weapon;
        }
    }
}

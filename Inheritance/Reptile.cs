using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public int NumOfTeeth { get; set; }
        public bool IsVenemous { get; set; }
        public string Location { get; set; }
        public bool CanRegen { get; set; }
    }
}

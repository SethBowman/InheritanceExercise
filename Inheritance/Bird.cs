using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public bool CanFly { get; set; }
        public int WingSpan { get; set; }
        public string FeatherColor { get; set; }
        public bool IsPredator { get; set; }
    }
}

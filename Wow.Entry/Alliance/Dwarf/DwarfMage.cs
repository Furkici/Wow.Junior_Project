using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wow.Entry.Alliance.Dwarf
{
    public class DwarfMage :BPDwarf, IYetenek
        
    {
        
        public int Damage()
        {
            return 45;
        }

        public int Defance()
        {
            return 50;
        }

        public int Health()
        {
            return 400;
        }

        public int Magic()
        {
            return 90;
        }
    }
}

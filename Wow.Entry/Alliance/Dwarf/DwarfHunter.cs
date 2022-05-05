using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wow.Entry.Alliance.Dwarf;

namespace Wow.Entry.Alliance.Dwarf
{
    public class DwarfHunter : DwarfHunterBuilder
    {
       
        

        public override void Damage()
        {
           dhunter.Damage();
        }

        public override void Defance()
        {
            throw new NotImplementedException();
        }

        public override void Health()
        {
            throw new NotImplementedException();
        }

        public override void Magic()
        {
            throw new NotImplementedException();
        }
    }
}

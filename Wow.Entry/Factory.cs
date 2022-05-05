using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wow.Entry.Alliance.Dwarf;

namespace Wow.Entry
{
    public class Factory
    {
        public Askerwarrior dwarfmethod(FactoryDwarfwarrior fd)
        {
            Askerwarrior ma = null;
            switch (fd)
            {
                case FactoryDwarfwarrior.dwarfwarrior:
                    ma = new DwarfWarrior();
                    break;
                
            }
            return ma;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wow.Entry.Alliance.Dwarf;

namespace Wow.Entry
{
    public abstract class DwarfHunterBuilder
    {
        protected DwarfHunter dhunter;

        public DwarfHunter Dhunter
        {
            get { return dhunter; }
        }
        //Hasar
        public abstract void Damage();
        //Defans
        public abstract void Defance();
        //Can Puanı
        public abstract void Health();
        //Büyü(özel güç)
        public abstract void Magic();


    }
}

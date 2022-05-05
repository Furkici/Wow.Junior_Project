using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wow.Entry.Alliance.Dwarf
{
    public class DwarfWarrior:Askerwarrior,IYetenek
    {
        public string Name { get; set; }


        public override void askerwarrior()
        {
            Console.WriteLine("Gimli Atacked You!");
        }

        
        public int Damage()
        {
            return 50;

        }

        public int Defance()
        {
            return 60;

        }

        public int Health()
        {
            return 540;
        }

        public int Magic()
        {
            return 75;
        }
    }
}

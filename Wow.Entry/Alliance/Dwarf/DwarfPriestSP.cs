using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wow.Entry.Alliance.Dwarf
{
    public class DwarfPriestSP:IYetenek
    {
        //Sağlamasını almak için bu classın normal şekilde instance ı alınamıyor olması gerek örek= battlescreen e git çünkü halihazırda karakter seçimi kısmında bu sınıfın instance'ını aldık
        public string Name { get; set; }

        private DwarfPriestSP() { }

        private static DwarfPriestSP _context;

        public static DwarfPriestSP Context
        {
            get 
            {
                if(_context == null)
                {
                    _context = new DwarfPriestSP();
                }
                return _context;
            }
        }
        public string Message()
        {
            return "SP Patern Başarılı";
        }

        public int Damage()
        {
            return 20;
        }

        public int Defance()
        {
            return 80;
        }

        public int Magic()
        {
            return 80;
        }

        public int Health()
        {
            return 340;
        }
    }
}

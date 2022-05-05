using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wow.Entry.Alliance.NightElf
{
    public class NightElf
    {
        //Builder dizayn da inşa sonunda elde etmek istediğimiz savaşçımızdır.  night elf builder sınıfı tarafından üretilir.

        public int Damage { get; set; }
        public int Defance { get; set; }
        public int Health { get; set; }
        public override string ToString()
        {
            return " Hasar: " + Damage + " Defans: " + Defance + " Sağlık: " + Health;
        }

    }
}

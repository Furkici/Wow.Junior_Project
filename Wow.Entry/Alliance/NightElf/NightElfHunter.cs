using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wow.Entry.Alliance.NightElf
{
    public class NightElfHunter : NightElfBuilder
    {
        //Burada night elf hunter savaşçımızı oluşturmak istediğimizde özünden yani(nightelf) klasından instance alınmasını tetikliyoruz
        public NightElfHunter()
        {
            nightelf = new NightElf();
        }
        public override void Damage()
        {
            nightelf.Damage = 56;
        }

        public override void Defance()
        {
            nightelf.Defance = 60;
        }

        public override void Health()
        {
            nightelf.Health = 600;
        }
    }
}

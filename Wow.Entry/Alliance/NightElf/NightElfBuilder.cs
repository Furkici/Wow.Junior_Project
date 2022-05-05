using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wow.Entry.Alliance.NightElf
{
    public abstract class NightElfBuilder
    {
        //Gördüğünüz gibi diğer classta NightElf ismini verdiğimiz nesneyi oluşturmaktadır. Oluşturulacak Savaşçınıın temel özelliklerini sağlayan sınıftır.
        protected NightElf nightelf;

        public NightElf Nightelf
        {
            get { return nightelf; }
        }

        //Damage
        public abstract void Damage();

        //Defance
        public abstract void Defance();
        //Health
        public abstract void Health();

    }
}

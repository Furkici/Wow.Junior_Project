using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wow.Entry.Alliance.Dwarf;

namespace Wow.Entry
{
    public partial class BattleScreen : Form
    {
        public BattleScreen()
        {
            InitializeComponent();
        }

        private void BattleScreen_Load(object sender, EventArgs e)
        {
            

        }
        private void btnSaldırı_Click(object sender, EventArgs e)
        {
            Factory factory = new Factory();
            Askerwarrior warrior = factory.dwarfmethod(FactoryDwarfwarrior.dwarfwarrior);
            warrior.askerwarrior();

            Console.Read();
            
            

            //DwarfWarrior warrior = new DwarfWarrior();
            //Random rnd = new Random();
            //int damage = rnd.Next(38, 50);
            //damage = warrior.Damage();
            //warrior.Name = " Gimli ";
            //lblBattle.Text = " Health: " + warrior.Health().ToString() + " Damage: " + damage.ToString();
            btnSaldırı.Visible = false;
            btnSaldırı2.Visible=true;

            



        }

        private void btnSaldırı2_Click(object sender, EventArgs e)
        {
            btnSaldırı2.Visible = false;
            btnSaldırı.Visible=true;
        }
    }
}

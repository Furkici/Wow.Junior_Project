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
    public partial class SelectCharacterAlliance : Form 
    {
        public SelectCharacterAlliance()
        {
            InitializeComponent();
        }
        
        private void SelectCharacterAlliance_Load(object sender, EventArgs e)
        {
            this.Width = 1330;
            this.Height = 800;

        }
        public void ResimDegistir(Image resim)
        {
            pbDwarfWarrior.Image = resim;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if(rbDwarfWarrior.Checked==true)
            {
                PictureBox pictureBox = new PictureBox();

                BattleScreen battleScreen = new BattleScreen();
                battleScreen.pbBattle = pbDwarfWarrior;
                
                
                battleScreen.Show();
                this.Hide();


            }
            
        }
        
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

            DwarfWarrior dwarfWarrior = new DwarfWarrior();

            
             dwarfWarrior.Name= "Gimli";
          
            //Burası Gerekli Değil!!!! çünkü foreachle zaten metotlarımızı çağırdığımızda labelda görebiliyoruz
            //dwarfWarrior.Damage();
            //dwarfWarrior.Defance();
            //dwarfWarrior.Blok();
            //dwarfWarrior.Health();
            
            List<DwarfWarrior> dw = new List<DwarfWarrior>();
            dw.Add(dwarfWarrior);
            
                foreach (DwarfWarrior dwarf in dw)
                {
                lblDescription.Text = "         Name:" + dwarfWarrior.Name + "                " +
                "Health:" + dwarfWarrior.Health().ToString()+ "   " + 
                    "Damage:" + dwarfWarrior.Damage().ToString() +  "  " +
                    "Defance:"+dwarfWarrior.Defance().ToString() + "  " +
                    "Magic Power:"+ dwarfWarrior.Magic().ToString(); 
                   
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorldSelection ws = new WorldSelection();
            ws.Show();
            this.Hide();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            List<DwarfPriestSP> dw = new List<DwarfPriestSP>();
            DwarfPriestSP dwarfPriestSP = DwarfPriestSP.Context;
            dwarfPriestSP.Name = "Gloin";
            
            string mesaj = dwarfPriestSP.Message();
            lblDescription.Text = mesaj;
            dw.Add(dwarfPriestSP);
            foreach(DwarfPriestSP dp in dw)
            {
                lblDescription.Text = "         Name: " + dwarfPriestSP.Name + "        "  +" Health: " + dwarfPriestSP.Health().ToString() + "Damage:" + dwarfPriestSP.Damage() + "Defance:" + dwarfPriestSP.Defance().ToString() + " Magic: " + dwarfPriestSP.Magic().ToString();





            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
           DwarfMage dwarfMage = new DwarfMage();

            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

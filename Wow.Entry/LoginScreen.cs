using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Wow.Entry
{
    public partial class LoginScreen : Form
    {
        
        public LoginScreen()
        {
            InitializeComponent();
        }
        
        private void LoginScreen_Load(object sender, EventArgs e)
        {
            lblHata.Visible = false;
            
            for(int i=0; i<3 ; i++)
            {
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\song.wav";
                ses.SoundLocation = dizin;
                ses.Play();
                
            }

            
            
            
            
            
            
            

            
            



        }
        

        private void btnEnterHorde_Click(object sender, EventArgs e)
        {
            //SoundPlayer sound = new SoundPlayer();
            //string dizin1 = Application.StartupPath + "\\MenuSound.wav";
            //sound.SoundLocation = dizin1;
            //sound.Play();
            
            UserAlliance alliance = new UserAlliance();
            string nickname = alliance.NickName = txtUserName.Text;
            
            string password = alliance.Password=txtPassword.Text;
            
                if (nickname =="" || password == "")
                {
                    lblHata.Visible = true;
                }
                else
                {
                    WorldSelection worldSelection = new WorldSelection();
                    worldSelection.Show();
                    this.Hide();
                }
            
            
               
            
            
            
            


             

            
                                  
                       
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wow.Entry
{
    public partial class SelectCharacterHorde : Form
    {
        public SelectCharacterHorde()
        {
            InitializeComponent();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorldSelection ws = new WorldSelection();
            ws.Show();
            this.Hide();
        }

        private void SelectCharacterHorde_Load(object sender, EventArgs e)
        {
            this.Width = 1330;
            this.Height = 800;
        }
    }
}

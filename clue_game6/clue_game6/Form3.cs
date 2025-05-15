using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clue_game6
{
    public partial class Form3 : Form
    {
        GameState gameState;
        Player player;
        int choose;
        public Form3(GameState G,Player p, int i)
        {
            InitializeComponent();
            player = p;
            choose = i;
            gameState = G;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(choose == 1)
            {
                player.clueBox[0] = manBox.Text;
                player.clueBox[1] = roomBox.Text;
                player.clueBox[2] = weaponBox.Text;
            }
            else if(choose == 2)
            {
                if (!(gameState.answer[0].name == manBox.Text && gameState.answer[1].name == weaponBox.Text && gameState.answer[2].name == roomBox.Text))
                    player.isAlive = false;
            }

            this.Close();
        }
    }
}

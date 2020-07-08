using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hang_Man_game
{
    public partial class Form2 : Form
    {
        public static string playerName;
        public Form2()
        {
            InitializeComponent();
        }

        private void Btn_start_Click(object sender, EventArgs e)
        {
            textBox_PlayerName.Text = playerName;
            this.Hide();
            GAMEFORM game = new GAMEFORM();
            game.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            GAMEFORM.quick = 3500;
            MessageBox.Show("Hint : the time will be ");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            GAMEFORM.quick = 2500;
            MessageBox.Show("Hint : the time will be ");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            GAMEFORM.quick = 1800;
            MessageBox.Show("Hint : the time will be ");

        }
    }
}

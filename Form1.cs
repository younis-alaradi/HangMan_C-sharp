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
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
        }

        private void Main_form_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HangMan Game ","Welcome to hangman game ", MessageBoxButtons.OK);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 level = new Form2();
            level.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Hang_Man_game
{
    public partial class GAMEFORM : Form
    {
        private Bitmap[] picture = {Properties.Resources.Hang_man_1, Hang_Man_game.Properties.Resources.Hang_man_2, Hang_Man_game.Properties.Resources.Hnag_man_3, Hang_Man_game.Properties.Resources.Hang_man_4,
        Hang_Man_game.Properties.Resources.Hang_man_5,Hang_Man_game.Properties.Resources.Hang_man_6,Hang_Man_game.Properties.Resources.Hang_man_7};
        private int wrongGuesses = 0;
        private string current = "";
        private string copyCurrent = "";
        private string[] words;
        public static int quick;
        public GAMEFORM()
        {
            InitializeComponent();
        }

        private void GAMEFORM_Load(object sender, EventArgs e)
        {
            loadwords();
            setupWordChoice();
            ID_Label.Text = Form2.playerName;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void loadwords()
        {
            char[] delimiterChars = { ',' };
            string[] readText = File.ReadAllLines("Words.txt");
            words = new string[readText.Length];
            int index = 0;
            foreach (string s in readText)
            {
                string[] line = s.Split(delimiterChars);
                words[index++] = line[1];
            }

        }
        private void setupWordChoice()
        {
            wrongGuesses = 0;
            hangMan.Image = picture[wrongGuesses];
            int guessIndex = (new Random()).Next(words.Length);
            current = words[guessIndex];
            copyCurrent = "";
            for (int index = 0; index < current.Length; index++)
            {
                copyCurrent += "_";
            }
            displayCopy();
        }
        private void displayCopy()
        {
            lblShowWord.Text = "";
            for (int index = 0; index < copyCurrent.Length; index++)
            {
                lblShowWord.Text += copyCurrent.Substring(index, 1);
                lblShowWord.Text += " ";
            }
        }
        private void guessClick(object sender, EventArgs e)
        {
            Button choise = sender as Button;
            choise.Enabled = false;
            if (current.Contains(choise.Text))
            {
                char[] temp = copyCurrent.ToCharArray();
                char[] find = current.ToCharArray();
                char guessChar = choise.Text.ElementAt(0);
                for (int index = 0; index < find.Length; index++)
                {
                    if (find[index] == guessChar)
                    {
                        temp[index] = guessChar;
                    }
                }
                copyCurrent = new string(temp);
                displayCopy();

            }
            else
            {
                wrongGuesses++;
            }

            if (wrongGuesses < 7)
            {
                hangMan.Image = picture[wrongGuesses];
            }
            else
            {
                MessageBox.Show("You lose !!", " Hangman Game ", MessageBoxButtons.OK);

          
               this.Hide();
                Main_form main = new  Main_form();
                main.Show();

            }
            if (copyCurrent.Equals(current))
            {
                MessageBox.Show("You win!!!", " Hangman Game ", MessageBoxButtons.OK);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            quick--;
            Time_label.Text= quick / 60 + "." + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));
            if (Time_label.Text == "0:00") 
            {
                timer1.Stop();
                Button sas = sender as Button ;
                sas.Enabled = false;
                MessageBox.Show("The time done ");
            }
        }
    }
}

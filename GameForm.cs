using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace e_TicTacToe
{
    public partial class GameForm : Form
    {
        private int nbPlayer;
        private char[,] tab = new char[3, 3]
        {
            {' ',' ',' '},
            {' ',' ',' '},
            {' ',' ',' '}
        };
        private bool tourJ1 = true;
        private int scorelabelJ1 =0;
        private int scorelabelJ2 =0;
        private int compteTour = 0;

        public GameForm(string j1, string j2, int nbJ)
        {
            InitializeComponent();
            nameJ1.Text = j1;
            nameJ2.Text = j2;
            this.nbPlayer = nbJ;
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button btn_number = (Button)sender;
            compteTour++;
            //btn_number.Text = "test";
            //MessageBox.Show(btn_number.Name);
            if (tourJ1)
            {
                if (btn_number.Text.Equals(""))
                {
                    btn_number.Text = "X";
                    switch (btn_number.Name)
                    {
                        case "btn_7": tab[0, 0] = 'X'; break;
                        case "btn_8": tab[0, 1] = 'X'; break;
                        case "btn_9": tab[0, 2] = 'X'; break;
                        case "btn_4": tab[1, 0] = 'X'; break;
                        case "btn_5": tab[1, 1] = 'X'; break;
                        case "btn_6": tab[1, 2] = 'X'; break;
                        case "btn_1": tab[2, 0] = 'X'; break;
                        case "btn_2": tab[2, 1] = 'X'; break;
                        case "btn_3": tab[2, 2] = 'X'; break;
                        default: break;
                    }
                    checkWinners();
                    turnJX.Text = "Au tour de : " + nameJ2.Text;                    
                    tourJ1 = false;
                }
            }
            else
            {
                if (btn_number.Text.Equals(""))
                {
                    btn_number.Text ="O";
                    switch (btn_number.Name)
                    {
                        case "btn_7": tab[0, 0] = 'O'; break;
                        case "btn_8": tab[0, 1] = 'O'; break;
                        case "btn_9": tab[0, 2] = 'O'; break;
                        case "btn_4": tab[1, 0] = 'O'; break;
                        case "btn_5": tab[1, 1] = 'O'; break;
                        case "btn_6": tab[1, 2] = 'O'; break;
                        case "btn_1": tab[2, 0] = 'O'; break;
                        case "btn_2": tab[2, 1] = 'O'; break;
                        case "btn_3": tab[2, 2] = 'O'; break;
                        default: break;
                    }
                    checkWinners();
                    turnJX.Text = "Au tour de : " + nameJ1.Text;
                    tourJ1 = true;
                }
            }            
        }
        public void checkWinners()
        {
            if (tab[0, 0] == 'X' && tab[0, 1] == 'X' && tab[0, 2] == 'X') playerXwin();
            if (tab[0, 0] == 'O' && tab[0, 1] == 'O' && tab[0, 2] == 'O') playerOwin();

            if (tab[1, 0] == 'X' && tab[1, 1] == 'X' && tab[1, 2] == 'X') playerXwin();
            if (tab[1, 0] == 'O' && tab[1, 1] == 'O' && tab[1, 2] == 'O') playerOwin();

            if (tab[2, 0] == 'X' && tab[2, 1] == 'X' && tab[2, 2] == 'X') playerXwin();
            if (tab[2, 0] == 'O' && tab[2, 1] == 'O' && tab[2, 2] == 'O') playerOwin();

            if (tab[0, 0] == 'X' && tab[1, 0] == 'X' && tab[2, 0] == 'X') playerXwin();
            if (tab[0, 0] == 'O' && tab[1, 0] == 'O' && tab[2, 0] == 'O') playerOwin();

            if (tab[0, 1] == 'X' && tab[1, 1] == 'X' && tab[2, 1] == 'X') playerXwin();
            if (tab[0, 1] == 'O' && tab[1, 1] == 'O' && tab[2, 1] == 'O') playerOwin();

            if (tab[0, 2] == 'X' && tab[1, 2] == 'X' && tab[2, 2] == 'X') playerXwin();
            if (tab[0, 2] == 'O' && tab[1, 2] == 'O' && tab[2, 2] == 'O') playerOwin();

            if (tab[0, 0] == 'X' && tab[1, 1] == 'X' && tab[2, 2] == 'X') playerXwin();
            if (tab[2, 0] == 'X' && tab[1, 1] == 'X' && tab[0, 2] == 'X') playerXwin();
            if (tab[0, 0] == 'O' && tab[1, 1] == 'O' && tab[2, 2] == 'O') playerOwin();
            if (tab[2, 0] == 'O' && tab[1, 1] == 'O' && tab[0, 2] == 'O') playerOwin();
            if (compteTour == 9)
            {
                MessageBox.Show("Egalité !!!");init();
            }
        }

        private void playerXwin()
        {
            MessageBox.Show(nameJ1.Text+ " gagne un point !");
            scorelabelJ1++;
            scoreJ1.Text = Convert.ToString(scorelabelJ1);
            tourJ1 = true;
            init();
        }
        private void playerOwin()
        {
            MessageBox.Show(nameJ2.Text + " gagne un point !");
            scorelabelJ2++;
            scoreJ2.Text = Convert.ToString(scorelabelJ2);
            tourJ1 = false;
            init();
        }

        private void init()
        {
            compteTour = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tab[i,j] = ' ';
                }
            }
            btn_7.Text = ""; btn_8.Text = ""; btn_9.Text = "";
            btn_4.Text = ""; btn_5.Text = ""; btn_6.Text = "";
            btn_1.Text = ""; btn_2.Text = ""; btn_3.Text = "";
        }
    }
}
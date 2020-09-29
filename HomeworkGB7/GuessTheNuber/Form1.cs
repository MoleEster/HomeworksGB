using System;
using System.Windows.Forms;

namespace GuessTheNuber
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent(); 


        }
        public void button1_Click(object sender, EventArgs e)
        {
                int userGuess = Convert.ToInt32(textBox1.Text);
                if (userGuess == Numeral)
                {
                    label1.Text = "Вы угадали число";
                }
                else 
                { 
                    Count++;
                    if (userGuess > Numeral)
                        label1.Text = "Возьмите меньше";
                    else { label1.Text = "Возьмите больше"; }
                lGuessCount.Text = $"Попытка №{Count}";
                }
            
        }
        public int Numeral { get; set; }
        public int Count { get; set; }

        public void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
             int Number = rnd.Next(1, 100);
            Count = 0;
            Numeral = Number;

        }
    }
}

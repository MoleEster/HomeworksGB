using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleUpper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text) + 1).ToString();
            Pushed = int.Parse(label1.Text) - 1;
            lCounter.Text = (int.Parse(lCounter.Text) + 1).ToString();
            if (int.Parse(label1.Text) == Number) lGame.Text = "Вы выиграли";
        }

        private void bMultiply_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text) * 2).ToString();
            Pushed = int.Parse(label1.Text) / 2;
            lCounter.Text = (int.Parse(lCounter.Text) + 1).ToString();
            if (int.Parse(label1.Text) == Number) lGame.Text = "Вы выиграли";
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            label1.Text = "1";

        }
        public int Number { get; set; }
        private void bPlay_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(100);
            Number = x;
            lGame.Text = $"Вам нужно получить число {x} за мнимальное количество попыток";

        }
        public int Pushed { get; set; }
        public int NewStack()
        {
            var stack = new Stack<int>();
            stack.Push(Pushed);
            return stack.Pop();
        }
        private void bCancel_Click(object sender, EventArgs e)
        {
            label1.Text =NewStack().ToString();
        }
    }
}

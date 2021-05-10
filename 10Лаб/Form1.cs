using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10Лаб
{
    public partial class Form1 : Form
    {
        Game brick_you = new Game();
        Game brick_comp = new Game();
        public Form1()
        {
            InitializeComponent();
        }

        private void Rule_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сначала разыгрывается число от 1 до 6 \nИгроки бросают кубики. Если на одном из кубиков появляется необходимое число — игрок получает одно очко. Когда число появляется сразу на двух костях, игрок получит два бала. \nЦель игры - набрать 10 очков. Тот игрок, кто первым наберет 10 очков, будет победителем.");
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            num.Value = brick_comp.Generate_number();
        }

        private void throw_cube_Click(object sender, EventArgs e)
        {
            int[] array = brick_you.GenerateForPlayer();
            your_brick1.Text = array[0].ToString();
            your_brick2.Text = array[1].ToString();
            array = brick_comp.GenerateForComputer();
            comp_brick1.Text = array[0].ToString();
            comp_brick2.Text = array[1].ToString();
            if ((num.Value == your_brick1.Value) & (num.Value == your_brick2.Value))
            {
                your_score.Value += 2;
            }
            else if ((num.Value == your_brick1.Value) | (num.Value == your_brick2.Value))
            {
                your_score.Value++;
            }
            if ((num.Value == comp_brick1.Value) & (num.Value == comp_brick2.Value))
            {
                comp_score.Value += 2;
            }
            else if ((num.Value == comp_brick1.Value) | (num.Value == comp_brick2.Value))
            {
                comp_score.Value++; 
            }
            if (your_score.Value >= 10)
            { 
                var results = MessageBox.Show("Вы победили\nСыграете еще раз?", "Победа!", MessageBoxButtons.YesNo);
                if (results == DialogResult.Yes)
                {
                    Clear();
                }
                
            }
            if (comp_score.Value >= 10)
            {
                var results = MessageBox.Show("Победил компьютер\nСыграете еще раз?", "Неудача(", MessageBoxButtons.YesNo);
                if (results == DialogResult.Yes)
                {
                    Clear();
                }

            }
        }
        private void Clear()
        {
            comp_score.Value = 0;
            your_score.Value = 0;
            num.Value = 0;
            comp_brick1.Value = 0;
            comp_brick2.Value = 0;
            your_brick1.Value = 0;
            your_brick2.Value = 0;
        }
    }
    public class Game
    {
        int[] number = new int[6] { 1, 2, 3, 4, 5, 6};
        Random rnd = new Random();
        int sumPlayer = 0;
        int sumComputer = 0;

        public int Generate_number()
        {
            decimal[] prob = new decimal[6] { 0.02m, 0.03m, 0.15m, 0.2m, 0.25m, 0.35m };
            decimal A;
            A = rnd.Next(0, 10);
            A /= 10;
            int k = -1;
            do
            {
                k++;
                A -= prob[k];
            } while (A >= 0.001M);
            return number[k];
        }
        public int[] GenerateForPlayer()
        {
            decimal[] prob = new decimal[6] { 0.16m, 0.16m, 0.17m, 0.17m, 0.17m, 0.17m };
            int[] array = new int[2];
            int k;
            decimal A;
            for (int i = 0; i < array.Length; i++)
            {
                A = (decimal)rnd.NextDouble();
                for (k = -1; A > 0; k++)
                {
                    A -= prob[k + 1];
                }
                array[i] = number[k];
            }
            return array;
        }
        public int[] GenerateForComputer()
        {
            decimal[] prob = new decimal[6] {0.05m, 0.05m, 0.15m, 0.2m, 0.25m, 0.3m};
            int[] array = new int[2];
            int k;
            decimal A;
            for (int i = 0; i < array.Length; i++)
            {
                A = (decimal)rnd.NextDouble();
                for (k = -1; A > 0; k++)
                {
                    A -= prob[k + 1];
                }
                array[i] = number[k];
            }
            return array;
        }
        public bool Score()
        {
            if (sumPlayer > sumComputer) return true;
            return false;
        }

    }
}

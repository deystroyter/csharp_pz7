using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeBtn
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            DISTANCE += buttonNo.Width/2;

        }
        public int i = 0;
        public int DISTANCE = 15;
        const int gameBorder = 10;
        private void buttonNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем! Вы смогли нажать кнопку!\nНо лаба не зачтена :(", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Лаба зачтена :)", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChangeLocation(int X, int Y, int eX, int eY)
        {
            label2.Text = "Xbtn: " + X + " | Ybtn: " + Y + "\\// eX: " +eX + " eY:" + eY ;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender.GetType() == (object)label1)
            {
                MessageBox.Show("Лаба зачтена :)", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            int centerX = buttonNo.Left + buttonNo.Width / 2;
            int centerY = buttonNo.Top + buttonNo.Height / 2;
            ChangeLocation(centerX, centerY, e.X, e.Y);
            bool Right = centerX + DISTANCE > e.X && centerX < e.X; //good
            bool Left = centerX - DISTANCE < e.X && centerX > e.X;
            bool Top = centerY - DISTANCE < e.Y && centerY > e.Y;
            bool Bottom = centerY + DISTANCE > e.Y && centerY < e.Y; //good

            bool RightTop = Right && Top;
            bool RightBottom = Right && Bottom;
            bool LeftTop = Left && Top;
            bool LeftBottom = Left && Bottom;

            //Первый подход
            if (i == 0 && (RightTop|| RightBottom || LeftTop || LeftBottom))
            {
                var tmpL = buttonNo.Left;
                var tmpT = buttonNo.Top;
                tableLayoutPanel1.Controls.Remove(buttonNo);
                buttonNo.Top = tmpT;
                buttonNo.Left = tmpL;
                this.Controls.Add(buttonNo);
                buttonNo.BringToFront();
                i++;
            }

            //Eсли подходит справа сверху
            if (RightTop)
            {
                if (e.Y + DISTANCE + buttonNo.Height + gameBorder > ClientSize.Height)
                    buttonNo.Top = e.Y - DISTANCE;
                else
                    buttonNo.Top = e.Y + DISTANCE;

                if (e.X - DISTANCE < 0)
                    buttonNo.Left = e.X + DISTANCE;
                else buttonNo.Left = e.X - DISTANCE;

            }
            //Если справа снизу
            else if (RightBottom) //good
            {
                if (e.Y - DISTANCE < 0)  //если выше
                    buttonNo.Top = e.Y + DISTANCE; //вниз
                else buttonNo.Top = e.Y - DISTANCE - 15; //вверх

                if (e.X - DISTANCE < 0) //если левее
                    buttonNo.Left = e.X + DISTANCE; //вправо
                else buttonNo.Left = e.X - DISTANCE - 15; //влево
            }
            //Если слева сверху
            else if (LeftTop)
            {
                if (e.Y + DISTANCE + buttonNo.Height + gameBorder > ClientSize.Height) //если ниже
                    buttonNo.Top = e.Y - DISTANCE; //вверх
                else buttonNo.Top = e.Y + DISTANCE; //вниз

                if (e.X + DISTANCE + buttonNo.Width + gameBorder > ClientSize.Width) //если правее
                    buttonNo.Left = e.X - DISTANCE; //влево
                else buttonNo.Left = e.X + DISTANCE; //вправо
            }
            //Если слева снизу
            else if (LeftBottom)
            {
                if (e.Y - DISTANCE < 0)
                    buttonNo.Top = e.Y + DISTANCE;
                else buttonNo.Top = e.Y - DISTANCE;

                if (e.X + DISTANCE + buttonNo.Width + gameBorder > ClientSize.Width)
                    buttonNo.Left = e.X - DISTANCE;
                else buttonNo.Left = e.X + DISTANCE;
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Random rand = new Random();
            buttonNo.Top = rand.Next(0, ClientSize.Height - gameBorder - buttonNo.Height);
            buttonNo.Left = rand.Next(0, ClientSize.Width - gameBorder - buttonNo.Width);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormAvianos
{
    public partial class FormAvianos : Form
    {
        private Aviaos motorShip;
        public FormAvianos()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxCars.Width, pictureBoxCars.Height);
            Graphics gr = Graphics.FromImage(bmp);
            motorShip.DrawShep(gr);
            pictureBoxCars.Image = bmp;
        }
        /// Обработка нажатия кнопки "Создать"
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            motorShip = new Aviaos(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Yellow, true, true, true, true, true, true);
            motorShip.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCars.Width, pictureBoxCars.Height);
            Draw();
        }
        /// Обработка нажатия кнопок управления
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    motorShip.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    motorShip.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    motorShip.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    motorShip.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}

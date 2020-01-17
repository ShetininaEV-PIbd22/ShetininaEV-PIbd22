using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAvianos
{
    public partial class FormAvianos : Form
    {
        private Avianos avianos;
        public FormAvianos()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAvianos.Width, pictureBoxAvianos.Height);
            Graphics gr = Graphics.FromImage(bmp);
            avianos.DrawShep(gr);
            pictureBoxAvianos.Image = bmp;
        }
        /// Обработка нажатия кнопки "Создать"
        private void buttonCreateAvianos_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            avianos = new Avianos(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Yellow, true, true, true, true, true, true);
            avianos.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxAvianos.Width, pictureBoxAvianos.Height);
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
                    avianos.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    avianos.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    avianos.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    avianos.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}

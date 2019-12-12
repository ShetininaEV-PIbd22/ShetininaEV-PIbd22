﻿using System;
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
        private ITransport _ship;
        public FormAvianos()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAvianos.Width, pictureBoxAvianos.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _ship.DrawShep(gr);
            pictureBoxAvianos.Image = bmp;
        }

        private void CreateShep_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            _ship = new Shep(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
            _ship.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxAvianos.Width, pictureBoxAvianos.Height);
            Draw();
        }
        private void CreateAvianos_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            _ship = new Avianos(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Yellow, true, true, true, Color.Black, true, true);
            _ship.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxAvianos.Width, pictureBoxAvianos.Height);
            Draw();
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    _ship.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    _ship.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    _ship.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    _ship.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}

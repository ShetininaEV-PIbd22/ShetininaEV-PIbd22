using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormAvianos
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
    class Shep : Vehicle
    {
        /// Ширина отрисовки автомобиля
        protected const int shepWidth = 100;
        /// Ширина отрисовки автомобиля
        protected const int shepHeight = 60;
        
        /// Конструктор
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        public Shep (int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        // Конструктор
        //info-Информация по объекту
        public Shep(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - shepWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - shepHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawShep(Graphics g)
        {
            Pen pen = new Pen(MainColor);
            Brush brush = new SolidBrush(MainColor);
            //палуба
            g.FillRectangle(brush, _startPosX, _startPosY, 60, 30);
            // нос
            g.DrawLine(pen, _startPosX + 60, _startPosY + 5, _startPosX + 75, _startPosY + 15);
            g.DrawLine(pen, _startPosX + 75, _startPosY + 15, _startPosX + 60, _startPosY + 25);
            //корма
            g.DrawLine(pen, _startPosX, _startPosY + 5, _startPosX - 10, _startPosY + 10);
            g.DrawLine(pen, _startPosX - 10, _startPosY + 10, _startPosX - 10, _startPosY + 20);
            g.DrawLine(pen, _startPosX - 10, _startPosY + 20, _startPosX, _startPosY + 25);
        }
        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }
    }
}

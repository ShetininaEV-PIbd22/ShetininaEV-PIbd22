using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppAvianos
{
    class Avianos
    {
        /// Левая координата отрисовки автомобиля
        private float _startPosX;
        /// Правая кооридната отрисовки автомобиля
        private float _startPosY;
        /// Ширина окна отрисовки
        private int _pictureWidth;
        /// Высота окна отрисовки
        private int _pictureHeight;
        /// Ширина отрисовки автомобиля
        private const int avWidth = 100;
        /// Ширина отрисовки автомобиля
        private const int avHeight = 60;
        /// Максимальная скорость
        public int MaxSpeed { private set; get; }
        /// Вес 
        public float Weight { private set; get; }
        /// Основной цвет 
        public Color MainColor { private set; get; }
        /// Дополнительный цвет
        public Color DopColor { private set; get; }
        /// Признак наличия переднего лифта
        public bool FirstLift { private set; get; }
        /// Признак наличия заднего лифтов
        public bool SecondLift { private set; get; }
        //признак наличия рубки
        public bool Rubka { private set; get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="firctLift">Признак наличия переднего лифта</param>
        /// <param name="secondLift">Признак наличия заднего лифта</param>
        public Avianos(int maxSpeed, float weight, Color mainColor, Color dopColor,
       bool frontSpoiler, bool sideSpoiler, bool backSpoiler,bool firstLift, bool secondLift, bool rubka)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            FirstLift = firstLift;
            Rubka = rubka;
            SecondLift = secondLift;
        }
        /// <summary>
        /// Установка позиции
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - avWidth)
                    {
                        _startPosX = _startPosX + step;
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
                    if (_startPosY + step < _pictureHeight - avHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        /// Отрисовка 
        public void DrawShep(Graphics g)
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
            if (FirstLift)
            {
                Brush lift = new SolidBrush(DopColor);
                g.FillRectangle(lift, _startPosX + 10, _startPosY + 10, 10, 10);
            }
            if (SecondLift)
            {
                Brush lift = new SolidBrush(DopColor);
                g.FillRectangle(lift, _startPosX + 40, _startPosY + 10, 10, 10);
            }
            if (Rubka)
            {
                Brush rubka = new SolidBrush(DopColor);
                g.FillRectangle(rubka, _startPosX+30, _startPosY+25, 5, 5);
            }
        }
    }
}

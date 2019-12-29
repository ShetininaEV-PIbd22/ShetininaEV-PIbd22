using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppAvianos
{
    class Avianos: Shep
    {
        public Color DopColor { private set; get; }
        // Признак наличия переднего лифтов
        public bool FirstLift { private set; get; }
        // Признак наличия заднего лифтов
        public bool SecondLift { private set; get; }
        //признак наличия рубки
        public bool Rubka { private set; get; }
        // Дополнительный цвет
        public Color DopColor_1 { private set; get; }
        // Признак наличия ор
        public bool Orudie { private set; get; }
        // признак разметки
        public bool Razmetka { private set; get; }

        // Конструктор
        public Avianos (int maxSpeed, float weight, Color mainColor, Color dopColor, bool firstLift, bool secondLift, bool rubka, Color dopColor_1, bool orudie, bool razmetka) :
            base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            FirstLift = firstLift;
            SecondLift = secondLift;
            Rubka = rubka;
            DopColor_1 = dopColor_1;
            Orudie = orudie;
            Razmetka = razmetka;
        }
        public Avianos(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 10)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                FirstLift = Convert.ToBoolean(strs[4]);
                SecondLift = Convert.ToBoolean(strs[5]);
                Rubka = Convert.ToBoolean(strs[6]);
                DopColor_1 = Color.FromName(strs[7]);
                Orudie = Convert.ToBoolean(strs[8]);
                Razmetka = Convert.ToBoolean(strs[9]);
            }
        }
        public override void DrawShep(Graphics g)
        {
            base.DrawShep(g);
            Brush spoiler = new SolidBrush(DopColor);
            if (FirstLift)
            {
                g.FillRectangle(spoiler, _startPosX + 10, _startPosY + 10, 10, 10);
            }
            if (SecondLift)
            {
                g.FillRectangle(spoiler, _startPosX + 40, _startPosY + 10, 10, 10);
            }
            if (Rubka)
            {
                g.FillRectangle(spoiler, _startPosX + 30, _startPosY + 25, 5, 5);
            }
            Brush spoiler_1 = new SolidBrush(DopColor_1);
            Pen pen = new Pen(DopColor_1);
            if (Orudie)
            {
                g.FillRectangle(spoiler_1, _startPosX + 62, _startPosY + 12, 3, 3);
            }
            if (Razmetka)
            {
                g.DrawLine(pen, _startPosX + 20, _startPosY + 15, _startPosX + 40, _startPosY + 15);
            }
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + FirstLift + ";" +
           SecondLift + ";" + Rubka + ";" + DopColor_1.Name + ";" + Orudie + ";" + Razmetka;
        }
    }
}
               